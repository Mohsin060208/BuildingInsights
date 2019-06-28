using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Repository
{
    public class YearlyRecordBookRepository
    {
        string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public YearlyRecordBook GetTotalCost(YearlyRecordBook yrb)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetTotalCost", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", yrb.Year);
                cmd.Parameters.AddWithValue("@BuildingId", yrb.BuildingId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                        yrb.TotalCost = Convert.ToInt64(rdr["TotalCost"]);
                }
                con.Close();
            }
            return yrb;
        }
        public YearlyRecordBook GetTotalSaving(YearlyRecordBook yrb)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetTotalSaving", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Year", yrb.Year);
                cmd.Parameters.AddWithValue("@BuildingId", yrb.BuildingId);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    yrb.TotalSaving = Convert.ToInt64(rdr["TotalSaving"]);
                }
            }
            return yrb;
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