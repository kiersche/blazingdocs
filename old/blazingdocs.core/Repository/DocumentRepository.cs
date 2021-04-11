using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IDocumentRepository
    {
        Task AddDocument(Document document);
        Task<Document> GetDocumentById(int id);
        Task UpdateDocumentValues(int id, Action<Document> valueUpdater);
    }

    public class DocumentRepository : IDocumentRepository
    {
        private readonly DmsDbContext dmsDbContext;
        private readonly IEntityPropertyUpdater<Document, int> entityPropertyUpdater;

        public DocumentRepository(DmsDbContext dmsDbContext,
            IEntityPropertyUpdater<Document, int> entityPropertyUpdater)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = id => new Document { DocumentId = id };
        }

        public async Task AddDocument(Document document)
        {
            dmsDbContext.Add<Document>(document);
            await dmsDbContext.SaveChangesAsync();
        }

        public async Task<Document> GetDocumentById(int id)
        {
            return await dmsDbContext.Documents.AsNoTracking()
                .FirstOrDefaultAsync(_ => _.DocumentId == id);
        }

        public async Task UpdateDocumentValues(int id, Action<Document> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
