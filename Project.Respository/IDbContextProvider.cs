﻿using System;
using Castle.Windsor;
using Project.Data;

namespace Project.Respository
{
    public interface IDbContextProvider : IDisposable
    {
        ApplicationDbContext GetTrainingDbContext();
    }

    public class Disposable : IDisposable
    {
        private bool _isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                DisposeCore();
            }

            _isDisposed = true;
        }
        protected virtual void DisposeCore()
        {
        }
    }

    public class DbContextProvider : Disposable, IDbContextProvider
    {
        private readonly IWindsorContainer _container;

        public DbContextProvider(IWindsorContainer container)
        {
            _container = container;
        }

        public ApplicationDbContext GetTrainingDbContext()
        {
            return _container.Resolve<ApplicationDbContext>();
        }
    }
}
