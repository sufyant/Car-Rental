using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;


namespace Core.DataAccess
{
    // Generic Constraint
    // Class:   Reference
    // IEntity: Must be IEntitiy or IEntity implemented object
    // new():   Must be an object with new() operation
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}