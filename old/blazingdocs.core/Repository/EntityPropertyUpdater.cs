using blazingdocs.core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.core.Repository
{
    public interface IEntityPropertyUpdater<TEntity, TKey>
    {
        Func<TKey, TEntity> EntityFactoryFunc { get; set; }

        Task UpdateEntity(TKey key, Action<TEntity> entityUpdater);
    }

    public class EntityPropertyUpdater<TEntity, TKey> : IEntityPropertyUpdater<TEntity, TKey>
    {
        private readonly DmsDbContext dmsDbContext;

        public EntityPropertyUpdater(DmsDbContext dmsDbContext)
        {
            this.dmsDbContext = dmsDbContext ?? throw new ArgumentNullException(nameof(dmsDbContext));
        }

        public Func<TKey, TEntity> EntityFactoryFunc { get; set; }

        private TEntity GetAttachedEntityToUpdate(TKey key)
        {
            var newEntity = EntityFactoryFunc(key);
            dmsDbContext.Attach(newEntity);
            return newEntity;
        }

        public async Task UpdateEntity(TKey key, Action<TEntity> entityUpdater)
        {
            var entity = GetAttachedEntityToUpdate(key);
            entityUpdater(entity);
            await dmsDbContext.SaveChangesAsync();
        }
    }
}
