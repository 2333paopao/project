using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Project.Data;

namespace Project.Respository
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        private readonly IDbContextProvider _dbContextProvider;
        protected ApplicationDbContext DbContext => _dbContextProvider.GetTrainingDbContext();

        protected BaseRepository(IDbContextProvider dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public TEntity Add(TEntity t)
        {
            DbContext.Set<TEntity>().Add(t);
            SafeSaveChanges();
            return t;
        }

        public void Edit(TEntity t)
        {
            var entry = DbContext.Entry(t);
            DbContext.Set<TEntity>().Attach(t);
            entry.State = EntityState.Modified;
            SafeSaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = Get(id);
            DbContext.Set<TEntity>().Remove(entity);
            SafeSaveChanges();
        }
        public TEntity Get(Guid id)
        {
            return DbContext.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>().ToList();
        }
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return DbContext.Set<TEntity>().Where(filter).ToList();
        }
        private void SafeSaveChanges()
        {
            foreach (var error in DbContext.GetValidationErrors())
            {
                var entityType = error.Entry.Entity.GetType().BaseType;

                foreach (var validationError in error.ValidationErrors)
                {
                    var property = entityType.GetProperty(validationError.PropertyName);
                    if (property.GetCustomAttributes(typeof(RequiredAttribute), true).Any())
                    {
                        property.GetValue(error.Entry.Entity, null);
                    }
                }
            }

            DbContext.SaveChanges();
        }
    }
}
