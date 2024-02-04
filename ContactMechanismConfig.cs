using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TheSaultyMonk.Minimal.Representation;

public class ContactMechanismConfig : IEntityTypeConfiguration<ContactMechanism>
{
    public void Configure(EntityTypeBuilder<ContactMechanism> builder)
    {
        var tableName = builder.Metadata.GetTableName();
    }
}