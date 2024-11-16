using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta Entidad Corresponde tbl_Permisos
namespace CapaEntidad
{
    public class Permisos
    {
        //Primer Atributo De La Tabla
        public int IdPermiso { get; set; }

        //Segundo Atributo De La Tabla  Relacionado con la clase Rol
        public Rol objRol { get; set; }

        //Tercer Atributo De La Tabla
        public string NombreMenu { get; set; }

        //Cuarto Atributo De La Tabla
        public DateTime FechaRegistro { get; set; }

    }
}
