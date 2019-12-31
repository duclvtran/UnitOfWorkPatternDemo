using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UnitOfWorkPatternDemo.Entities;

namespace UnitOfWorkPatternDemo.Repository
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=LocalConnectionString")
        {
        }

        public DbSet<Test> Imei { get; set; }
    }
}