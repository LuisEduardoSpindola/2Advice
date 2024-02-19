using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InfraestructureLayer.Data;

namespace InfraestructureLayer.Data;

public class AdvContext : IdentityDbContext<User>
{
    public AdvContext(DbContextOptions<AdvContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
