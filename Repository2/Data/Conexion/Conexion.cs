using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repository.Data.Conexion
{
    public class Conexion
    {
        public SqlConnection conexion;

        public Conexion()
        {
            string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

            conexion = new SqlConnection(connectionString);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    Console.WriteLine("Conexión abierta exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    Console.WriteLine("Conexión cerrada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
