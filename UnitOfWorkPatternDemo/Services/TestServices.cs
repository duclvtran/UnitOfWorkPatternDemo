using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWorkPatternDemo.Entities;
using UnitOfWorkPatternDemo.Repository;

namespace UnitOfWorkPatternDemo.Services
{
    public class TestServices //: ITestServices
    {
        private readonly IUnitOfWork2 _unitOfWork;
        private IRepository2<Test> _imeiReponsitory;

        public TestServices(IUnitOfWork2 unitOfWork, IRepository2<Test> imeiReponsitory)
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
            _unitOfWork.GetRepository<Test>().Add(entity);
            _unitOfWork.Commit();
        }

        public IEnumerable<Test> List()
        {
            return _unitOfWork.GetRepository<Test>().Get();
        }

        public void Update(Test entity)
        {
            throw new NotImplementedException();
        }
    }
}