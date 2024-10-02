using BlazorCRUDWebsite.Data;
using BlazorCRUDWebsite.Infrastructure.Contracts;
using BlazorCRUDWebsite.Infrastructure.Repository;

namespace BlazorCRUDWebsite.UnitOfWork
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly EmployeeDBContext _context;
        public IEmployeeRepository EmployeeRepository { get; private set; }

        public UnitOfWorkService(EmployeeDBContext context)
        {
            _context = context;
            EmployeeRepository = new EmployeeRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
