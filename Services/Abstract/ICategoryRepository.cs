using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();
        Category GetCategory(Guid id);
        Category GetCategory(string categoryName);
        void DeleteCategory(Guid id);
        void SaveCategory(Category category);
        IQueryable<Article> GetArticlesByCategory(Category category);
        IQueryable<Article> GetArticlesByCategory(Guid categoryId);
        IEnumerable<string> GetCategoriesStringList();
        IEnumerable<string> GetCategoriesStringList(string currentCulture);
    }
}
