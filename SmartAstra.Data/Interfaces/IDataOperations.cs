using SmartAstra.Framework.Entities.Interfaces;
using System.Collections.Generic;

namespace SmartAstra.Data.Interfaces
{
    public interface IDataOperations<T> where T : IEntity
    {
        T Get(int id);
        IList<T> GetAll();
        T Insert(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
