using Microsoft.EntityFrameworkCore;
using SubscriptionForm.Data.Entities;

namespace SubscriptionForm.Data.Mapping
{
    public partial class SubscriberMap
        : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Subscriber> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Subscriber", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.AdditionalDetails)
                .HasColumnName("AdditionalDetails")
                .HasColumnType("ntext");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Subscriber";
        }

        public struct Columns
        {
            public const string Id = "Id";
            public const string Name = "Name";
            public const string Email = "Email";
            public const string AdditionalDetails = "AdditionalDetails";
        }
        #endregion
    }
}
