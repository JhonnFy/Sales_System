using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta Entidad Corresponde tbl_Compra
namespace CapaEntidad
{
    public class Compra
    {
        //Primer Atributo tbl_Compra
        public int IdCliente { get; set; }
        //Segundo Atributo tbl_Compra
        public Usuario oUsurio { get; set; }
        //Tercer Atributo tbl_Compra
        public Proveedor oProveedor { get; set; }
        //Cuarto Atributo tbl_Compra
        public string TipoFactura { get; set; }
        //Quinto Atributo tbl_Compra
        public string NumeroFactura { get; set; }
        //Sexto  Atributo tbl_Compra
        public decimal MontoTotal { get; set; }
        //Septimo  Atributo tbl_Compra
        public DateTime FechaRegistro { get; set; }

        //Lista Para El Detalle De La Compra
        public List<DetalleCompra> DetalleCompra {  get; set; }
    }
}
