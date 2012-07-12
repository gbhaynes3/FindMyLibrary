using System.Linq;

namespace FindMyLibrary.Web.Models.DataAccess
{
    public interface IRepository<T>
    {
        IQueryable<T> All { get; }
        T Find(int id);
        void InsertOrUpdate(T entity);
        void Delete(int id);
        void Save();
    }
}
