using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nueva referencia
using System.Configuration;
using System.Xml.Linq;


namespace CapaDatos
{
    public class Conexion
    {
        //Se crea una clase de conexión que se encarga de enviar la cadena de conexión almacenada en el archivo App.config 
        //a las demás clases. 
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}

