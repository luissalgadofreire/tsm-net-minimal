using Microsoft.EntityFrameworkCore;

namespace TheSaultyMonk.Minimal.Representation;

public class ApplicationDbContext : DbContext
{
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> cxSettings) :
        base(cxSettings) { }
    
    public DbSet<ContactMechanism> ContactMechanism => Set<ContactMechanism>();
    public DbSet<ContactMechanismLink> ContactMechanismLink => Set<ContactMechanismLink>();
}