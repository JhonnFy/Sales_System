using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta Entidad Corresponde tbl_Categoria
namespace CapaEntidad
{
    public class Categoria
    {
        //Primer Atributo tbl_Categoria
        public int IdCategoria { get; set; }

        //Segundo Atributo tbl_Categoria
        public string Descripcion { get; set; }

        //Tercer Atributo tbl_Categoria
        public string Estado { get; set; }

        //Cuarto Atributo tbl_Proveedor
        public DateTime FechaRegistro { get; set; }
    }
}
