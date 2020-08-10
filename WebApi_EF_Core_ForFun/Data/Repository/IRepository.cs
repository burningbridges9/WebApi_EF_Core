using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_EF_Core_ForFun.Models;

namespace WebApi_EF_Core_ForFun.Data.Repository
{
    public interface IRepository<T> where T: class, new()
    {
        void Create(T item);
        void Delete(int id);
        void Update(T item);
        T Get(int id);
        IEnumerable<T> GetList();

        void SaveChanges();
    }
}
