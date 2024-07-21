using BLL.ManagerServices.Abstracts;
using DAL.Repositories.Abstracts;
using ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ManagerServices.Concretes
{
    public class BaseManager<T>:IManager<T>where T : class,IEntity
    {
        protected Irepository<T> _irp;
        public BaseManager(Irepository<T> irp)
        {
            _irp = irp;
        }

        public string Add(T item)
        {
            //if (item.CreatedDate != null)
            //{
            //    _irp.Add(item);
            //    return "ekleme başarılı";
            //}
            return "ekleme başarısız";
        }

        public async Task AddRange(T list)
        {
            await _irp.AddRange(list);
        }

        public async Task<bool> Any(Expression<Func<T, bool>> exp)
        {
            return await _irp.Any(exp);
        }

        public async Task Delete(T item)
        {
             await _irp.Delete(item);
        }

        public void DeleteAll()
        {
            _irp.DeleteAll();
        }

        public async Task DeleteRange(T item)
        {
             await _irp.DeleteRange(item);
        }

        public async Task<T> Find(int id)
        {
            return await _irp.Find(id);
        }

        public async Task<T> FirsOrDefault(Expression<Func<T, bool>> exp)
        {
            return await _irp.FirsOrDefault(exp);
        }

        public IQueryable<T> GetAll()
        {
            return _irp.GetAll();
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _irp.Select(exp);
        }

        public async Task Update(T item)
        {
           await _irp.Update(item);
        }

        public async Task UpdateRange(T item)
        {
            await _irp.UpdateRange(item);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
            return _irp.Where(exp);
        }
    }
}
