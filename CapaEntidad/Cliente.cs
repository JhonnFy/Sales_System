using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta Entidad Corresponde tbl_Cliente
namespace CapaEntidad
{
    public class Cliente
    {
        //Primer Atributo tbl_Cliente
        public int IdCliente {  get; set; }
        //Segundo Atributo tbl_Cliente
        public string Documento { get; set; }
        //Tercer Atributo tbl_Cliente
        public string NombreCompleto { get; set; }
        //Cuarto Atributo tbl_Cliente
        public string Correo { get; set; }
        //Cuarto Atributo tbl_Cliente
        public string Telefono { get; set; }
        //Quinto Atributo tbl_Cliente
        public bool Estado { get; set; }
        //Quinto Atributo tbl_Cliente
        public DateTime FechaRegistro { get; set; }
    }
}