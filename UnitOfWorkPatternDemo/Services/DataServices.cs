using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWorkPatternDemo.Entities;
using UnitOfWorkPatternDemo.Repository;

namespace UnitOfWorkPatternDemo.Services
{
    public class DataServices : IDataServices
    {
        private IUnitOfWork _unitOfWork;
        private IRepository<Test> _imeiReponsitory;

        public DataServices(IUnitOfWork unitOfWork, IRepository<Test> imeiReponsitory)
        {
            _unitOfWork = unitOfWork;
            _imeiReponsitory = imeiReponsitory;
        }

        public Test Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Test entity)
        {
            _imeiReponsitory.Add(entity);
            _unitOfWork.Commit();
        }

        public IEnumerable<Test> List()
        {
            return _imeiReponsitory.Get();
        }

        public void Update(Test entity)
        {
            throw new NotImplementedException();
        }
    }
}