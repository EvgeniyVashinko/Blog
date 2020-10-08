using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories.EntityFramework
{
    public class EFReportRepository : IReportRepository
    {
        private readonly AppDbContext context;
        public EFReportRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteReport(Guid id)
        {
            context.Reports.Remove(new Report() { Id = id });
            context.SaveChanges();
        }

        public Report GetReport(Guid id)
        {
            var reports = context.Reports.FirstOrDefault(r=>r.Id == id);
            return reports;
        }

        public IQueryable<Report> GetReports()
        {
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
