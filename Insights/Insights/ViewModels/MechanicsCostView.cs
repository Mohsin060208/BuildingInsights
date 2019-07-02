using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insights.ViewModels
{
    public class MechanicsCostView
    {
        public string Type { get; set; }
        public long? Cost { get; set; }
        public string Year { get; set; }
    }
}