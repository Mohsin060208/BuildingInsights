using System;
using System.Data;
using System.Collections.Generic;
using Insights.ViewModels;
using System.Linq;
using Insights.Models;

namespace Repository
{
    public class MechanicsRepository
    {
        public List<MechanicsFailureView> GetMechanicsFailureByType(Mechanics mechanics)
        {
            List<MechanicsFailureView> chartData = new List<MechanicsFailureView>();
            using (var context = new InsightsDBEntities())
            {
                var results = context.GetMechanicsFailureByType(mechanics.Type);
                foreach (var result in results)
                {
                    MechanicsFailureView mfv = new MechanicsFailureView();
                    mfv.Type = result.Type;
                    mfv.Year = result.Year.ToString();
                    mfv.Failure = result.Failure;
                    chartData.Add(mfv);
                }
            }
            chartData.GroupBy(x => x.Year)
           .Select(grp => grp.ToList())
           .ToList();
            return chartData;            
        }
        public List<MechanicsCostView> GetMechanicsCostByType(Mechanics mechanics)
        {
            List<MechanicsCostView> chartData = new List<MechanicsCostView>();
            using (var context = new InsightsDBEntities())
            {
                var results = context.GetMechanicsCostByType(mechanics.Type);
                foreach (var result in results)
                {
                    MechanicsCostView mcv = new MechanicsCostView();
                    mcv.Type = result.Type;
                    mcv.Year = result.Year.ToString();
                    mcv.Cost = result.Cost;
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
            using(var context = new InsightsDBEntities())
            {
                mechanics.IsActive = true;
                mechanics.CreatedOn = DateTime.Now;
                mechanics.UpdatedOn = DateTime.Now;
                context.CreateUpdateMechanicsFailureByType(mechanics.Year, mechanics.Type, mechanics.Failure, mechanics.BuildingId, mechanics.IsActive, mechanics.CreatedOn, mechanics.UpdatedOn);
            }
            return GetMechanicsFailureByType(mechanics);
        }
        public List<MechanicsCostView> InsertUpdateMechanicsCostByType(Mechanics mechanics)
        {
            using (var context = new InsightsDBEntities())
            {
                mechanics.IsActive = true;
                mechanics.CreatedOn = DateTime.Now;
                mechanics.UpdatedOn = DateTime.Now;
                context.CreateUpdateMechanicsCostByType(mechanics.Year, mechanics.Type, mechanics.Cost, mechanics.BuildingId, mechanics.IsActive, mechanics.CreatedOn, mechanics.UpdatedOn);
            }
            return GetMechanicsCostByType(mechanics);
        }
  }
}
