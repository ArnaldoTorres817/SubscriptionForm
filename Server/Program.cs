using Microsoft.EntityFrameworkCore;
using SubscriptionForm.Data;
using SubscriptionForm.Data.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddDbContext<SubscriptionFormContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"));
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors(options =>
{
    options.AllowAnyOrigin();
});

app.MapPost("/subscribe", async (Subscriber subscriber, SubscriptionFormContext context, ILoggerFactory loggerFactory) =>
{
    var logger = loggerFactory.CreateLogger("SubscribeEndpoint");

    logger.LogInformation("Hit /subscribe Endpoint");

    var subscriberWithSameEmail = await context.Subscribers.SingleOrDefaultAsync(s => s.Email.Equals(subscriber.Email));

    logger.LogInformation($"Susbcriber {subscriberWithSameEmail?.Email}");

    if (subscriberWithSameEmail is not null)
    {
        return Results.Conflict(new { Error = $"Email {subscriber.Email} already subscribed." });
    }

    var createdSubscriber = await context.Subscribers.AddAsync(subscriber);

    await context.SaveChangesAsync();

    logger.LogInformation($"Create subscriber {subscriber.Id}");

    return Results.Created(subscriber.Id.ToString(), new { Id = subscriber.Id });
});

app.Run();
