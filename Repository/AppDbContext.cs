using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ArticleLike> ArticleLikes { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ReportCategory> ReportCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ArticleLike>()
                .HasKey(l => new { l.ArticleId, l.UserId });
            builder.Entity<ArticleLike>()
                .HasOne(al => al.Article)
                .WithMany(a => a.ArticleLikes)
                .HasForeignKey(al => al.ArticleId);
            builder.Entity<ArticleLike>()
                .HasOne(al => al.User)
                .WithMany(u => u.ArticleLikes)
                .HasForeignKey(al => al.UserId);

            builder.Entity<Report>()
                .HasKey(r => new { r.ArticleId, r.UserId, r.ReportCategoryId });
            builder.Entity<Report>()
                .HasOne(r => r.Article)
                .WithMany(a => a.Reports)
                .HasForeignKey(r => r.ArticleId);
            builder.Entity<Report>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reports)
                .HasForeignKey(r => r.UserId);
            builder.Entity<Report>()
                .HasOne(r => r.ReportCategory)
                .WithMany(rc => rc.Reports)
                .HasForeignKey(r => r.ReportCategoryId);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "5D4135A4-6F21-4833-81D1-128104AA12C0",
                Name = "superadmin",
                NormalizedName = "SUPERADMIN"
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

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "5D4135A4-6F21-4833-81D1-128104AA12C0",
                UserId = "DD20FD22-4350-4D1C-98C4-E82F21C1F414"
            });

            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = Guid.NewGuid(),
                Name = "Пропаганда наркотиков"
            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = Guid.NewGuid(),
                Name = "Порнография"
            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = Guid.NewGuid(),
                Name = "Продажа оружия"
            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = Guid.NewGuid(),
                Name = "Мошенничество"
            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = Guid.NewGuid(),
                Name = "Призыв к суициду"
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = Guid.NewGuid(),
                Name = "IT",
                BeName = "IT",
                EnName = "IT"
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = Guid.NewGuid(),
                Name = "Спорт",
                BeName = "Спорт",
                EnName = "Sport"
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = Guid.NewGuid(),
                Name = "Музыка",
                BeName = "Музыка",
                EnName = "Music"
            });
        }
    }

    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=(local)\\SQLEXPRESS; Database=MyBlog; Persist Security Info=false; User ID='sa'; Password='admin'; MultipleActiveResultSets=True; Trusted_Connection=False;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
