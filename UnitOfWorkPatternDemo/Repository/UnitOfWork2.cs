using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace UnitOfWorkPatternDemo.Repository
{
    public class UnitOfWork2 : IUnitOfWork2
    {
        public DbContext context { get; }
        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public UnitOfWork2()
        {
            this.context = new DataContext();
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)) == true)
            {
                return repositories[typeof(T)] as IRepository<T>;
            }
            IRepository<T> repo = new Repository<T>();
            repositories.Add(typeof(T), repo);
            return repo;
            //throw new System.NotImplementedException();
        }
    }
}