using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IReportCategoryRepository
    {
        IQueryable<ReportCategory> GetReportCategories();
        ReportCategory GetReportCategory(Guid id);
        ReportCategory GetReportCategory(string categoryName);
        void DeleteReportCategory(Guid id);
        void SaveReportCategory(ReportCategory category);
        IEnumerable<string> GetReportCategoriesStringList();
        IEnumerable<string> GetReportCategoriesStringList(string currentCulture);
    }
}
