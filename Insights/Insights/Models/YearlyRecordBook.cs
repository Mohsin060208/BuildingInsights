using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Insights.Models
{

    [Table("YearlyRecordBook")]
    public partial class YearlyRecordBook
    {
        public int Id { get; set; }

        public int BuildingId { get; set; }

        public long? TotalCost { get; set; }

        public long? TotalSaving { get; set; }

        public short Year { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
