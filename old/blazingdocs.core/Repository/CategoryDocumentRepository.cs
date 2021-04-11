using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface ICategoryDocumentRepository
    {
        Task AddCategoryDocument(CategoryDocument categoryDocument);
    }

    public class CategoryDocumentRepository : ICategoryDocumentRepository
    {
        private readonly DmsDbContext dmsDbContext;

        public CategoryDocumentRepository(DmsDbContext dmsDbContext)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
        }

        public async Task AddCategoryDocument(CategoryDocument categoryDocument)
        {
            dmsDbContext.Add<CategoryDocument>(categoryDocument);
            await dmsDbContext.SaveChangesAsync();
        }
    }
}
