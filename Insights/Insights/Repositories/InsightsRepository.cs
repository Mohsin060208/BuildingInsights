using Insights.Models;
using Insights.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Insights.Repositories
{
    public class InsightsRepository
    {
        public List<MechanicsView> GetAll(Mechanics mechanics)
        {
            List<MechanicsView> data = new List<MechanicsView>();
            using (var context = new InsightsDBEntities())
            {
                 data = context.Mechanics
                    .Where(x => x.BuildingId == mechanics.BuildingId)
                    .OrderBy(x => x.Year)
                    .Select(x => new MechanicsView {
                        Failure = (x.Failure == null ? 0 : x.Failure),
                        Cost = (x.Cost == null ? 0 : x.Cost),
                        Year = x.Year.ToString(),
                        Type = x.Type,
                    })
                    .ToList();                
            }
            return data;
        }
    }
}