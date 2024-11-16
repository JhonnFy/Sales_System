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
        //Primer Atributo tbl_Permisos
        public int IdPermiso { get; set; }

        //Segundo Atributo tbl_Rol  Invocando La Clase Rol
        public Rol objRol {  get; set; }

        //Tercer Atributo tbl_Permisos
        public string NombreMenu { get; set; }

        //Cuarto Atributo tbl_Permisos
        public DateTime FechaRegistro { get; set; }
    }
}



