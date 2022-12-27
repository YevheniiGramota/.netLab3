using Lab3.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab3.DAL.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.Property(p => p.Name)
            .HasMaxLength(300)
            .IsRequired();

        builder.HasIndex(p => p.Name)
            .IsUnique();
    }
}
