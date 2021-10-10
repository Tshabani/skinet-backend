using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Skinet.Authorization.Roles;
using Skinet.Authorization.Users;
using Skinet.MultiTenancy;
using Skinet.Domain;

namespace Skinet.EntityFrameworkCore
{
    public class SkinetDbContext : AbpZeroDbContext<Tenant, Role, User, SkinetDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SkinetDbContext(DbContextOptions<SkinetDbContext> options)
            : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Delivery> Deliverys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
