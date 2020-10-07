using Blog.Domain.Entities;
using Blog.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories.EntityFramework
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext context;
        public EFCategoryRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteCategory(Guid id)
        {
            context.Categories.Remove(new Category() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<Article> GetArticlesByCategory(Category category)
        {
            //context.Articles.Include(a => a.ArticleLikes).ToList();
            var articles = context.Articles.Where(c => c.Category.Equals(category));
            articles.Include(a => a.ArticleLikes).ToList();
            return articles;
        }

        public IQueryable<Article> GetArticlesByCategory(Guid categoryId)
        {
            //context.Articles.Include(a => a.ArticleLikes).ToList();
            var articles = context.Articles.Where(c => c.CategotyId == categoryId);
            articles.Include(a => a.ArticleLikes).ToList();
            return articles;
        }

        public IQueryable<Category> GetCategories()
        {
            return context.Categories;
        }
        public IEnumerable<string> GetCategoriesStringList()
        {
            List<string> list = new List<string>();
            foreach(var cat in GetCategories())
            {
                list.Add(cat.Name);
            }
            return list;
        }

        public Category GetCategory(Guid id)
        {
            return context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public Category GetCategory(string categoryName)
        {
            return context.Categories.FirstOrDefault(c => c.Name == categoryName);
        }

        public void SaveCategory(Category category)
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
