using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta Entidad Corresponde tbl_Producto
namespace CapaEntidad
{
    public class Producto
    {
        //Primer Atributo tbl_Producto
        public int IdProducto { get; set; }
        //Segundo Atributo tbl_Producto
        public string Codigo { get; set; }
        //Tercer Atributo tbl_Producto
        public string Nombre    { get; set; }
        //Cuarto Atributo tbl_Producto
        public string Descripcion { get; set; }
        //Quinto Atributo tbl_Producto
        public Categoria oCategoria { get; set; }
        //Sexto Atributo tbl_Producto
        public int Stock { get; set; }
        //Septimo Atributo tbl_Producto
        public decimal PrecioCompra { get; set; }
        //Octavo Atributo tbl_Producto
        public decimal PrecioVenta { get; set; }
        //Noveno Atributo tbl_Producto
        public bool Estado { get; set; }
        //Decimo Atributo tbl_Producto
        public DateTime FechaRegistro { get; set; }
    }
}



