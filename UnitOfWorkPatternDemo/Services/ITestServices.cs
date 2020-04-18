using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWorkPatternDemo.Entities;
using UnitOfWorkPatternDemo.Repository;

namespace UnitOfWorkPatternDemo.Services
{
    public interface ITestServices
    {
        IEnumerable<Test> List();

        Test Get(int id);

        void Insert(Test entity);

        void Update(Test entity);
    }
}