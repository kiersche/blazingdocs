using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IFileRepository
    {
        Task AddFile(File file);
        Task<File> GetFileById(int id);
        Task UpdateFileValues(int id, Action<File> valueUpdater);
    }

    public class FileRepository : IFileRepository
    {
        private readonly DmsDbContext dmsDbContext;
        private readonly IEntityPropertyUpdater<File, int> entityPropertyUpdater;

        public FileRepository(DmsDbContext dmsDbContext,
            IEntityPropertyUpdater<File, int> entityPropertyUpdater)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = id => new File { FileId = id };
        }

        public async Task AddFile(File file)
        {
            dmsDbContext.Add<File>(file);
            await dmsDbContext.SaveChangesAsync();
        }

        public async Task<File> GetFileById(int id)
        {
            return await dmsDbContext.Files.FirstOrDefaultAsync(_ => _.FileId == id);
        }

        public async Task UpdateFileValues(int id, Action<File> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
