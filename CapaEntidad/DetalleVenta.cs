using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta Entidad Corresponde tbl_DetalleVenta
namespace CapaEntidad
{
    public class DetalleVenta
    {
        //Primer Atributo tbl_DetalleVenta
        public int IdDetalleVenta {  get; set; }
        //Segundo Atributo tbl_DetalleVenta 
        public Producto oProducto { get; set; }
        //Tercer Atributo tbl_DetalleVenta 
        public decimal PrecioVenta { get; set; }
        //Cuarto Atributo tbl_DetalleVenta 
        public int Cantidad { get; set; }
        //Quinto Atributo tbl_DetalleVenta 
        public decimal SubTotal { get; set; }
        //Sexto Atributo tbl_DetalleVenta 
        public DateTime FechaRegistro { get; set; }
    }
}