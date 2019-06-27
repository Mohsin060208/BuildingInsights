using ASPWebAPI_CRUD.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;

namespace ASPWebAPI_CRUD.Controllers
{
    public class UserAPIController : ApiController
    {
        string connectionString = @"Data Source=DESKTOP-S6AR8GG\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True;";

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            List<User> lstUser = new List<User>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    User user = new User();

                    user.Id = Convert.ToInt32(rdr["Id"]);
                    user.FirstName = rdr["FirstName"].ToString();
                    user.LastName = rdr["LastName"].ToString();
                    user.Gender = rdr["Gender"].ToString();
                    user.City = rdr["City"].ToString();
                    user.isActive = (bool)(rdr["isActive"]);
                    user.CreatedOn = (DateTime)rdr["CreatedOn"];
                    user.UpdatedOn = (DateTime)rdr["UpdatedOn"];
                    user.Email = rdr["Email"].ToString();
                    user.Phone = rdr["Phone"].ToString();
                    lstUser.Add(user);
                }
                con.Close();
            }
            return lstUser;
        }
        [HttpPost]
        public void AddUser(User user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@City", user.City);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@isActive", true);
                cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now.ToShortDateString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        [HttpPut]
        public void UpdateUser(User user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@Gender", user.Gender);
                cmd.Parameters.AddWithValue("@City", user.City);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@isActive", user.isActive);
                cmd.Parameters.AddWithValue("@CreatedOn", user.CreatedOn);
                cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now.ToShortDateString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        [Route("/api/UserAPI/GetUserById/")]
        [HttpGet]
        [ActionName("GetUserById")]
        public string GetUserData(int id)
        {
            User user = new User();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetUserById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user.Id = Convert.ToInt32(rdr["Id"]);
                    user.FirstName = rdr["FirstName"].ToString();
                    user.LastName = rdr["LastName"].ToString();
                    user.Gender = rdr["Gender"].ToString();
                    user.Phone = rdr["Phone"].ToString();
                    user.City = rdr["City"].ToString();
                    user.isActive = (bool)(rdr["isActive"]);
                    user.CreatedOn = (DateTime)rdr["CreatedOn"];
                    user.UpdatedOn = (DateTime)rdr["UpdatedOn"];
                    user.Email = rdr["Email"].ToString();
                   
                }
            }
            return JsonConvert.SerializeObject(user, Formatting.Indented);
        }
        [HttpDelete]
        [ActionName("DeleteUser")]
        public void DeleteUser(int id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
