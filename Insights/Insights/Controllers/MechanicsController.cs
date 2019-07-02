using Repository;
using System.Collections.Generic;
using System.Web.Http;
using Model;
using Insights.ViewModels;

namespace Insights.Controllers
{

    public class MechanicsController : ApiController
    {
        private MechanicsRepository _mechanicsRepository;
        public MechanicsController()
        {
            _mechanicsRepository = new MechanicsRepository();
        }

        [ActionName("Get")]
        [HttpGet]
        public List<MechanicsView> Get()
        {
            return _mechanicsRepository.GetAllMechanics();
        }

        // Updating the Failure Charts 
        [ActionName("InsertUpdateMechanicsFailure")]
        [HttpPost]
        public List<MechanicsFailureView> InsertUpdateMechanicsFailure(Mechanics mechanics)
        {
            return _mechanicsRepository.InsertUpdateMechanicsFailureByType(mechanics);
        }

        // Updating the Cost Charts  
        [ActionName("InsertUpdateMechanicsCost")]
        [HttpPost]
        public List<MechanicsCostView> InsertUpdateMechanicsCost(Mechanics mechanics)
        {
            return _mechanicsRepository.InsertUpdateMechanicsCostByType(mechanics);
        }
    }
}