using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace PracticalTwelve.Models
{
    public class EmployeeThreeRepository
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        public List<DesignationCountViewModel> CountByDesignation()
        {
            var list = new List<DesignationCountViewModel>();
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT d.Designation AS Designation, COUNT(e.Id) AS TotalEmployees  FROM Designation d  LEFT JOIN EmployeeThree e ON e.DesignationId = d.Id GROUP BY d.Designation";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DesignationCountViewModel desg = new DesignationCountViewModel();

                        desg.DesignationName = reader["Designation"].ToString();
                        desg.TotalEmployees = reader["TotalEmployees"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["TotalEmployees"]);
                        list.Add(desg);
                    }
                }
            }
            return list;
        }
        public List<EmployeeWithDesignationViewModel> DisplayByDesignation()
        {
            var list = new List<EmployeeWithDesignationViewModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT e.FirstName AS FirstName, e.MiddleName AS MiddleName, e.LastName AS LastName, d.Designation AS Designation FROM EmployeeThree e INNER JOIN Designation d ON e.DesignationId = d.Id;";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var desg = new EmployeeWithDesignationViewModel();

                        desg.FirstName = reader["FirstName"].ToString();
                        desg.MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString();
                        desg.LastName = reader["LastName"].ToString();
                        desg.DesignationName = reader["Designation"].ToString();
                        list.Add(desg);
                    }
                }
            }
            return list;
        }
        public List<EmployeeDetailsViewModel> DisplayByView()
        {
            var list = new List<EmployeeDetailsViewModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT EmployeeId, FirstName, MiddleName, LastName, Designation, DOB, MobileNumber, Address, Salary FROM VW_EmployeeDetails";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var desg = new EmployeeDetailsViewModel();

                        desg.Id = Convert.ToInt32(reader["EmployeeId"]);
                        desg.FirstName = reader["FirstName"].ToString();
                        desg.LastName = reader["LastName"].ToString();
                        desg.MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString();
                        desg.DesignationName = reader["Designation"].ToString();
                        desg.DOB = Convert.ToDateTime(reader["DOB"]);
                        desg.MobileNumber = (reader["MobileNumber"]).ToString();
                        desg.Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString();
                        desg.Salary = Convert.ToDecimal(reader["Salary"]);
                        list.Add(desg);
                    }
                }
            }
            return list;
        }

        public void InsertEmployee(EmployeeThree emp)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", (object)emp.MiddleName ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@DOB", emp.DOB);
                cmd.Parameters.AddWithValue("@MobileNumber", emp.MobileNumber);
                cmd.Parameters.AddWithValue("@Address", (object)emp.Address ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                cmd.Parameters.AddWithValue("@DesignationId", (object)emp.DesignationID ?? DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertDesignation(Designation desg)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_InsertDesignation", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Designation", desg.DesignationName);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Designation> GetAllDesignations()
        {
            var list = new List<Designation>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Designation AS DesignationName FROM Designation;";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var desg = new Designation();

                        desg.Id = Convert.ToInt32(reader["Id"]);
                        desg.DesignationName = reader["DesignationName"].ToString();
                        list.Add(desg);
                    }
                }
            }
            return list;
        }
        public List<DesignationMoreThanOneViewModel> MoreThanOneEmployeeDesignation()
        {
            var list = new List<DesignationMoreThanOneViewModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT d.Designation AS DesignationName FROM Designation d INNER JOIN EmployeeThree e ON d.Id = e.DesignationId GROUP BY d.Designation HAVING COUNT(e.Id) > 1;";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var desg = new DesignationMoreThanOneViewModel();

                        desg.DesignationName = reader["DesignationName"].ToString();
                        list.Add(desg);
                    }
                }
            }
            return list;
        }
        public List<EmployeeDetailsViewModel> DisplayByStoredProcedure()
        {
            var list = new List<EmployeeDetailsViewModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("SP_GetAllEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var desg = new EmployeeDetailsViewModel();

                        desg.Id = Convert.ToInt32(reader["EmployeeId"]);
                        desg.FirstName = reader["FirstName"].ToString();
                        desg.LastName = reader["LastName"].ToString();
                        desg.MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString();
                        desg.DesignationName = reader["Designation"].ToString();
                        desg.DOB = Convert.ToDateTime(reader["DOB"]);
                        desg.MobileNumber = (reader["MobileNumber"]).ToString();
                        desg.Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString();
                        desg.Salary = Convert.ToDecimal(reader["Salary"]);
                        list.Add(desg);
                    }
                }
            }
            return list;
        }

        public List<EmployeeDetailsByDesignationViewModel> DisplayEmployeesByDesignationStoredProcedure(int id)
        {
            var list = new List<EmployeeDetailsByDesignationViewModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("SP_GetEmployeesByDesignation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DesignationId", id);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var desg = new EmployeeDetailsByDesignationViewModel();

                        desg.Id = Convert.ToInt32(reader["EmployeeId"]);
                        desg.FirstName = reader["FirstName"].ToString();
                        desg.LastName = reader["LastName"].ToString();
                        desg.MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString();
                        desg.DOB = Convert.ToDateTime(reader["DOB"]);
                        desg.MobileNumber = (reader["MobileNumber"]).ToString();
                        desg.Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString();
                        desg.Salary = Convert.ToDecimal(reader["Salary"]);
                        list.Add(desg);
                    }
                }
            }
            return list;
        }

        public EmployeeDetailsViewModel MaxSalaryEmployee()
        {
            {
                var emp = new EmployeeDetailsViewModel();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT TOP 1 * FROM VW_EmployeeDetails Order By Salary DESC";

                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var desg = new EmployeeDetailsViewModel();

                            emp.Id = Convert.ToInt32(reader["EmployeeId"]);
                            emp.FirstName = reader["FirstName"].ToString();
                            emp.LastName = reader["LastName"].ToString();
                            emp.MiddleName = reader["MiddleName"] == DBNull.Value ? null : reader["MiddleName"].ToString();
                            emp.DesignationName = (reader["Designation"]).ToString();
                            emp.DOB = Convert.ToDateTime(reader["DOB"]);
                            emp.MobileNumber = (reader["MobileNumber"]).ToString();
                            emp.Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString();
                            emp.Salary = Convert.ToDecimal(reader["Salary"]);
                        }
                    }
                }
                return emp;
            }
        }

        public bool IsDesignationExists(string name)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Designation WHERE Designation = @name";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }
        public void CreateNonClusteredIndexOnDesignationId()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                IF NOT EXISTS (
                SELECT name 
                FROM sys.indexes 
                WHERE name = 'IX_Employee_DesignationId'
                )
                BEGIN
                CREATE NONCLUSTERED INDEX IX_Employee_DesignationId
                ON EmployeeThree (DesignationId);
                END";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }





    }
}