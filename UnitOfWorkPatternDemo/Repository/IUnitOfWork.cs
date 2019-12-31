using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UnitOfWorkPatternDemo.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext context { get; }

        void Commit();
    }
}