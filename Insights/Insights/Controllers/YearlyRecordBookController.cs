using Insights.ViewModels;
using Model;
using Newtonsoft.Json;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        [ActionName("Get")]
        [HttpGet]
        public YearlyRecordBook Get([FromUri] YearlyRecordBook yrb)
        {
            return _yrb.GetAllRecords(yrb);
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