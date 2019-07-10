using System;
using System.Data;
using System.Collections.Generic;
using Insights.ViewModels;
using System.Linq;
using Insights.Models;

namespace Insights.Repository
{
    public class MechanicsRepository
    {
        public List<MechanicsFailureView> GetMechanicsFailureByType(Mechanics mechanics)
        {
            List<MechanicsFailureView> chartData = new List<MechanicsFailureView>();
            using (var context = new InsightsDBEntities())
            {
                var results = context.Mechanics
                    .Where(x => x.Type == mechanics.Type
                    && x.BuildingId == mechanics.BuildingId)
                    .OrderBy(x => x.Year)
                    .Select(x => new MechanicsFailureView {
                        Year = x.Year.ToString(),
                        Failure = x.Failure == null ? 0 : x.Failure,
                        Type = x.Type
                    })
                    .ToList();
                foreach (var result in results)
                {
                    chartData.Add(result);
                }
            }          
            return chartData;
        }
        public List<MechanicsCostView> GetMechanicsCostByType(Mechanics mechanics)
        {
            List<MechanicsCostView> chartData = new List<MechanicsCostView>();
            using (var context = new InsightsDBEntities())
            {
                var results = context.Mechanics
                    .Where(x => x.Type == mechanics.Type && x.BuildingId == mechanics.BuildingId)
                    .OrderBy(x => x.Year)
                    .Select(x => new MechanicsCostView
                    {
                        Year = x.Year.ToString(),
                        Cost = x.Cost == null ? 0 : x.Cost,
                        Type = x.Type
                    })
                    .ToList();
                foreach (var result in results)
                {
                    chartData.Add(result);
                }
            }
            return chartData;
        }
        public List<MechanicsFailureView> InsertUpdateMechanicsFailureByType(Mechanics mechanics)
        {
            using (var context = new InsightsDBEntities())
            {
                var result = context.Mechanics
                    .SingleOrDefault(x => x.Type == mechanics.Type
                    && x.Year == mechanics.Year
                    && x.BuildingId == mechanics.BuildingId);
                if (result == null)
                {
                    mechanics.IsActive = true;
                    mechanics.CreatedOn = DateTime.Now;
                    mechanics.UpdatedOn = DateTime.Now;
                    context.Mechanics.Add(mechanics);
                    context.SaveChanges();
                }
                else
                {
                    result.Failure = mechanics.Failure;
                    result.UpdatedOn = DateTime.Now;
                    context.SaveChanges();
                }
            }
            return GetMechanicsFailureByType(mechanics);
        }
        public List<MechanicsCostView> InsertUpdateMechanicsCostByType(Mechanics mechanics)
        {
            using (var context = new InsightsDBEntities())
            {

                var result = context.Mechanics
                    .SingleOrDefault(x => x.Type == mechanics.Type
                    && x.Year == mechanics.Year
                    && x.BuildingId == mechanics.BuildingId);
                if(result == null) { 
                    mechanics.IsActive = true;
                    mechanics.CreatedOn = DateTime.Now;
                    mechanics.UpdatedOn = DateTime.Now;
                    context.Mechanics.Add(mechanics);
                    context.SaveChanges();
                }
                else
                {
                    result.Cost = mechanics.Cost;
                    result.UpdatedOn = DateTime.Now;
                    context.SaveChanges();
                }
            }
            return GetMechanicsCostByType(mechanics);
        }
    }
}
