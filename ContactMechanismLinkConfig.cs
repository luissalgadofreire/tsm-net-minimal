using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TheSaultyMonk.Minimal.Representation;

public class ContactMechanismLinkConfig : IEntityTypeConfiguration<ContactMechanismLink>
{
    public void Configure(EntityTypeBuilder<ContactMechanismLink> builder)
    {
        var tableName = builder.Metadata.GetTableName();

        // Foreign Keys
        builder
            .HasOne(contactMechanismLink => contactMechanismLink.FromContactMechanism)
            .WithMany(contactMechanism => contactMechanism.Links)
            .HasForeignKey(contactMechanismLink => contactMechanismLink.FromContactMechanismId)
            .HasConstraintName($"fk_{tableName}_from_contact_mechanism_id")
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        builder
            .HasOne(contactMechanismLink => contactMechanismLink.ToContactMechanism)
            .WithMany()
            .HasForeignKey(contactMechanismLink => contactMechanismLink.ToContactMechanismId)
            .HasConstraintName($"fk_{tableName}_to_contact_mechanism_id")
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}