using blazingdocs.core.Model;
using blazingdocs.Domain;
using System;
using System.Threading.Tasks;

namespace blazingdocs.Repositories
{
    internal class ObjectRepository : IObjectRepository
    {
        private readonly DmsDbContext dbContext;

        public ObjectRepository(DmsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task SaveCategoryAsync(Domain.Categories.Category category)
        {
            throw new NotImplementedException();
        }

        public Task SaveVirtualObjectAsync(Domain.VirtualObjects.VirtualObject virtualObject)
        {
            throw new NotImplementedException();
        }
    }
}
