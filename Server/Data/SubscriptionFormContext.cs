using Microsoft.EntityFrameworkCore;
using SubscriptionForm.Data.Entities;
using SubscriptionForm.Data.Mapping;

namespace SubscriptionForm.Data;

public partial class SubscriptionFormContext : DbContext
{
    public SubscriptionFormContext(DbContextOptions<SubscriptionFormContext> options)
        : base(options)
    {
    }

    #region Generated Properties
    public virtual DbSet<Subscriber> Subscribers { get; set; } = null!;

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Generated Configuration
        modelBuilder.ApplyConfiguration(new SubscriberMap());
        #endregion
    }
}
