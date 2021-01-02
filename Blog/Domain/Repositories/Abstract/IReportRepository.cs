using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories.Abstract
{
    public interface IReportRepository
    {
        IQueryable<Report> GetReports();
        Report GetReport(Guid id);
        Report GetReport(Guid articleId, Guid reportCategoryId, string userId);
        IQueryable<Report> GetReportsByUser(User user);
        IQueryable<Report> GetReportsByArticle(Article article);
        IQueryable<Report> GetReportsByCategory(ReportCategory category);
        void SaveReport(Report comment);
        void DeleteReport(Guid articleId, Guid reportCategoryId, string userId);
    }
}
