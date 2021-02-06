
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

// CORE KATMANI DİĞER KATMANLARA BAĞIMLI DEĞİLDİR.

namespace Core.DataAccess
{
    //GENERIC CONSTRAINT
    // Class: Referans olmalı.
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new() : new'lenebilir olmalı.
    public interface IEntityRepository<T> where T:class,IEntity,new()  // STANDART OLUŞTURMA.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAllByCategory(int categoryId);
    }
}
