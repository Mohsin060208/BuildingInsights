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
        [ActionName("GetTotalCost")]
        [HttpGet]
        public YearlyRecordBook GetTotalCost(YearlyRecordBook yrb)
        {
            return _yrb.GetTotalCost(yrb);
        }

        [ActionName("GetTotalSaving")]
        [HttpGet]
        public YearlyRecordBook GetTotalSaving(YearlyRecordBook yrb)
        {
            return _yrb.GetTotalSaving(yrb);
        }

        [ActionName("InsertUpdateTotalCost")]
        [HttpPost]
        public void SaveTotalCost(YearlyRecordBook yrb)
        {
            _yrb.InsertUpdateTotalCost(yrb);
        }

        [ActionName("InsertUpdateTotalSaving")]
        [HttpPost]
        public void SaveTotalSaving(YearlyRecordBook yrb)
        {
            _yrb.InsertUpdateTotalSaving(yrb);
        }
    }
}