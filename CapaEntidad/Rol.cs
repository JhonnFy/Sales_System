using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta Entidad Corresponde tbl_Rol
namespace CapaEntidad
{
    public class Rol
    {
        //Primer Atributo tbl_Rol
        public int IdRol {  get; set; }

        //Segundo Atributo tbl_Rol
        public string Descripcion { get; set; }

        //Tercer Atributo tbl_Rol
        public DateTime FechaRegistro  { get; set; }

        //Objeto
        public Rol objRol { get; set; }

    }
}
