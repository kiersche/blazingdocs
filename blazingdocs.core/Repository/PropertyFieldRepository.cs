using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IPropertyFieldRepository
    {
        Task AddPropertyField(PropertyField propertyField);
        Task<List<PropertyField>> GetAllPropertyFields();
        Task UpdatePropertyFieldValues(int id, Action<PropertyField> valueUpdater);
    }

    public class PropertyFieldRepository : IPropertyFieldRepository
    {
        private readonly DmsDbContext dmsDbContext;
        private readonly IEntityPropertyUpdater<PropertyField, int> entityPropertyUpdater;

        public PropertyFieldRepository(DmsDbContext dmsDbContext,
            IEntityPropertyUpdater<PropertyField, int> entityPropertyUpdater)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
            this.entityPropertyUpdater = entityPropertyUpdater ?? throw new ArgumentNullException(nameof(entityPropertyUpdater));
            this.entityPropertyUpdater.EntityFactoryFunc = id => new PropertyField { PropertyFieldId = id };
        }

        public async Task AddPropertyField(PropertyField propertyField)
        {
            dmsDbContext.Add<PropertyField>(propertyField);
            await dmsDbContext.SaveChangesAsync();
        }

        public async Task<List<PropertyField>> GetAllPropertyFields()
        {
            return await dmsDbContext.PropertyFields.AsNoTracking().ToListAsync();
        }

        public async Task UpdatePropertyFieldValues(int id, Action<PropertyField> valueUpdater)
        {
            await entityPropertyUpdater.UpdateEntity(id, valueUpdater);
        }
    }
}
