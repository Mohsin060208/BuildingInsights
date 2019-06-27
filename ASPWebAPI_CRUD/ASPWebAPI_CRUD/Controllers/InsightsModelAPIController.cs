using ASPWebAPI_CRUD.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using ActionNameAttribute = System.Web.Http.ActionNameAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace ASPWebAPI_CRUD.Controllers
{
    public class InsightsModelAPIController : ApiController
    {
        string connectionString = @"Data Source=DESKTOP-S6AR8GG\SQLEXPRESS;Initial Catalog=InsightsDB;Integrated Security=True;";

        [HttpGet]
        [ActionName("GetTotalCost")]
        public string GetTotalCost()
        {
            InsightsModel insight = new InsightsModel();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("stp_GetTotalCost", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    insight.TotalCost = (decimal)rdr["TotalCost"];
                }
                con.Close();
            }
            return JsonConvert.SerializeObject(insight, Formatting.Indented);
        }

        [HttpGet]
        [ActionName("GetTotalSaving")]
        public string GetTotalSaving()
        {
            InsightsModel insight = new InsightsModel();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("stp_GetTotalCost", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    insight.TotalSaving = (decimal)rdr["TotalSaving"];
                }
                con.Close();
            }
            return JsonConvert.SerializeObject(insight, Formatting.Indented);
        }

        public void UpdateTotalCost(InsightsModel insight)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("stp_UpdateTotalCost", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Year", insight.Year);
                cmd.Parameters.AddWithValue("@TotalCost", insight.TotalCost);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateTotalSaving(string year, decimal saving)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                InsightsModel insight = new InsightsModel();
                insight.Year = year;
                insight.TotalSaving = saving;
                SqlCommand cmd = new SqlCommand("stp_UpdateTotalSaving", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Year", insight.Year);
                cmd.Parameters.AddWithValue("@TotalCost", insight.TotalSaving);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}