using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UnitOfWorkPatternDemo.Repository
{
    public interface IUnitOfWork2 : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        void Commit();
    }

    public interface IUnitOfWork2<TContext> : IUnitOfWork where TContext : DbContext
    {
        TContext Context { get; }
    }
}