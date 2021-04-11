using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IPhysicalDocumentRepository
    {
        Task AddPhysicalDocument(PhysicalDocument container);
        Task<PhysicalDocument> GetById(int id);
        Task UpdatePhysicalDocumentValues(int id, Action<PhysicalDocument> valueUpdater);
    }

    public class PhysicalDocumentRepository : IPhysicalDocumentRepository
    {
        private readonly DmsDbContext dbContext;
        private readonly IEntityPropertyUpdater<PhysicalDocument, int> entityPropertyUpdater;

        public PhysicalDocumentRepository(DmsDbContext dbContext,
            IEntityPropertyUpdater<PhysicalDocument, int> entityPropertyUpdater)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = id => new PhysicalDocument { PhysicalDocumentId = id };
        }

        public async Task AddPhysicalDocument(PhysicalDocument physicalDocument)
        {
            dbContext.Add(physicalDocument);
            await dbContext.SaveChangesAsync();
        }

        public async Task<PhysicalDocument> GetById(int id)
        {
            return await dbContext.PhysicalDocuments.AsNoTracking()
                .Where(_ => _.PhysicalDocumentId == id)
                .FirstOrDefaultAsync();
        }

        public async Task UpdatePhysicalDocumentValues(int id, Action<PhysicalDocument> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
