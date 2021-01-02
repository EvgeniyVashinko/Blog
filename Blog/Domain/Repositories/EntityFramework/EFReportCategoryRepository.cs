using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories.EntityFramework
{
    public class EFReportCategoryRepository : IReportCategoryRepository
    {
        private readonly AppDbContext context;
        public EFReportCategoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void DeleteReportCategory(Guid id)
        {
            context.ReportCategories.Remove(new ReportCategory() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<ReportCategory> GetReportCategories()
        {
            return context.ReportCategories;
        }

        public IEnumerable<string> GetReportCategoriesStringList()
        {
            List<string> list = new List<string>();
            foreach (var cat in GetReportCategories())
            {
                list.Add(cat.Name);
            }
            return list;
        }

        public IEnumerable<string> GetReportCategoriesStringList(string currentCulture)
        {
            List<string> list = new List<string>();

            if (currentCulture == "ru")
            {
                foreach (var cat in GetReportCategories())
                {
                    list.Add(cat.Name);
                }
            }
            else if (currentCulture == "be")
            {
                foreach (var cat in GetReportCategories())
                {
                    list.Add(cat.BeName);
                }
            }
            else if (currentCulture == "en")
            {
                foreach (var cat in GetReportCategories())
                {
                    list.Add(cat.EnName);
                }
            }

            return list;
        }

        public ReportCategory GetReportCategory(Guid id)
        {
            return context.ReportCategories.FirstOrDefault(c => c.Id == id);
        }

        public ReportCategory GetReportCategory(string categoryName)
        {
            return context.ReportCategories.FirstOrDefault(c => c.Name == categoryName || c.EnName == categoryName ||
            c.BeName == categoryName);
        }

        public void SaveReportCategory(ReportCategory category)
        {
            if (category.Id == default)
            {
                context.Entry(category).State = EntityState.Added;
            }
            else
            {
                context.Entry(category).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
