using copartnership.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace copartnership.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUsers, AppRoles, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OrderStatus> orderStatuses { get; set; }
        public DbSet<ParnerForm> parnerForms { get; set; }
        public DbSet<AppUsers> appUsers { get; set; }
        public DbSet<AppRoles> appRoles { get; set; }
    }
}