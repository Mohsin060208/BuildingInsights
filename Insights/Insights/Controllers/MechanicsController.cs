using Insights.Repository;
using System.Collections.Generic;
using System.Web.Http;
using Insights.ViewModels;
using Insights.Models;

namespace Insights.Controllers
{

    public class MechanicsController : ApiController
    {
        private MechanicsRepository _mechanicsRepository;
        public MechanicsController()
        {
            _mechanicsRepository = new MechanicsRepository();
        }

        [ActionName("GetMaintenanceCost")]
        [HttpGet]
        public TotalCostView GetMaintenanceCost([FromUri] TotalCostView tcv)
        {
            return _mechanicsRepository.GetMaintenanceCost(tcv);
        }

        [ActionName("InsertUpdateMaintenanceCost")]
        [HttpPost]
        public TotalCostView InsertUpdateMaintenanceCost(Mechanics mechanics)
        {
            return _mechanicsRepository.InsertUpdateMaintenanceCost(mechanics);
        }

        // Updating the Failure Charts 
        [ActionName("InsertUpdateMechanicsFailure")]
        [HttpPost]
        public IEnumerable<MechanicsFailureView> InsertUpdateMechanicsFailure(Mechanics mechanics)
        {
            return _mechanicsRepository.InsertUpdateMechanicsFailureByType(mechanics);
        }

        // Updating the Cost Charts  
        [ActionName("InsertUpdateMechanicsCost")]
        [HttpPost]
        public IEnumerable<MechanicsCostView> InsertUpdateMechanicsCost(Mechanics mechanics)
        {
            return _mechanicsRepository.InsertUpdateMechanicsCostByType(mechanics);
        }
    }
}