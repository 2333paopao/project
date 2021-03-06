﻿using System;
using System.Data.Entity;
using Project.Respository.UnitOfWork;

namespace Project.Respository
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        private DbContext _dbContext;

        public EntityFrameworkUnitOfWork(IDbContextProvider dbProvider)
        {
            _dbContext = dbProvider.GetTrainingDbContext();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
                _dbContext = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
