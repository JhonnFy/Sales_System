using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta Entidad Corresponde tbl_DetalleCompra
namespace CapaEntidad
{
    public class DetalleCompra
    {
        //Primer Atributo tbl_DetalleCompra
        public int IdDetalleCompra { get; set; }
        //Segundo Atributo tbl_DetalleCompra
        public Producto oProducto { get; set; }
        //Tercer Atributo tbl_DetalleCompra
        public decimal PrecioCompra { get; set; }
        //Cuarto Atributo tbl_DetalleCompra
        public decimal PrecioVenta { get; set; }
        //Quinto Atributo tbl_DetalleCompra
        public int Cantidad { get; set; }
        //Sexto Atributo tbl_DetalleCompra
        public decimal MontoTotal { get; set; }
        //Septimo Atributo tbl_DetalleCompra
        public DateTime FechaRegistro { get; set; }
    }
}


