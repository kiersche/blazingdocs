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
        Task UpdateCategoryValues(int id, Action<Category> valueUpdater);
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly DmsDbContext dmsDbContext;
        private readonly IEntityPropertyUpdater<Category, int> entityPropertyUpdater;

        public CategoryRepository(DmsDbContext dmsDbContext, 
            IEntityPropertyUpdater<Category, int> entityPropertyUpdater)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = (id) => new Category { CategoryId = id };
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

        public async Task UpdateCategoryValues(int id, Action<Category> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
