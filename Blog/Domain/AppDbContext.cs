using Blog.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<User>().HasData(new User
            {
                Id = "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "email@gmail.com",
                NormalizedEmail = "EMAIL@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                SecurityStamp = string.Empty

            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                UserId = "DD20FD22-4350-4D1C-98C4-E82F21C1F414"
            });
        }
    }
}
