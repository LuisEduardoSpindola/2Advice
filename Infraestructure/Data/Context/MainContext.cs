using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Models.Advice;
using Domain.Models.User;

namespace Infraestructure.Data.Context.MainContext;

class MainContext : DbContext 
{
    public MainContext(DbContextOptions<MainContext> options) : base(options)
    {
        
    }    

    public DbSet<Advice> advices { get; set; }
    public DbSet<User> users { get; set; }
}
