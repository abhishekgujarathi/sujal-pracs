using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace PracticalTwelve.Models
{
    public class EmployeeRepository
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        public void Insert(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employee (FirstName, MiddleName, LastName, DOB, MobileNumber, Address) " +
                    "VALUES (@FirstName, @MiddleName, @LastName, @DOB, @MobileNumber, @Address)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", (object)emp.MiddleName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@DOB", emp.DOB);
                cmd.Parameters.AddWithValue("@MobileNumber", emp.MobileNumber);
                cmd.Parameters.AddWithValue("@Address", (object)emp.Address ?? DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateFirstName()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee SET FirstName=@FirstName WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", "SQLPerson");
                cmd.Parameters.AddWithValue("@Id", 1);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMiddleName()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee SET MiddleName='I'";
              
                SqlCommand cmd = new SqlCommand(query, con);
                
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLessThan2()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Employee WHERE Id < 2";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteAll()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Employee";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();

            using(SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employee";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Employee emp = new Employee
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString(),
                            DOB = Convert.ToDateTime(reader["DOB"]),
                            MobileNumber = (reader["MobileNumber"]).ToString(),
                            Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString()
                        };
                        list.Add(emp);
                    }
                }
            }
            return list;
        }

    }
}