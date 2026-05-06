using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace PracticalTwelve.Models
{
    public class EmployeeTwoRepository
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        public void Insert(EmployeeTwo emp)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO EmployeeTwo (FirstName, MiddleName, LastName, DOB, MobileNumber, Address, Salary) " +
                    "VALUES (@FirstName, @MiddleName, @LastName, @DOB, @MobileNumber, @Address, @Salary)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", (object)emp.MiddleName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@DOB", emp.DOB);
                cmd.Parameters.AddWithValue("@MobileNumber", emp.MobileNumber);
                cmd.Parameters.AddWithValue("@Address", (object)emp.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public int GetTotalSalary()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Salary) FROM EmployeeTwo";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                object result = cmd.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToInt32(result);
            }
        }

        public int CountNullMiddleName()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM EmployeeTwo WHERE MiddleName Is Null";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public List<EmployeeTwo> GetBefore2000()
        {
            List<EmployeeTwo> list = new List<EmployeeTwo>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM EmployeeTwo where DOB < '2000-01-01'";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        EmployeeTwo emp = new EmployeeTwo
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString(),
                            DOB = Convert.ToDateTime(reader["DOB"]),
                            MobileNumber = (reader["MobileNumber"]).ToString(),
                            Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString(),
                            Salary = Convert.ToDecimal(reader["Salary"])
                        };
                        list.Add(emp);
                    }
                }
            }
            return list;
        }
        

        public List<EmployeeTwo> GetAll()
        {
            List<EmployeeTwo> list = new List<EmployeeTwo>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM EmployeeTwo";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        EmployeeTwo emp = new EmployeeTwo
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString(),
                            DOB = Convert.ToDateTime(reader["DOB"]),
                            MobileNumber = (reader["MobileNumber"]).ToString(),
                            Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString(),
                            Salary = Convert.ToDecimal(reader["Salary"])
                        };
                        list.Add(emp);
                    }
                }
            }
            return list;
        }

    }
}