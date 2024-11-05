using Microsoft.Data.SqlClient;

namespace Employees.Model
{
    public class Countries
    {
        public Countries()
        {

        }
        public void ConexionCountries()
        {
            string connectionString = "Server=85.208.21.117,54321;Database=AlexFerEmployees;User Id=as;Password=Sql#123456789;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al conectar: {ex.Message}");
                }
            }

        }
    }
}
