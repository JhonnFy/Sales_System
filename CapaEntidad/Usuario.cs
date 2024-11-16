using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Esta Entidad Corresponde tbl_Usuario
namespace CapaEntidad
{
    public class Usuario
    {
        //Primer Atributo tbl_Usuario
        public int IdUsuario { get; set; }
        //Segundo Atributo tbl_Usuario
        public string Documento { get; set; }
        //Cuarto Atributo tbl_Usuario
        public string NombreCompleto { get; set; }
        //Quinto Atributo tbl_Usuario
        public string  Correo { get; set; }
        //Sexto Atributo tbl_Usuario
        public string Clave { get; set; }
        //Septimo Atributo tbl_Usuario
        public Rol objRol { get; set; }
        //Ocatvo Atributo tbl_Usuario
        public bool Estado { get; set; }
        //Noveno Atributo tbl_Usuario
        public DateTime FechaRegistro { get; set; }
    }
}
