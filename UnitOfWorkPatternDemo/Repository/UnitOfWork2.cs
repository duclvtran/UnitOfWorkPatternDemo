using System.Data.Entity;

namespace UnitOfWorkPatternDemo.Repository
{
    public class UnitOfWork2 : IUnitOfWork2
    {
        public DbContext context { get; }

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

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
    }
}