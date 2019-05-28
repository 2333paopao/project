namespace Project.Respository.UnitOfWork
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork GetCurrentUnitOfWork();
    }
}
