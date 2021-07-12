﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;



namespace Pact
{
    public interface IBaseActionDB<T>
    {
        IQueryable<T> ReturnAll();
        IQueryable<T> ReturnDistinct(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
