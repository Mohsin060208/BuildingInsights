namespace Insights.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Mechanics
    {
        public int Id { get; set; }

        public int BuildingId { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }

        public long? Cost { get; set; }

        public long? Failure { get; set; }

        public short Year { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
