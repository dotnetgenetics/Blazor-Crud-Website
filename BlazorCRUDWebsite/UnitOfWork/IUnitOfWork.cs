using BlazorCRUDWebsite.Infrastructure.Contracts;

namespace BlazorCRUDWebsite.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
    }
}
