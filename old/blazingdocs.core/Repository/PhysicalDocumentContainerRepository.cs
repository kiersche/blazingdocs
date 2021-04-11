using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IPhysicalDocumentContainerRepository
    {
        Task AddContainer(PhysicalDocumentContainer container);
        Task<PhysicalDocumentContainer> GetById(int id);
        Task UpdateContainerValues(int id, Action<PhysicalDocumentContainer> valueUpdater);
    }

    public class PhysicalDocumentContainerRepository : IPhysicalDocumentContainerRepository
    {
        private readonly DmsDbContext dbContext;
        private readonly IEntityPropertyUpdater<PhysicalDocumentContainer, int> entityPropertyUpdater;

        public PhysicalDocumentContainerRepository(DmsDbContext dbContext,
            IEntityPropertyUpdater<PhysicalDocumentContainer, int> entityPropertyUpdater)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = id => new PhysicalDocumentContainer { PhysicalDocumentContainerId = id };
        }

        public async Task AddContainer(PhysicalDocumentContainer container)
        {
            dbContext.Add(container);
            await dbContext.SaveChangesAsync();
        }

        public async Task<PhysicalDocumentContainer> GetById(int id)
        {
            return await dbContext.PhysicalDocumentContainers.AsNoTracking()
                .Where(_ => _.PhysicalDocumentContainerId == id)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateContainerValues(int id, Action<PhysicalDocumentContainer> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
