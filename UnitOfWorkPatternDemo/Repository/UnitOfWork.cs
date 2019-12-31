using System.Data.Entity;

namespace UnitOfWorkPatternDemo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext context { get; }

        //public UnitOfWork(DbContext context)
        //{
        //    this.context = context;
        //}
        public UnitOfWork()
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
    }
}