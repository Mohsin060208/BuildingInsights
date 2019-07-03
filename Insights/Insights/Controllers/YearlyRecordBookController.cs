using Insights.Models;
using Insights.ViewModels;
using Repository;
using System.Web.Http;

namespace Insights.Controllers
{
    public class YearlyRecordBookController : ApiController
    {
        YearlyRecordBookRepository _yrb;
        public YearlyRecordBookController()
        {
            _yrb = new YearlyRecordBookRepository();
        }

        [ActionName("GetTotalCost")]
        [HttpGet]
        public TotalCostView GetTotalCost([FromUri] TotalCostView tcv)
        {
            return _yrb.GetTotalCost(tcv);
        }

        [ActionName("GetTotalSaving")]
        [HttpGet]
        public TotalSavingView GetTotalSaving([FromUri] TotalSavingView tsv)
        {
            return _yrb.GetTotalSaving(tsv);
        }

        [ActionName("InsertUpdateTotalCost")]
        [HttpPost]
        public TotalCostView SaveTotalCost(YearlyRecordBook yrb)
        {
            return _yrb.InsertUpdateTotalCost(yrb);
        }

        [ActionName("InsertUpdateTotalSaving")]
        [HttpPost]
        public TotalSavingView SaveTotalSaving(YearlyRecordBook yrb)
        {
            return _yrb.InsertUpdateTotalSaving(yrb);
        }
    }
}