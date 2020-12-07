using Entities;
using Repository;
using Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.EntityFramework
{
    public class EFReportRepository : IReportRepository
    {
        private readonly AppDbContext context;
        public EFReportRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteReport(Guid articleId, Guid reportCategoryId, string userId)
        {
            context.Reports.Remove(new Report() { ArticleId = articleId, ReportCategoryId = reportCategoryId, UserId = userId});
            context.SaveChanges();
        }

        public Report GetReport(Guid id)
        {
            var report = context.Reports.FirstOrDefault(r=>r.Id == id);
            return report;
        }
        public Report GetReport(Guid articleId, Guid reportCategoryId, string userId)
        {
            var report = context.Reports.Where(r => r.ArticleId == articleId && r.ReportCategoryId == reportCategoryId)
                .FirstOrDefault(r=>r.UserId == userId);
            return report;
        }

        public IQueryable<Report> GetReports()
        {
            context.Reports.Include(r => r.ReportCategory).ToList();
            context.Reports.Include(r => r.Article).ToList();
            context.Reports.Include(r => r.User).ToList();
            return context.Reports;
        }

        public IQueryable<Report> GetReportsByArticle(Article article)
        {
            var reports = context.Reports.Where(r => r.ArticleId == article.Id);
            return reports;
        }

        public IQueryable<Report> GetReportsByCategory(ReportCategory category)
        {
            var reports = context.Reports.Where(r => r.ReportCategoryId == category.Id);
            return reports;
        }

        public IQueryable<Report> GetReportsByUser(User user)
        {
            var reports = context.Reports.Where(r => r.UserId == user.Id);
            return reports;
        }

        public void SaveReport(Report report)
        {
            if (report.Id == default)
            {
                context.Entry(report).State = EntityState.Added;
            }
            else
            {
                context.Entry(report).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
