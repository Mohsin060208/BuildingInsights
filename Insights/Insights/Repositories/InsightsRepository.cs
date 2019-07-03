using Insights.Models;
using Insights.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
                var results = context.GetAllMechanics();
                foreach (var result in results)
                {
                    MechanicsView mechanics = new MechanicsView();
                    mechanics.Type = result.Type;
                    mechanics.Year = result.Year.ToString();
                    mechanics.Failure = result.Failure;
                    mechanics.Cost = result.Cost;
                    mechanics.BuildingId = result.BuildingId;
                    mechanics.IsActive = result.IsActive;
                    mechanics.CreatedOn = result.CreatedOn;
                    mechanics.UpdatedOn = result.UpdatedOn;
                    chartData.Add(mechanics);
                }
                var records = context.GetRecordsByYear(yrb.Year, yrb.BuildingId);
                foreach (var record in records)
                {
                    yrb.TotalCost = record.TotalCost;
                    yrb.TotalSaving = record.TotalSaving;
                    yrb.BuildingId = record.BuildingId;
                    yrb.Year = record.Year;
                    yrb.IsActive = record.IsActive;
                    yrb.CreatedOn = yrb.CreatedOn;
                    yrb.UpdatedOn = yrb.UpdatedOn;
                    data.Add(yrb);
                }
            }
            chartData.GroupBy(x => x.Year)
           .Select(grp => grp.ToList())
           .ToList();
            data.Add(chartData);
            return data;
        }
    }
}