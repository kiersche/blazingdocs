using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IPropertyRepository
    {
        Task AddProperty(Property property);
        Task UpdatePropertyValues(int id, Action<Property> valueUpdater);
    }

    public class PropertyRepository : IPropertyRepository
    {
        private readonly DmsDbContext dmsDbContext;
        private readonly IEntityPropertyUpdater<Property, int> entityPropertyUpdater;

        public PropertyRepository(DmsDbContext dmsDbContext,
            IEntityPropertyUpdater<Property, int> entityPropertyUpdater)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = id => new Property { PropertyId = id };
        }

        public async Task AddProperty(Property property)
        {
            dmsDbContext.Add<Property>(property);
            await dmsDbContext.SaveChangesAsync();
        }

        public async Task UpdatePropertyValues(int id, Action<Property> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
