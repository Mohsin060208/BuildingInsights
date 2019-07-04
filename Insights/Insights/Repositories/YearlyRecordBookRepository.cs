using System;
using System.Linq;
using Insights.Models;
using Insights.ViewModels;

namespace Inights.Repository
{
    public class YearlyRecordBookRepository
    {
        public TotalCostView GetTotalCost(TotalCostView tcv)
        {
            using (var context = new InsightsDBEntities())
            {
                var record = context.YearlyRecordBooks
                    .SingleOrDefault(x => x.BuildingId == tcv.BuildingId
                    && x.Year == tcv.Year);
                    if (record == null || record.TotalCost == null)
                    {
                        tcv.TotalCost = 0;
                    }
                    else
                    {
                        tcv.TotalCost = record.TotalCost;
                    }
            }
            return tcv;
        }
        public TotalSavingView GetTotalSaving(TotalSavingView tsv)
        {
            using (var context = new InsightsDBEntities())
            {
                var record = context.YearlyRecordBooks
                     .SingleOrDefault(x => x.BuildingId == tsv.BuildingId
                     && x.Year == tsv.Year);
                if (record == null || record.TotalSaving == null)
                {
                    tsv.TotalSaving = 0;
                }
                else
                {
                    tsv.TotalSaving = record.TotalSaving;
                }
            }
            return tsv;
        }
        public TotalSavingView InsertUpdateTotalSaving(YearlyRecordBook yrb)
        {
            using (var context = new InsightsDBEntities())
            {
                    var record = context.YearlyRecordBooks
                     .SingleOrDefault(x => x.Year == yrb.Year
                     && x.BuildingId == yrb.BuildingId);
                if(record == null)
                {
                    yrb.IsActive = true;
                    yrb.CreatedOn = DateTime.Now;
                    yrb.UpdatedOn = DateTime.Now;
                    context.YearlyRecordBooks.Add(yrb);
                    context.SaveChanges();
                }
                else
                {
                    record.UpdatedOn = DateTime.Now;
                    record.TotalSaving = yrb.TotalSaving;
                    context.SaveChanges();
                }
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
                var record = context.YearlyRecordBooks
                      .SingleOrDefault(x => x.Year == yrb.Year
                      && x.BuildingId == yrb.BuildingId);
                if (record == null)
                {
                    yrb.IsActive = true;
                    yrb.CreatedOn = DateTime.Now;
                    yrb.UpdatedOn = DateTime.Now;
                    context.YearlyRecordBooks.Add(yrb);
                    context.SaveChanges();
                }
                else
                {
                    record.UpdatedOn = DateTime.Now;
                    record.TotalCost = yrb.TotalCost;
                    context.SaveChanges();
                }
            }
            TotalCostView tcv = new TotalCostView();
            tcv.BuildingId = yrb.BuildingId;
            tcv.Year = yrb.Year;
            return GetTotalCost(tcv);
        }
    }
}