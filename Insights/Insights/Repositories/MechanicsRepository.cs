using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Model;
using System.Configuration;
using Insights.ViewModels;
using System.Linq;

namespace Repository
{
    public class MechanicsRepository
    {
        string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public List<MechanicsView> GetAllMechanics()
        {
            List<MechanicsView> chartData = new List<MechanicsView>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetAllMechanics", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MechanicsView mechanics = new MechanicsView();
                    mechanics.Type = rdr["Type"].ToString();
                    mechanics.Year = (rdr["Year"]).ToString();
                    mechanics.Cost = Convert.ToInt64(rdr["Cost"]);
                    mechanics.Failure = Convert.ToInt64(rdr["Failure"]);
                    mechanics.BuildingId = Convert.ToInt32(rdr["BuildingId"]);
                    mechanics.IsActive = (bool)rdr["IsActive"];
                    mechanics.CreatedOn = (DateTime)rdr["CreatedOn"];
                    mechanics.UpdatedOn = (DateTime)rdr["UpdatedOn"];
                    chartData.Add(mechanics);
                }
                con.Close();
            }
            chartData.GroupBy(x => x.Year)
           .Select(grp => grp.ToList())
           .ToList();
            return chartData;
        }
        public List<MechanicsFailureView> GetMechanicsFailureByType(Mechanics mechanics)
        {
            List<MechanicsFailureView> chartData = new List<MechanicsFailureView>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetMechanicsFailureByType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", mechanics.Type);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MechanicsFailureView mfv = new MechanicsFailureView();
                    mfv.Type = rdr["Type"].ToString();
                    mfv.Year = (rdr["Year"]).ToString();
                    mfv.Failure = Convert.ToInt64(rdr["Failure"]);
                    chartData.Add(mfv);
                }
                con.Close();
            }
            chartData.GroupBy(x => x.Year)
           .Select(grp => grp.ToList())
           .ToList();
            return chartData;
        }
        public List<MechanicsCostView> GetMechanicsCostByType(Mechanics mechanics)
        {
            List<MechanicsCostView> chartData = new List<MechanicsCostView>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_GetMechanicsCostByType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", mechanics.Type);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MechanicsCostView mcv = new MechanicsCostView();
                    mcv.Type = rdr["Type"].ToString();
                    mcv.Year = (rdr["Year"]).ToString();
                    mcv.Cost = Convert.ToInt64(rdr["Cost"]);
                    chartData.Add(mcv);
                }
                con.Close();
            }
            chartData.GroupBy(x => x.Year)
           .Select(grp => grp.ToList())
           .ToList();
            return chartData;
        }
        public List<MechanicsFailureView> InsertUpdateMechanicsFailureByType(Mechanics mechanics)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_CreateUpdateMechanicsFailureByType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BuildingId", mechanics.BuildingId);
                cmd.Parameters.AddWithValue("@Type", mechanics.Type);
                cmd.Parameters.AddWithValue("@Failure", mechanics.Failure);
                cmd.Parameters.AddWithValue("@Year", mechanics.Year);
                cmd.Parameters.AddWithValue("@IsActive", true);
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }            
            return GetMechanicsFailureByType(mechanics);
        }
        public List<MechanicsCostView> InsertUpdateMechanicsCostByType(Mechanics mechanics)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("stp_CreateUpdateMechanicsCostByType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BuildingId", mechanics.BuildingId);
                cmd.Parameters.AddWithValue("@Type", mechanics.Type);
                cmd.Parameters.AddWithValue("@Cost", mechanics.Cost);
                cmd.Parameters.AddWithValue("@Year", mechanics.Year);
                cmd.Parameters.AddWithValue("@IsActive", true);
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return GetMechanicsCostByType(mechanics);
        }
  }
}
