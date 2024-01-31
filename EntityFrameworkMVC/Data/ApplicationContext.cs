using EntityFrameworkMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFrameworkMVC.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connecting lazy loading
            optionsBuilder.UseLazyLoadingProxies();   
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Company> Companies { get; set; } = null!;      
    }
}
