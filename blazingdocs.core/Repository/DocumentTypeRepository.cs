using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IDocumentTypeRepository
    {
        Task AddDocumentType(DocumentType documentType);
        Task<DocumentType> GetDocumentTypeById(int id);
        Task UpdateDocumentTypeValues(int id, Action<DocumentType> valueUpdater);
    }

    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly DmsDbContext dmsDbContext;
        private readonly IEntityPropertyUpdater<DocumentType, int> entityPropertyUpdater;

        public DocumentTypeRepository(DmsDbContext dmsDbContext,
            IEntityPropertyUpdater<DocumentType, int> entityPropertyUpdater)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = id => new DocumentType { DocumentTypeId = id };
        }

        public async Task AddDocumentType(DocumentType documentType)
        {
            dmsDbContext.Add<DocumentType>(documentType);
            await dmsDbContext.SaveChangesAsync();
        }

        public async Task<DocumentType> GetDocumentTypeById(int id)
        {
            return await dmsDbContext.DocumentTypes.AsNoTracking()
                .FirstOrDefaultAsync(_ => _.DocumentTypeId == id);
        }

        public async Task UpdateDocumentTypeValues(int id, Action<DocumentType> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
