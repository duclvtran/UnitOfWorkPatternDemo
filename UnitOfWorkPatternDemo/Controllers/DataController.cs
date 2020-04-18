using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitOfWorkPatternDemo.Services;

namespace UnitOfWorkPatternDemo.Controllers
{
    public class DataController : ApiController
    {
        private IDataServices _dataServices;
        private ITestServices _testServices;

        public DataController(IDataServices dataServices, ITestServices testServices)
        {
            _dataServices = dataServices;
            _testServices = testServices;
        }

        [HttpPost]
        public Object List()
        {
            try
            {
                var model = _dataServices.List();
                return model;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [HttpPost]
        public Object Test1()
        {
            try
            {
                var model = _testServices.List();
                return model;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}