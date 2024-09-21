using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Data.Conexion;

namespace fitsync
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            try
            {
                // Crear una instancia de la clase Conexion
                Conexion conexion = new Conexion();

                // Probar abrir la conexión
                conexion.AbrirConexion();

                // Si llegamos aquí, la conexión fue exitosa
                Console.WriteLine("Conexión a la base de datos fue exitosa.");

                // Probar cerrar la conexión
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
