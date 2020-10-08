using Blog.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class DataManager
    {
        public IArticleRepository Articles { get; set; }
        public ICommentRepository Comments { get; set; }
        public ICategoryRepository Categories { get; set; }
        public IReportCategoryRepository ReportCategories { get; set; }
        public IReportRepository Reports { get; set; }

        public DataManager(IArticleRepository articleRepository, ICommentRepository commentRepository, ICategoryRepository categoryRepository,
            IReportCategoryRepository reportCategoryRepository, IReportRepository reportRepository)
        {
            Articles = articleRepository;
            Comments = commentRepository;
            Categories = categoryRepository;
            ReportCategories = reportCategoryRepository;
            Reports = reportRepository;
        }
    }
}
