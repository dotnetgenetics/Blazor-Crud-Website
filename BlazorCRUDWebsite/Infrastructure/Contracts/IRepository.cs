using System.Linq.Expressions;

namespace BlazorCRUDWebsite.Infrastructure.Contracts
{
    public interface IRepository<T> where T : class
    {
        T GetByID(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T Entity);
        void Delete(T Delete);
        void Update(T Entity);
    }
}
