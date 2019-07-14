using Insights.Models;
using Insights.Repositories;
using Insights.ViewModels;
using System.Collections.Generic;
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
        public IEnumerable<object> Get([FromUri] Mechanics mechanics)
        {
            return _insights.GetAll(mechanics);
        }
    }
}