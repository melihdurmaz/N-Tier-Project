using DAL.Context;
using DAL.Repositories.Abstracts;
using ENTITIES.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class BaseRepository<T> : Irepository<T> where T : class, IEntity
    {
        MyContext _db;
        public BaseRepository(MyContext db)
        {
            _db = db;

        }
        public async Task Add(T item)
        {
            await _db.Set<T>().AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public async Task AddRange(T list)
        {
            await _db.Set<T>().AddRangeAsync(list);
            await _db.SaveChangesAsync();
        }



        public Task Delete(T item)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public Task DeleteRange(T item)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Find(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<T> FirsOrDefault(Expression<Func<T, bool>> exp)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(exp);
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            throw new NotImplementedException();
        }

        public Task Update(T item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRange(T item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Any(Expression<Func<T, bool>> exp)
        {
            return await _db.Set<T>().AnyAsync(exp);
        }
    }
}
