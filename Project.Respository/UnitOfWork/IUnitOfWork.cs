using System;

namespace Project.Respository.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();
    }
}
