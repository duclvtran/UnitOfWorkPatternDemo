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

        public DataController(IDataServices dataServices)
        {
            _dataServices = dataServices;
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
    }
}