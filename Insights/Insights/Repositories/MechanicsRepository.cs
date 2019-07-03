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
        //string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        public List<MechanicsView> GetAllMechanics()
        {
            List<MechanicsView> chartData = new List<MechanicsView>();
            using(var context = new InsightsDBEntities())
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
            }
            chartData.GroupBy(x => x.Year)
           .Select(grp => grp.ToList())
           .ToList();
            return chartData;

            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_GetAllMechanics", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        MechanicsView mechanics = new MechanicsView();
            //        mechanics.Type = rdr["Type"].ToString();
            //        mechanics.Year = (rdr["Year"]).ToString();
            //        mechanics.Cost = Convert.ToInt64(rdr["Cost"]);
            //        mechanics.Failure = Convert.ToInt64(rdr["Failure"]);
            //        mechanics.BuildingId = Convert.ToInt32(rdr["BuildingId"]);
            //        mechanics.IsActive = (bool)rdr["IsActive"];
            //        mechanics.CreatedOn = (DateTime)rdr["CreatedOn"];
            //        mechanics.UpdatedOn = (DateTime)rdr["UpdatedOn"];
            //        chartData.Add(mechanics);
            //    }
            //    con.Close();
            //}
            // chartData.GroupBy(x => x.Year)
            //.Select(grp => grp.ToList())
            //.ToList();
            // return chartData;
        }
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
            // using (SqlConnection con = new SqlConnection(conStr))
            // {
            //     SqlCommand cmd = new SqlCommand("stp_GetMechanicsFailureByType", con);
            //     cmd.CommandType = CommandType.StoredProcedure;
            //     cmd.Parameters.AddWithValue("@Type", mechanics.Type);
            //     con.Open();
            //     SqlDataReader rdr = cmd.ExecuteReader();

            //     while (rdr.Read())
            //     {
            //         MechanicsFailureView mfv = new MechanicsFailureView();
            //         mfv.Type = rdr["Type"].ToString();
            //         mfv.Year = (rdr["Year"]).ToString();
            //         mfv.Failure = Convert.ToInt64(rdr["Failure"]);
            //         chartData.Add(mfv);
            //     }
            //     con.Close();
            // }
            // chartData.GroupBy(x => x.Year)
            //.Select(grp => grp.ToList())
            //.ToList();
            // return chartData;
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
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_GetMechanicsCostByType", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@Type", mechanics.Type);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        MechanicsCostView mcv = new MechanicsCostView();
            //        mcv.Type = rdr["Type"].ToString();
            //        mcv.Year = (rdr["Year"]).ToString();
            //        mcv.Cost = Convert.ToInt64(rdr["Cost"]);
            //        chartData.Add(mcv);
            //    }
            //    con.Close();
            //}
            // chartData.GroupBy(x => x.Year)
            //.Select(grp => grp.ToList())
            //.ToList();
            // return chartData;
        }
        public List<MechanicsFailureView> InsertUpdateMechanicsFailureByType(Mechanics mechanics)
        {
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_CreateUpdateMechanicsFailureByType", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@BuildingId", mechanics.BuildingId);
            //    cmd.Parameters.AddWithValue("@Type", mechanics.Type);
            //    cmd.Parameters.AddWithValue("@Failure", mechanics.Failure);
            //    cmd.Parameters.AddWithValue("@Year", mechanics.Year);
            //    cmd.Parameters.AddWithValue("@IsActive", true);
            //    cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            //    cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}            
            //return GetMechanicsFailureByType(mechanics);
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
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    SqlCommand cmd = new SqlCommand("stp_CreateUpdateMechanicsCostByType", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@BuildingId", mechanics.BuildingId);
            //    cmd.Parameters.AddWithValue("@Type", mechanics.Type);
            //    cmd.Parameters.AddWithValue("@Cost", mechanics.Cost);
            //    cmd.Parameters.AddWithValue("@Year", mechanics.Year);
            //    cmd.Parameters.AddWithValue("@IsActive", true);
            //    cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            //    cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //return GetMechanicsCostByType(mechanics);
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
