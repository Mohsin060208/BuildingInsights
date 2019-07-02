using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insights.ViewModels
{
    public class MechanicsView
    {
        public int BuildingId { get; set; }
        public string Type { get; set; }
        public long Cost { get; set; }
        public long Failure { get; set; }
        public string Year { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}