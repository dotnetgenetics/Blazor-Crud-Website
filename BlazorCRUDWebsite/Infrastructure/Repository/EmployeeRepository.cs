using BlazorCRUDWebsite.Data;
using BlazorCRUDWebsite.Infrastructure.Contracts;
using BlazorCRUDWebsite.Model;

namespace BlazorCRUDWebsite.Infrastructure.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDBContext context) : base(context)
        { }
    }
}
