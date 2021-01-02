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
                Id = new Guid("A2D3B7F5-4AE7-4D16-AB6C-378482E2A4BF"),
                Name = "Спам",
                BeName = "Спам",
                EnName = "Spam"
            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = new Guid("6361AE44-67D4-4CA9-BA22-D8AB68EAA79B"),
                Name = "Пропаганда наркотиков",
                BeName = "Прапаганда наркотыкаў",
                EnName = "Promotion of drugs"

            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = new Guid("F1B06C90-DC89-4C39-A39E-0285EEE86ED6"),
                Name = "Порнография",
                BeName = "Парнаграфія",
                EnName = "Pornography"
            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = new Guid("6C1ECC1A-C238-44B1-85D4-5749F167676C"),
                Name = "Продажа оружия",
                BeName = "Прадажа зброі",
                EnName = "Weaponssale"
            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = new Guid("776B56D4-9059-4379-A388-E1BCE3CF4EF9"),
                Name = "Мошенничество",
                BeName = "Жульніцтва",
                EnName = "Fraud"
            });
            builder.Entity<ReportCategory>().HasData(new ReportCategory
            {
                Id = new Guid("DB71DF6A-D946-4AEC-8F7E-625AB55B22D7"),
                Name = "Призыв к суициду",
                BeName = "Заклік да суіцыду",
                EnName = "The call to suicide"
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = new Guid("96F80EC3-2401-4CCB-B6F3-DB92E986327B"),
                Name = "IT",
                BeName = "IT",
                EnName = "IT"
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = new Guid("460BC6DE-6728-4798-8232-8FB98BF0D20E"),
                Name = "Спорт",
                BeName = "Спорт",
                EnName = "Sport"
            });

            builder.Entity<Category>().HasData(new Category
            {
                Id = new Guid("793E3729-40F3-4306-9F64-37EA397A286C"),
                Name = "Музыка",
                BeName = "Музыка",
                EnName = "Music"
            });
        }
    }
}
