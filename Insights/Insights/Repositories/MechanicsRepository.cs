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
                    .Where(x => x.Type == mechanics.Type && x.BuildingId == mechanics.BuildingId)
                    .OrderBy(x => x.Year);
                foreach (var result in results)
                {
                    MechanicsFailureView mfv = new MechanicsFailureView();
                    mfv.Type = result.Type;
                    mfv.Year = result.Year.ToString();
                    if (result.Failure == null)
                    {
                        mfv.Failure = 0;
                    }
                    else { mfv.Failure = result.Failure; }
                    mfv.Failure = result.Failure;
                    chartData.Add(mfv);
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
                    .OrderBy(x => x.Year);
                foreach (var result in results)
                {
                    MechanicsCostView mcv = new MechanicsCostView();
                    
                    mcv.Type = result.Type;
                    mcv.Year = result.Year.ToString();
                    if (result.Cost == null)
                    {
                        mcv.Cost = 0;
                    }
                    else { mcv.Cost = result.Cost; }
                    chartData.Add(mcv);
                }
            }
            chartData.GroupBy(x => x.Year)
           .Select(grp => grp.ToList())
           .ToList();
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
