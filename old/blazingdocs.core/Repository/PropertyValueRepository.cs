using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IPropertyValueRepository
    {
        Task AddPropertyValue(PropertyValue propertyValue);
        Task UpdatePropertyValueValues(int id, Action<PropertyValue> valueUpdater);
    }

    public class PropertyValueRepository : IPropertyValueRepository
    {
        private readonly DmsDbContext dmsDbContext;
        private readonly IEntityPropertyUpdater<PropertyValue, int> entityPropertyUpdater;

        public PropertyValueRepository(DmsDbContext dmsDbContext,
            IEntityPropertyUpdater<PropertyValue, int> entityPropertyUpdater)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = id => new PropertyValue { PropertyValueId = id };
        }

        public async Task AddPropertyValue(PropertyValue propertyValue)
        {
            dmsDbContext.Add<PropertyValue>(propertyValue);
            await dmsDbContext.SaveChangesAsync();
        }

        public async Task UpdatePropertyValueValues(int id, Action<PropertyValue> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
