using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayroll_ADO.NET
{
    public class EmpPayrollServices
    {
        // for Database Connection
        private static string connectionString = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=PayRoll_Service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
   
        public bool DataBaseConnection()
        {
            try
            {
                connection.Open();
                using (connection)
                {
                    Console.WriteLine($"connection is created successful");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}