using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;


namespace CapaDatos
{
    public class CD_UsuarioDataGridView
    {

        //Recuperar La Cadena De Conexión
        private static string connectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

        // Método para obtener los usuarios
        public static DataTable UsuariosDb()
        {
            try
            {
                // Abre la conexión con la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Ejecuta la consulta SQL
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM USUARIO", connection))
                    {
                        // Usa SqlDataAdapter para llenar un DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Captura excepciones y proporciona información adicional
                throw new Exception("Error al intentar recuperar los datos de la base de datos  CD_UsuarioDataGridView", ex);
            }
        }
    }
}
