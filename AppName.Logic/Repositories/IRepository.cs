using AppName.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Logic.Repositories
{
    public interface IRepository<T> where T : BaseObject, new()
    {
        void Add(T entity);

        void Delete(T entity);

        void Delete(int id);

        T GetById(int id);

        IQueryable<T> GetAll();

        IQueryable<T> GetAllActive();

        void SaveChanges();
    }
}
