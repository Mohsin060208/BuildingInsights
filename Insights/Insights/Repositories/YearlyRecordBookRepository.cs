using System;
using Insights.Models;
using Insights.ViewModels;

namespace Repository
{
    public class YearlyRecordBookRepository
    {
        public TotalCostView GetTotalCost(TotalCostView tcv)
        {
            using (var context = new InsightsDBEntities())
            {
                var records = context.GetTotalCost(tcv.Year,tcv.BuildingId);
                foreach(var record in records)
                {
                    tcv.TotalCost = record.TotalCost;
                    tcv.BuildingId = record.BuildingId;
                    tcv.Year = record.Year;
                }
            }
            return tcv;
        }
        public TotalSavingView GetTotalSaving(TotalSavingView tsv)
        {
            using (var context = new InsightsDBEntities())
            {
               var records = context.GetTotalSaving(tsv.Year, tsv.BuildingId);
                foreach (var record in records)
                {
                    tsv.BuildingId = record.BuildingId;
                    tsv.Year = record.Year;
                    tsv.TotalSaving = record.TotalSaving;
                }
            }
            return tsv;
        }
        public TotalSavingView InsertUpdateTotalSaving(YearlyRecordBook yrb)
        {
            using (var context = new InsightsDBEntities())
            {
                yrb.IsActive = true;
                yrb.CreatedOn = DateTime.Now;
                yrb.UpdatedOn = DateTime.Now;
                int result = context.SaveTotalSaving(yrb.Year, yrb.TotalSaving, yrb.BuildingId, yrb.IsActive, yrb.CreatedOn, yrb.UpdatedOn);
            }            
            TotalSavingView tsv = new TotalSavingView();
            tsv.BuildingId = yrb.BuildingId;
            tsv.Year = yrb.Year;
            return GetTotalSaving(tsv);
        }
        public TotalCostView InsertUpdateTotalCost(YearlyRecordBook yrb)
        {
            using (var context = new InsightsDBEntities())
            {
                yrb.IsActive = true;
                yrb.CreatedOn = DateTime.Now;
                yrb.UpdatedOn = DateTime.Now;
                int result = context.SaveTotalCost(yrb.Year, yrb.TotalCost, yrb.BuildingId, yrb.IsActive, yrb.CreatedOn, yrb.UpdatedOn);
            }
            TotalCostView tcv = new TotalCostView();
            tcv.BuildingId = yrb.BuildingId;
            tcv.Year = yrb.Year;
            return GetTotalCost(tcv);
        }
    }
}