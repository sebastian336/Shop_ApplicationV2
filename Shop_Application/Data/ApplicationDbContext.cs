using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop_Application.Models;

namespace Shop_Application.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Shop_Application.Models.Car> Car { get; set; }
        public DbSet<Shop_Application.Models.Category> Category { get; set; }
        public DbSet<Shop_Application.Models.Order> Order { get; set; }
        public DbSet<Shop_Application.Models.PlacementOfOrder> PlacementOfOrder { get; set; }
    }
}