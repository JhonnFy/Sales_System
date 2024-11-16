using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
//Esta Entidad Corresponde tbl_Venta
namespace CapaEntidad
{
    public class Venta
    {
        //Primer Atributo tbl_Venta
        public int IdVenta { get; set; }
        //Segundo Atributo tbl_Venta
        public Usuario oUsuario { get; set; }
        //Tercer Atributo tbl_Venta
        public string TipoFactura { get; set; }
        //cuarto Atributo tbl_Venta
        public string NumeroFactura { get; set; }
        //Quinto Atributo tbl_Venta
        public string DocumentoCliente { get; set; }
        //Sexto Atributo tbl_Venta
        public string NombreCliente { get; set; }
        //Septimo Atributo tbl_Venta
        public decimal MontoPago { get; set; }
        //Octavo Atributo tbl_Venta
        public decimal MontoCambio { get; set; }
        //Noveno Atributo tbl_Venta
        public decimal MontoTotal { get; set; }
        //Decimo Atributo tbl_Venta
        public DateTime FechaRegistro { get; set; }
        //Lista Detalle De Venta
        public List<DetalleVenta> oDetalleVenta { get; set; }
    }
}