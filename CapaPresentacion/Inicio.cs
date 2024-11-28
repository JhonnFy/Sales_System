using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;
using CapaPresentacion;
using System.Windows.Media.Converters;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        //Variable De Tipo Usuario
        private static Usuario usuarioActual;
        //Variable Tipo Fromulario
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objUsuario)
        {

            usuarioActual = objUsuario;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuarioLogin.Text = usuarioActual.NombreCompleto;
            
        }

        private void lblUsuarioLogin_Click(object sender, EventArgs e)
        {

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        //Evento Click Invocando Un Metodo Personalizado De Colores
        private void Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioUsuarios((IconMenuItem)sender, new frmUsers());
        }

        //Activa El Color De Fondo Para El Formulario User
        private void AbrirFormularioUsuarios(IconMenuItem menuUsuario, Form formUser)
        {
            //if (MenuActivo != null)
            //{
            //    MenuActivo.BackColor = Color.White;
            //}

            menu.BackColor = Color.WhiteSmoke;
            Usuarios.ForeColor = Color.SteelBlue;
            MenuActivo = menuUsuario;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formUser;
            formUser.TopLevel = false;
            formUser.FormBorderStyle = FormBorderStyle.None;
            formUser.Dock = DockStyle.Fill;
            formUser.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            formUser.FormClosed += (s, e) =>
            {
                Usuarios.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(formUser);
            formUser.Show();
        }



            private void Administrador_Click(object sender, EventArgs e)
        {
            
        }

        //Evento Click
        private void Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormularioVentas((IconMenuItem)sender, new frmSales());
        }

        //Activa El Color De Fondo Para El Formulario Sales
        private void AbrirFormularioVentas(IconMenuItem menuVentas, Form formVentas)
        {
            menuVentas.BackColor = Color.WhiteSmoke;
            Ventas.ForeColor = Color.SteelBlue;
            MenuActivo = menuVentas;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formVentas;
            formVentas.TopLevel = false;
            formVentas.FormBorderStyle = FormBorderStyle.None;
            formVentas.Dock = DockStyle.Fill;
            formVentas.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            formVentas.FormClosed += (s, e) =>
            {
                Ventas.ForeColor = Color.Black;
            };


            Contenedor.Controls.Add(formVentas);
            formVentas.Show();
        }//Cerrar El Metodo

        //Evento Click
        private void Compras_Click(object sender, EventArgs e)
        {
            AbrirFormularioShopping((IconMenuItem)sender, new frmShopping());
        }
        //Activa El Color De Fondo Para El Formulario Shopping
        private void AbrirFormularioShopping(IconMenuItem menuShopping, Form formShopping)
        {
            menuShopping.BackColor = Color.WhiteSmoke;
            Shopping.ForeColor = Color.SteelBlue;
            MenuActivo = menuShopping;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formShopping;
            formShopping.TopLevel = false;
            formShopping.FormBorderStyle = FormBorderStyle.None;
            formShopping.Dock = DockStyle.Fill;
            formShopping.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            formShopping.FormClosed += (s, e) =>
            {
                Shopping.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(formShopping);
            formShopping.Show();

        }//Cerrar Metodo

        //Evento Click
        private void Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioClients((IconMenuItem)sender, new frmClients());
        }

        //Activa El Color De Fondo Para El Formulario Clients
        private void AbrirFormularioClients(IconMenuItem menuClients, Form formClients)
        {
            menuClients.BackColor = Color.WhiteSmoke;
            Clients.ForeColor = Color.SteelBlue;
            MenuActivo = menuClients;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formClients;
            formClients.TopLevel = false;
            formClients.FormBorderStyle = FormBorderStyle.None;
            formClients.Dock = DockStyle.Fill;
            formClients.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            formClients.FormClosed += (s, e) =>
            {
                Clients.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(formClients);
            formClients.Show();

        }//Cierra Del Metodo


        private void Proveedores_Click(object sender, EventArgs e)
        {

        }

        private void Reportes_Click(object sender, EventArgs e)
        {

        }

        private void MiGitHub_Click(object sender, EventArgs e)
        {
            //Evento Para Abrir La Url
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/JhonnFy",
                UseShellExecute = true
            });           
        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginV2 objLoginV2 = new LoginV2();
            objLoginV2.ShowDialog();
        }

        private void subMenuCategory_Click(object sender, EventArgs e)
        {
            AbrirFormularioAdministradorCategorias((IconMenuItem)sender, new FrmCategorys());
        }

        //Activa El Color De Fondo Para El Formulario Administrador-Categoria
        private void AbrirFormularioAdministradorCategorias(IconMenuItem menuAdmCategoria, Form formCategories)
        {
            //if (MenuActivo != null)
            //{
            //    MenuActivo.BackColor = Color.White;
            //}

            menu.BackColor = Color.WhiteSmoke;
            Administrador.ForeColor = Color.SteelBlue;
            MenuActivo = menuAdmCategoria;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formCategories;
            formCategories.TopLevel = false;
            formCategories.FormBorderStyle = FormBorderStyle.None;
            formCategories.Dock = DockStyle.Fill;
            formCategories.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            formCategories.FormClosed += (s, e) =>
            {
                Administrador.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(formCategories);
            formCategories.Show();
        }

        private void subMenuProduct_Click(object sender, EventArgs e)
        {
            AbrirFormularioAdministradorProductos((IconMenuItem)sender, new frmProducts());
        }

        //Activa El Color De Fondo Para El Formulario Administrador-Productos
        private void AbrirFormularioAdministradorProductos(IconMenuItem menuAdmProductos, Form formProductos)
        {
            menuAdmProductos.BackColor = Color.WhiteSmoke;
            Administrador.ForeColor = Color.SteelBlue;
            MenuActivo = menuAdmProductos;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formProductos;
            formProductos.TopLevel = false;
            formProductos.FormBorderStyle = FormBorderStyle.None;
            formProductos.Dock = DockStyle.Fill;
            formProductos.BackColor = Color.WhiteSmoke;

            // Manejador Para Cambiar El Color Al Cerrar El Formulario
            formProductos.FormClosed += (s, e) =>
            {
                Administrador.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(formProductos);
            formProductos.Show();

        }//Cerrar El Metodo
    }
}
