using Insights.Models;
using Insights.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Insights.Controllers
{
    public class InsightsController : ApiController
    {
        private InsightsRepository _insights;
        public InsightsController()
        {
            _insights = new InsightsRepository();
        }
        [ActionName("Get")]
        [HttpGet]
        public List<object> Get([FromUri] YearlyRecordBook yrb)
        {
            return _insights.GetAll(yrb);
        }
    }
}