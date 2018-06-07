using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.DAL
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T t);
        void Update(T t);
        void Delete(T t);


    }
}
