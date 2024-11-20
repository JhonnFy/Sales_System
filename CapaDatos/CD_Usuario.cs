using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nueva Referencia
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
 

namespace CapaDatos
{
    public class CD_Usuario
    {
        //Clase de conexión para ejecutar consultas SQL en la base de datos

        //Metodo Para Listar Usuarios
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                //Peticion dB

                try
                {
                    string querySQL = "SELECT  IdUsuario, Documento, NombreCompleto,Correo,Clave, Estado  FROM [dbSistema_Ventas].[dbo].[USUARIO]";
                    SqlCommand cmd = new SqlCommand(querySQL, objConexion);
                    
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
    }
}