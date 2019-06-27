using System.Collections.Generic;

namespace Insights.ViewModels
{
    public class MechanicsViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public List<InsightsViewModel> Insights { get; set; }
    }
}