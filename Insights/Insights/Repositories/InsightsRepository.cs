using Insights.Models;
using Insights.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Insights.Repositories
{
    public class InsightsRepository
    {
        public List<object> GetAll(YearlyRecordBook yrb)
        {
            List<object> data = new List<object>();
            List<MechanicsView> chartData = new List<MechanicsView>();
            using (var context = new InsightsDBEntities())
            {
                var results = context.Mechanics
                    .Where(x => x.BuildingId == yrb.BuildingId)
                    .OrderBy(x => x.Year)
                    .Select(x => new MechanicsView {
                        Failure = (x.Failure == null ? 0 : x.Failure),
                        Cost = (x.Cost == null ? 0 : x.Cost),
                        Year = x.Year.ToString(),
                        Type = x.Type
                    })
                    .ToList();
                foreach (var result in results)
                {
                    chartData.Add(result);
                }
                var record = context.YearlyRecordBooks
                    .SingleOrDefault(x => x.BuildingId == yrb.BuildingId
                    && x.Year == yrb.Year);
                    if (record == null)
                    {
                        yrb.TotalCost = 0;
                        yrb.TotalSaving = 0;
                    }
                else
                {
                    yrb = record;
                    yrb.TotalCost = record.TotalCost == null ? 0 : record.TotalCost;
                    yrb.TotalSaving = record.TotalSaving == null ? 0 : record.TotalSaving;
                }
                data.Add(yrb);
            }
            data.Add(chartData);
            return data;
        }
    }
}