using blazingdocs.core.Model;
using blazingdocs.Domain;
using System;
using System.Threading.Tasks;
using File = blazingdocs.core.Model.File;

namespace blazingdocs.Repositories
{
    internal class ObjectRepository : IObjectRepository
    {
        private readonly DmsDbContext dbContext;

        public ObjectRepository(DmsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task SaveCategoryAsync(Domain.Category category)
        {
            throw new NotImplementedException();
        }

        public Task SaveVirtualObjectAsync(Domain.VirtualObjects.VirtualObject virtualObject)
        {
            throw new NotImplementedException();
        }

        public async Task<StoredFile> SaveFileAsync(StoredFileFactory storedFileFactory)
        {
            File file = File.FromStoredFileFactory(storedFileFactory);
            await dbContext.AddAsync(file);
            await dbContext.SaveChangesAsync();
            return storedFileFactory.ToStoredFile(new FileId(file.FileId));
        }
    }
}
