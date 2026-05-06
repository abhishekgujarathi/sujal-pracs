using System;
using System.Collections.Generic;
using PracticalTwelve.Models;

namespace PracticalTwelve.Data
{
    public static class EmployeeTwoSeeder
    {
        public static List<EmployeeTwo> GetDummyData()
        {
            return new List<EmployeeTwo>
            {
                new EmployeeTwo
                {
                    FirstName = "Rahul",
                    MiddleName = null,
                    LastName = "Patel",
                    DOB = new DateTime(1998, 5, 10),
                    MobileNumber = "9876543210",
                    Address = "Surat",
                    Salary = 25000
                },
                new EmployeeTwo
                {
                    FirstName = "Amit",
                    MiddleName = "Kumar",
                    LastName = "Shah",
                    DOB = new DateTime(2002, 3, 15),
                    MobileNumber = "9123456789",
                    Address = "Ahmedabad",
                    Salary = 30000
                },
                new EmployeeTwo
                {
                    FirstName = "Neha",
                    MiddleName = null,
                    LastName = "Joshi",
                    DOB = new DateTime(1995, 7, 20),
                    MobileNumber = "9988776655",
                    Address = "Baroda",
                    Salary = 28000
                }
            };
        }
    }
}