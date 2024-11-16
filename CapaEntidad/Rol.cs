using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta Entidad Corresponde tbl_Rol
namespace CapaEntidad
{
    //
    public class Rol
    {
        //Primer Atributo De La Tabla IdRol(Int)
        public int IdRol {  get; set; }

        //Segundo Atributo De La Tabla Descripcion varchar50
        public string Descripcion { get; set; }

        //Tercer Atributo De La Tabla FechaRegistro Datetime
        public DateTime FechaRegistro { get; set; }

    }
}
