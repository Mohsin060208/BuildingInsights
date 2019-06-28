using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insights.ViewModels
{
    public class TotalCostView
    {
        public short Year { get; set; }
        public int BuildingId { get; set; }
        public long TotalCost { get; set; }
    }
}