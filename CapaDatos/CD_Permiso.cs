using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Permiso
    {
        //Metodo Para Listar Permisos
        public List<Permisos> Listar(int idUsuario)
        {
            List<Permisos> lista = new List<Permisos>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                //Peticion dB

                try
                {
                    StringBuilder querySQL = new StringBuilder();
                    querySQL.AppendLine("Select p.IdRol, p.NombreMenu From PERMISOS p");
                    querySQL.AppendLine("Inner Join ROL r ON r.IdRol = p.IdRol");
                    querySQL.AppendLine("Inner Join USUARIO u ON u.IdRol = r.IdRol");
                    querySQL.AppendLine("Where u.IdUsuario = @idUsuario");

                    SqlCommand cmd = new SqlCommand(querySQL.ToString(), objConexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;
                    
                    objConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permisos()
                            {
                                objRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"])  },
                                NombreMenu = dr["NombreMenu"].ToString(),
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta Permisos: " + ex.Message);
                }
            }
            return lista;
        }//Cierre Del Metodo
    }
}
