using System;
using System.Collections.Generic;
using System.Text;
namespace Model
{
    public class Mechanics
    {
        public int BuildingId { get; set; }
        public string Type { get; set; }
        public long Cost { get; set; }
        public long Failure { get; set; }
        public short Year { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}