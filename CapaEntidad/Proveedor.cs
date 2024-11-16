using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Esta Entidad Corresponde tbl_Proveedor
namespace CapaEntidad
{
    public class Proveedor
    {
        //Primer Atributo tbl_Proveedor
        public int IdProveedor {  get; set; }

        //Segundo Atributo tbl_Proveedor
        public string Documento { get; set; }

        //Tercer Atributo tbl_Proveedor
        public string Razonsocial { get; set; }

        //Cuarto Atributo tbl_Proveedor
        public string Correo {  get; set; }

        //Quinto Atributo tbl_Proveedor
        public string Telefono { get; set; }

        //Sexto Atributo tbl_Proveedor
        public string Estado { get; set; }

        //Septimo Atributo tbl_Proveedor
        public DateTime FechaRegistro { get; set; }
    }
}

