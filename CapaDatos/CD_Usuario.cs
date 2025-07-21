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
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (SqlConnection objConexion = new SqlConnection(Conexion.cadena))
            {
                //Peticion dB

                try
                {
                    string querySQL = "SELECT a.IdUsuario, a.Documento, a.NombreCompleto, a.Correo, a.Clave, a.Estado, a.FechaRegistro," +
                        " b.Descripcion AS DescripcionRol " +
                    "FROM USUARIO a " +
                    "INNER JOIN ROL b ON a.IdRol = b.IdRol ";

                    SqlCommand cmd = new SqlCommand(querySQL, objConexion);
                    cmd.CommandType = CommandType.Text;

                    objConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Usuario usuario = new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                FechaRegistro = Convert.ToDateTime(dr["FECHAREGISTRO"]),
                                //Asignar el valor de la descripción del rol
                                DescripcionRol = dr["DescripcionRol"].ToString(),

                            };
                            listaUsuarios.Add(usuario);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    //lista = new List<Usuario>();
                }
            }
            return listaUsuarios;
        }//Cierre Del Metodo
    }
}