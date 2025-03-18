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
                         
                // // Personalizar las columnas visibles
                dataGridViewUsuarios.Columns["IdUsuario"].HeaderText = "Entry Numbe";
                dataGridViewUsuarios.Columns["DOCUMENTO"].HeaderText = "Document";
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].HeaderText = "Full Name";
                dataGridViewUsuarios.Columns["CORREO"].HeaderText = "Mail";
                dataGridViewUsuarios.Columns["CLAVE"].HeaderText = "Password";
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
                dataGridViewUsuarios.Columns["CORREO"].Width = 250;
                dataGridViewUsuarios.Columns["CLAVE"].Width = 150;
                dataGridViewUsuarios.Columns["DescripcionRol"].Width = 200;

                // Evitar que las columnas se redimensionen con el mouse
                dataGridViewUsuarios.Columns["IdUsuario"].Resizable = DataGridViewTriState.False;
                dataGridViewUsuarios.Columns["DOCUMENTO"].Resizable = DataGridViewTriState.False;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].Resizable = DataGridViewTriState.False;
                dataGridViewUsuarios.Columns["CORREO"].Resizable = DataGridViewTriState.False;
                dataGridViewUsuarios.Columns["CLAVE"].Resizable = DataGridViewTriState.False;
                dataGridViewUsuarios.Columns["DescripcionRol"].Resizable = DataGridViewTriState.False;

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
