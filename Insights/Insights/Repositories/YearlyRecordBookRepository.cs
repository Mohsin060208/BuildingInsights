using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Insights.ViewModels;
using Model;

namespace Repository
{
    public class YearlyRecordBookRepository
    {
      
        string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public TotalCostView GetTotalCost(TotalCostView tcv)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetTotalCost", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", tcv.Year);
                cmd.Parameters.AddWithValue("@BuildingId", tcv.BuildingId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    tcv.TotalCost = Convert.ToInt64(rdr["TotalCost"]);
                    tcv.BuildingId = Convert.ToInt32(rdr["BuildingId"]);
                    tcv.Year = Convert.ToInt16(rdr["Year"]);
                }
                con.Close();
            }
            return tcv;
        }
        public TotalSavingView GetTotalSaving(TotalSavingView tsv)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetTotalSaving", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", tsv.Year);
                cmd.Parameters.AddWithValue("@BuildingId", tsv.BuildingId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                   tsv.TotalSaving = Convert.ToInt64(rdr["TotalSaving"]);
                   tsv.BuildingId = Convert.ToInt32(rdr["BuildingId"]);
                   tsv.Year = Convert.ToInt16(rdr["Year"]);
                }
            }
            return tsv;
        }
        public void InsertUpdateTotalSaving(YearlyRecordBook yrb)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_SaveTotalSaving", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BuildingId", yrb.BuildingId);
                cmd.Parameters.AddWithValue("@Year", yrb.Year);
                cmd.Parameters.AddWithValue("@TotalSaving", yrb.TotalSaving);
                cmd.Parameters.AddWithValue("@IsActive", true);
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void InsertUpdateTotalCost(YearlyRecordBook yrb)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_SaveTotalCost", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BuildingId", yrb.BuildingId);
                cmd.Parameters.AddWithValue("@Year", yrb.Year);
                cmd.Parameters.AddWithValue("@TotalCost", yrb.TotalCost);
                cmd.Parameters.AddWithValue("@IsActive", true);
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}