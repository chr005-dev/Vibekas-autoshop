using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Persist
{
    public interface IPersist<T>
    {
        IEnumerable<T> GetAll();
        T? GetById(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
