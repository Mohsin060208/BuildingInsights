using Repository;
using System.Collections.Generic;
using System.Web.Http;
using Model;

namespace Insights.Controllers
{

    public class MechanicsController : ApiController
    {
        private MechanicsRepository _mechanicsRepository;
        public MechanicsController()
        {
            _mechanicsRepository = new MechanicsRepository();
        }
        [ActionName("GetFailureChartData")]
        [HttpGet]
        public List<object> GetFailureChartData([FromUri] Mechanics mechanics)
        {
            return _mechanicsRepository.GetMechanicsFailureByType(mechanics);
        }

        [ActionName("GetCostChartData")]
        [HttpGet]
        public List<object> GetCostChartData(Mechanics mechanics)
        {
            return _mechanicsRepository.GetMechanicsCostByType(mechanics);
        }

        [ActionName("InsertUpdateMechanicsFailure")]
        [HttpPost]
        public void InsertUpdateMechanicsFailure(Mechanics mechanics)
        {
            _mechanicsRepository.InsertUpdateMechanicsFailureByType(mechanics);
        }

        [ActionName("InsertUpdateMechanicsCost")]
        [HttpPost]
        public void InsertUpdateMechanicsCost(Mechanics mechanics)
        {
            _mechanicsRepository.InsertUpdateMechanicsCostByType(mechanics);
        }
    }
}