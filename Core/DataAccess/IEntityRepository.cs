using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
// core katmanı diğer katmanları referans almaz.
namespace Core.DataAccess
{                                       // generic constrain , class: referans tip olbilir demek 
                                            // ve IEntityden implemente olan bir şey olabilir.
                                            // new : newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
