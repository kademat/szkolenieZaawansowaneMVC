using AppName.Domains;
using AppName.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.EFDataAccess
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseObject, new()
    {
        protected DataContext _db;

        public BaseRepository(DataContext db)
        {
            _db = db;
        }

        protected abstract DbSet<T> DbSet { get; }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(int id)
        {
            T entity = new T()
            {
                Id = id
            };

            DbSet.Remove(entity);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public IQueryable<T> GetAllActive()
        {
            return DbSet.Where(e => e.IsActive);
        }

        public T GetById(int id)
        {
            return DbSet.FirstOrDefault(e => e.Id == id);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
