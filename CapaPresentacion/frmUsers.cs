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

        //Variables para la paginación
        private List<Usuario> TodosLosUsuarios = new List<Usuario>();
        private int PaginaActual = 1;
        private int RegistroPorPagina = 25;
        private int TotalPaginas = 0;

        //Metodo Constructor
        public frmUsers()
        {
            InitializeComponent();
        }


        private void frmUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataBindingComplete += ReordenarColumnasEnDgw;
            TodosLosUsuarios = objCN_Usuario.Listar();
            TotalPaginas = (int)Math.Ceiling((double)TodosLosUsuarios.Count / RegistroPorPagina); 
            ListarUsuarios();

        }

        private void ListarUsuarios()
        {
            try
            {

                var usuariosPaginados = TodosLosUsuarios
                    .Skip((PaginaActual - 1) * RegistroPorPagina)
                    .Take(RegistroPorPagina)
                    .Select((u, index) => new
                    {
                        NumeroFila = (PaginaActual -1) * RegistroPorPagina + index + 1,
                        IdUsuario = u.IdUsuario,
                        DOCUMENTO = u.Documento,
                        NOMBRECOMPLETO = u.NombreCompleto,
                        CLAVE = u.Clave,
                        CORREO = u.Correo,
                        DescripcionRol = u.DescripcionRol,
                        FECHAREGISTRO =  u.FechaRegistro,
                        ESTADO = u.Estado ? 1 : 0,
                        EstadoTexto = u.Estado ? "Enabled User" : "Disabled User",
                        //Campos Ocultos En El DataGridView
                        objRol = u.objRol
                        
                    })
                    .ToList();
                    

                //Obtener la lista de usuarios, de la capa negocio
                //var usuarios = objCN_Usuario.Listar(); //Antigua Variable Mostraba Todos Los Usuarios

                // Asignar los datos al DataGridView
                dataGridViewUsuarios.DataSource = usuariosPaginados;

                // Ocultar la columna vacía a la izquierda
                dataGridViewUsuarios.RowHeadersVisible = false;


                // Personalizar las columnas visibles
                dataGridViewUsuarios.Columns["NumeroFila"].HeaderText = "N°";
                dataGridViewUsuarios.Columns["IdUsuario"].HeaderText = "Entry Number";
                dataGridViewUsuarios.Columns["DOCUMENTO"].HeaderText = "Document";
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].HeaderText = "Full Name";
                dataGridViewUsuarios.Columns["CLAVE"].HeaderText = "Password";
                //Agregar columna de Rol
                dataGridViewUsuarios.Columns["DescripcionRol"].HeaderText = "Role Description";
                dataGridViewUsuarios.Columns["CORREO"].HeaderText = "Mail";
                dataGridViewUsuarios.Columns["FECHAREGISTRO"].HeaderText = "Fecha Registro";
                dataGridViewUsuarios.Columns["EstadoTexto"].HeaderText = "Estado";

                // Ocultar columnas adicionales
                dataGridViewUsuarios.Columns["IdUsuario"].Visible = false;
                dataGridViewUsuarios.Columns["objRol"].Visible = false;
                dataGridViewUsuarios.Columns["Estado"].Visible = false;
                

                //Fijando El Tamaño
                dataGridViewUsuarios.Columns["NumeroFila"].Width = 50;
                dataGridViewUsuarios.Columns["IdUsuario"].Width = 100;
                dataGridViewUsuarios.Columns["DOCUMENTO"].Width = 100;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].Width = 200;
                dataGridViewUsuarios.Columns["CLAVE"].Width = 150;
                dataGridViewUsuarios.Columns["DescripcionRol"].Width = 220;
                dataGridViewUsuarios.Columns["CORREO"].Width = 300;
                dataGridViewUsuarios.Columns["FECHAREGISTRO"].Width = 200;
                dataGridViewUsuarios.Columns["EstadoTexto"].Width = 144;

                //Alinear La Cabecera
                dataGridViewUsuarios.Columns["NumeroFila"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["IdUsuario"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["DOCUMENTO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["CLAVE"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["DescripcionRol"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["CORREO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["FECHAREGISTRO"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["EstadoTexto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


                // Alinear 
                dataGridViewUsuarios.Columns["NumeroFila"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["IdUsuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["DOCUMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.Columns["CLAVE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.Columns["DescripcionRol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.Columns["CORREO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.Columns["FECHAREGISTRO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewUsuarios.Columns["EstadoTexto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Evitar que las columnas se redimensionen con el mouse
                dataGridViewUsuarios.AllowUserToResizeColumns = false;
                dataGridViewUsuarios.AllowUserToResizeRows = false;


                //Asignar Color De Fondo
                //dataGridViewUsuarios.Columns["DOCUMENTO"].HeaderCell.Style.BackColor = Color.White;

                dataGridViewUsuarios.Columns["NumeroFila"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["NumeroFila"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["IdUsuario"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["IdUsuario"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["DOCUMENTO"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["DOCUMENTO"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["CLAVE"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["CLAVE"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["DescripcionRol"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["DescripcionRol"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["CORREO"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["CORREO"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["FECHAREGISTRO"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["FECHAREGISTRO"].DefaultCellStyle.ForeColor = Color.Black;
                dataGridViewUsuarios.Columns["EstadoTexto"].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dataGridViewUsuarios.Columns["EstadoTexto"].DefaultCellStyle.ForeColor = Color.Black;


                //Eliminar El Borde Externo
                dataGridViewUsuarios.BorderStyle = BorderStyle.None;

                //Inactiva el cambio de color con el paso del cursos del mouse
                dataGridViewUsuarios.EnableHeadersVisualStyles = false;

                //dataGridViewUsuarios.GridColor = Color.Transparent;

                //Invocar el metodo
                ActualizarLabelPagina();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Presentación DGV: " + ex.Message);
            }
        }

        //Metodo Para Reordenar Las Columas En El DataGridView
        private void ReordenarColumnasEnDgw(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dataGridViewUsuarios.Columns["NumeroFila"].DisplayIndex = 0; // Columna 1
                dataGridViewUsuarios.Columns["DOCUMENTO"].DisplayIndex = 1; // Columna 2
                dataGridViewUsuarios.Columns["NOMBRECOMPLETO"].DisplayIndex = 2; // Columna 3
                dataGridViewUsuarios.Columns["CLAVE"].DisplayIndex = 3; // Columna 4
                dataGridViewUsuarios.Columns["DescripcionRol"].DisplayIndex = 4; // Columna 5
                dataGridViewUsuarios.Columns["CORREO"].DisplayIndex = 5; // Columna 6
                dataGridViewUsuarios.Columns["FECHAREGISTRO"].DisplayIndex = 6; // Columna 7
                dataGridViewUsuarios.Columns["EstadoTexto"].DisplayIndex = 7; //Columna 8
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error En El Metodo: ReordenarColumnasEnDgw " + ex.Message);
            }
        }



        //Metodo para actualizar Label De Paginas
        private void ActualizarLabelPagina()
        {
            labelPages.Text = $"{PaginaActual} - {TotalPaginas}";
        }


        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //Btn_Anterior
        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            if (PaginaActual > 1)
            {
                PaginaActual--;
                ListarUsuarios();
            }
        }

        //Btn_Siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (PaginaActual < TotalPaginas)
            {
                PaginaActual++;
                ListarUsuarios();
            }
        }
    }
}
