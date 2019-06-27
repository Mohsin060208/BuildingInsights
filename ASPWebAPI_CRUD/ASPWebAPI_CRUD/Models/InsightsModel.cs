using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPWebAPI_CRUD.Models
{
    public class InsightsModel
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalSaving { get; set; }
    }
}