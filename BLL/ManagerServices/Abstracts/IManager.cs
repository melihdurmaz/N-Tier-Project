using ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ManagerServices.Abstracts
{
    public interface IManager<T> where T : class,IEntity
    {
        //list comamnds
        IQueryable<T> GetAll();

        //modify commands
       // Task Add(T item);
        string Add(T item);
        Task AddRange(T list);
        Task Update(T item);
        Task UpdateRange(T item);
        Task Delete(T item);
        Task DeleteRange(T item);
        void DeleteAll();

        //linq commands
        IQueryable<T> Where(Expression<Func<T, bool>> exp);
        Task<bool> Any(Expression<Func<T, bool>> exp);
        Task<T> FirsOrDefault(Expression<Func<T, bool>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);
        //find
        Task<T> Find(int id);

    }
}
