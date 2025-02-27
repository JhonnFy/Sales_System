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
                dataGridViewUsuarios.Columns["DOCUMENTO"].HeaderText = "DOCUMENTO";
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].HeaderText = "NOMBRE COMPLETO";
                dataGridViewUsuarios.Columns["CORREO"].HeaderText = "CORREO";
                dataGridViewUsuarios.Columns["CLAVE"].HeaderText = "CLAVE";
                //Agregar columna de Rol
                dataGridViewUsuarios.Columns["DescripcionRol"].HeaderText = "DESCRIPCIÓN ROL";

                // Ocultar columnas adicionales
                dataGridViewUsuarios.Columns["objRol"].Visible = false;
                dataGridViewUsuarios.Columns["Estado"].Visible = false;
                dataGridViewUsuarios.Columns["FechaRegistro"].Visible = false;

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
