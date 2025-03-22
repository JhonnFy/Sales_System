using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio; //Acceder a CN_Usuario
using CapaEntidad; //Acceder a usuario

namespace CapaPresentacion
{
    public partial class frmUsers : Form
    {

        private CN_Usuario objCN_Usuario = new CN_Usuario();


        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            ListarUsuarios();  
        }

        private void ListarUsuarios()
        {
            try
            {
                //Obtener la lista de usuarios, de la capa negocio
                var usuarios = objCN_Usuario.Listar();

                // Asignar los datos al DataGridView
                dataGridViewUsuarios.DataSource = usuarios;

                // Ocultar la columna vacía a la izquierda
                dataGridViewUsuarios.RowHeadersVisible = false;

                // // Personalizar las columnas visibles
                dataGridViewUsuarios.Columns["IdUsuario"].HeaderText = "Entry Numbe";
                dataGridViewUsuarios.Columns["DOCUMENTO"].HeaderText = "Document";
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].HeaderText = "Full Name";
                dataGridViewUsuarios.Columns["CLAVE"].HeaderText = "Password";
                dataGridViewUsuarios.Columns["CORREO"].HeaderText = "Mail";
                //Agregar columna de Rol
                dataGridViewUsuarios.Columns["DescripcionRol"].HeaderText = "Role Description";

                // Ocultar columnas adicionales
                dataGridViewUsuarios.Columns["objRol"].Visible = false;
                dataGridViewUsuarios.Columns["Estado"].Visible = false;
                dataGridViewUsuarios.Columns["FechaRegistro"].Visible = false;

                //Fijando El Tamaño
                dataGridViewUsuarios.Columns["IdUsuario"].Width = 100;
                dataGridViewUsuarios.Columns["DOCUMENTO"].Width = 100;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].Width = 150;
                dataGridViewUsuarios.Columns["CLAVE"].Width = 150;
                dataGridViewUsuarios.Columns["CORREO"].Width = 250;
                dataGridViewUsuarios.Columns["DescripcionRol"].Width = 200;

                //Alinear La Cabecera
                dataGridViewUsuarios.Columns["IdUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["DOCUMENTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["CLAVE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["CORREO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["DescripcionRol"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                // Alinear A La Izquierda 
                dataGridViewUsuarios.Columns["IdUsuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["DOCUMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.Columns["CLAVE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.Columns["CORREO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.Columns["DescripcionRol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Evitar que las columnas se redimensionen con el mouse
                dataGridViewUsuarios.AllowUserToResizeColumns = false;
                dataGridViewUsuarios.AllowUserToResizeRows = false;

                //Reordenar Las Columas En El DataGridView
                dataGridViewUsuarios.Columns["IdUsuario"].DisplayIndex = 0; // Columna 1
                dataGridViewUsuarios.Columns["DOCUMENTO"].DisplayIndex = 1; // Columna 2
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].DisplayIndex = 2; // Columna 3
                dataGridViewUsuarios.Columns["CLAVE"].DisplayIndex = 3; // Columna 4
                dataGridViewUsuarios.Columns["DescripcionRol"].DisplayIndex = 4; // Columna 5
                dataGridViewUsuarios.Columns["CORREO"].DisplayIndex = 5; // Columna 6

                //Asignar Color De Fondo
                //dataGridViewUsuarios.Columns["DOCUMENTO"].HeaderCell.Style.BackColor = Color.White;


                dataGridViewUsuarios.Columns["IdUsuario"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["IdUsuario"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["DOCUMENTO"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["DOCUMENTO"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].DefaultCellStyle.ForeColor = Color.Black;

                //Inactiva el cambio de color con el paso del cursos del mouse
                dataGridViewUsuarios.EnableHeadersVisualStyles = false;

   //             dataGridViewUsuarios.GridColor = Color.Transparent;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Presentación DGV: " + ex.Message);
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
