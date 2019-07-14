namespace Insights.ViewModels
{
    public class TotalCostView
    {
        public short Year { get; set; }
        public int BuildingId { get; set; }
        public long? Cost { get; set; }
        public string Type { get; set; }
    }
}