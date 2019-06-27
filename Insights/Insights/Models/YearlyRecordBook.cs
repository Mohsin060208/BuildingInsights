using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class YearlyRecordBook
    {
        public int BuildingId { get; set; }
        public long TotalCost { get; set; }
        public long TotalSaving { get; set; }
        public short Year { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}