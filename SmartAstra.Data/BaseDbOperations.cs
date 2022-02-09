using SmartAstra.Data.Interfaces;
using SmartAstra.Framework.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace SmartAstra.Data
{
    public abstract class BaseDbOperations<T> : IDataOperations<T> where T : IEntity
    {
        private AstraDbContext _dbContext;
        public BaseDbOperations()
        {
            _dbContext = new AstraDbContext();
            AstraDbContext = _dbContext;
        }

        public AstraDbContext AstraDbContext { get; set; }
        public abstract T Delete(T entity);
        public abstract T Get(int id);
        public abstract IList<T> GetAll();
        public abstract T Insert(T entity);
        public abstract T Update(T entity);

        //public void SaveChanges()
        //{
        //    var t = typeof(T);
        //    if(t is IEntityCreatedUpdatedInfo)
        //    {
        //        var d = t as IEntityCreatedUpdatedInfo;
        //        d.CreatedBy = 1;
        //        d.CreatedOn = DateTime.Now;
        //        d.UpdatedBy = 1;
        //        d.UpdatedOn = DateTime.Now;
        //    }
        //    AstraDbContext.SaveChanges();
        //}
    }
}
