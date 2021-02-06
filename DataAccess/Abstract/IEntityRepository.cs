using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class= referans tip
    //T, IEntity veya IEntity implemente eden bir nesne olabilir.
    //new : new'lenebilir olmalı (interface new'lenemediği için IEntity kullanılamaz)
    public interface IEntityRepository<T> where T:class, IEntity, new() 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Filtreleri getirmek için. 
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);     
    }
}
