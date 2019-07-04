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
                    .ToList();
                foreach(var result in results)
                {
                    MechanicsView mechanics = new MechanicsView();
                    mechanics.BuildingId = result.BuildingId;
                    mechanics.Type = result.Type;
                    if(result.Cost == null)
                    {
                        mechanics.Cost = 0;
                    }
                    else { mechanics.Cost = result.Cost; }
                    if (result.Failure == null)
                    {
                        mechanics.Failure = 0;
                    }
                    else { mechanics.Failure = result.Failure; }
                    mechanics.IsActive = result.IsActive;
                    mechanics.CreatedOn = result.CreatedOn;
                    mechanics.UpdatedOn = result.UpdatedOn;
                    mechanics.Year = result.Year.ToString();
                    chartData.Add(mechanics);
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
                            if (yrb.TotalCost == null)
                            {
                                 yrb.TotalCost = 0;
                            }
                            if(yrb.TotalSaving == null)
                            {
                                 yrb.TotalSaving = 0;
                            }
                    }
                data.Add(yrb);
            }
            data.Add(chartData);
            return data;
        }
    }
}