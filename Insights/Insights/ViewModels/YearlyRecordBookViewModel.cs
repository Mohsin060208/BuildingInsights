using System.Collections.Generic;

namespace Insights.ViewModels
{
    public class YearlyRecordBookViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public List<InsightsViewModel> Insights { get; set; }
    }
}