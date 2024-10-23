using System;
using System.Collections.Generic;

namespace WpfApp1
{
    //позв. работать с разными сущностями 
    internal interface INterfaceGenericRep<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}