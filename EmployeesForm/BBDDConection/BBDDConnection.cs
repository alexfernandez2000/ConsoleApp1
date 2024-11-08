using EmployeesForm.BBDDConection;
using EmployeesForm.BBDDConection.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeesForm.Model
{
    public class BBDDConnection : IBBDDConnection
    {
       protected EmployeesDC _dc;
        public BBDDConnection()
        {
            _dc = new EmployeesDC();
        }
        public void Conexion()
        {
                try
                {
                if (_dc.Connection.State!=ConnectionState.Open)
                    _dc.Connection.Open();
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
                if (_dc.Connection.State!=ConnectionState.Closed)
                    _dc.Connection.Close();
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
