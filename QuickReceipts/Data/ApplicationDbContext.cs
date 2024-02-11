using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuickReceipts.Models;

namespace QuickReceipts.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; } 

        public DbSet<Product> Products { get; set; } 
        public DbSet<Settings> Settings { get; set; } 
    }
}