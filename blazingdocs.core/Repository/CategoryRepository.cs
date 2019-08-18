using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace blazingdocs.core.Repository
{
    public interface ICategoryRepository
    {
        Task AddCategory(Category category);
        Task<List<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly DmsDbContext dmsDbContext;

        public CategoryRepository(DmsDbContext dmsDbContext)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
        }

        public async Task AddCategory(Category category)
        {
            dmsDbContext.Add<Category>(category);
            await dmsDbContext.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await dmsDbContext.Categories.AsNoTracking()
                .ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await dmsDbContext.Categories.AsNoTracking()
                .Where(_ => _.CategoryId == id)
                .FirstOrDefaultAsync();
        }
    }
}
