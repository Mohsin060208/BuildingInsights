using System;
using Insights.Models;
using Insights.ViewModels;

namespace Repository
{
    public class YearlyRecordBookRepository
    {
      
        //string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public YearlyRecordBook GetAllRecords(YearlyRecordBook yrb)
        {
            using(var context = new InsightsDBEntities())
            {
             var records = context.GetRecordsByYear(yrb.Year,yrb.BuildingId);
                foreach (var record in records)
                {
                    yrb.TotalCost = record.TotalCost;
                    yrb.TotalSaving = record.TotalSaving;
                    yrb.BuildingId = record.BuildingId;
                    yrb.Year = record.Year;
                    yrb.IsActive = record.IsActive;
                    yrb.CreatedOn = yrb.CreatedOn;
                    yrb.UpdatedOn = yrb.UpdatedOn;
                }
            }
            return yrb;
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_GetRecordsByYear", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@Year", yrb.Year);
            //    cmd.Parameters.AddWithValue("@BuildingId", yrb.BuildingId);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();

            //    while (rdr.Read())
            //    {
            //        yrb.TotalCost = Convert.ToInt64(rdr["TotalCost"]);
            //        yrb.TotalSaving = Convert.ToInt64(rdr["TotalSaving"]);
            //        yrb.BuildingId = Convert.ToInt32(rdr["BuildingId"]);
            //        yrb.Year = Convert.ToInt16(rdr["Year"]);
            //        yrb.IsActive = (bool)rdr["IsActive"];
            //        yrb.CreatedOn = (DateTime)rdr["CreatedOn"];
            //        yrb.UpdatedOn = (DateTime)rdr["UpdatedOn"];
            //    }
            //    con.Close();
            //}
            //return yrb;
        }
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
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_GetTotalCost", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@Year", tcv.Year);
            //    cmd.Parameters.AddWithValue("@BuildingId", tcv.BuildingId);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();

            //    while (rdr.Read())
            //    {
            //        tcv.TotalCost = Convert.ToInt64(rdr["TotalCost"]);
            //        tcv.BuildingId = Convert.ToInt32(rdr["BuildingId"]);
            //        tcv.Year = Convert.ToInt16(rdr["Year"]);
            //    }
            //    con.Close();
            //}
            //return tcv;
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
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_GetTotalSaving", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@Year", tsv.Year);
            //    cmd.Parameters.AddWithValue("@BuildingId", tsv.BuildingId);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        tsv.TotalSaving = Convert.ToInt64(rdr["TotalSaving"]);
            //        tsv.BuildingId = Convert.ToInt32(rdr["BuildingId"]);
            //        tsv.Year = Convert.ToInt16(rdr["Year"]);
            //    }
            //}
            //return tsv;
        }
        public TotalSavingView InsertUpdateTotalSaving(YearlyRecordBook yrb)
        {
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_SaveTotalSaving", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@BuildingId", yrb.BuildingId);
            //    cmd.Parameters.AddWithValue("@Year", yrb.Year);
            //    cmd.Parameters.AddWithValue("@TotalSaving", yrb.TotalSaving);
            //    cmd.Parameters.AddWithValue("@IsActive", true);
            //    cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            //    cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
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
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_SaveTotalCost", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@BuildingId", yrb.BuildingId);
            //    cmd.Parameters.AddWithValue("@Year", yrb.Year);
            //    cmd.Parameters.AddWithValue("@TotalCost", yrb.TotalCost);
            //    cmd.Parameters.AddWithValue("@IsActive", true);
            //    cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            //    cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
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