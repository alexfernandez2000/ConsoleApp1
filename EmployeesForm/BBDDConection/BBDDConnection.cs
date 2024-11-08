using EmployeesForm.BBDDConection.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeesForm.Model
{
    public class BBDDConnection : IBBDDConnection
    {
       public SqlConnection Connection;
        public BBDDConnection()
        {
            string connectionString = "Server=85.208.21.117,54321;Database=AlexFerEmployees;User Id=sa;Password=Sql#123456789;";
            Connection = new SqlConnection(connectionString);
        }
        public void Conexion()
        {
                try
                {
                if (Connection.State!=ConnectionState.Open)
                    Connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al conectar: {ex.Message}");
                }
        }
        
        public void Desconexion()
        {
            try
            {
                if (Connection.State!=ConnectionState.Closed)
                    Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar: {ex.Message}");
            }
        }
        public object NullToDBNull(object value)
        {
            return value ?? DBNull.Value;
        }
    }
}
