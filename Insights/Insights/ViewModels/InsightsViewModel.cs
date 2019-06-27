using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insights.ViewModels
{
    public class InsightsViewModel
    {
        public DateTime Year { get; set; }
        public System.Int64 Cost { get; set; }
        public System.Int64 Failure { get; set; }

    }
}