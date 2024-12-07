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
using System.Drawing.Text;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        //Variable De Tipo Usuario
        private static Usuario usuarioActual;
        //Variable De Tipo Rol
        private static Rol rolActual;
        //Variable Tipo Fromulario
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objUsuario, Rol objRol)
        {

            usuarioActual = objUsuario;
            rolActual = objRol;

            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Presentar En Pantalla El Nombre Del Usuario
        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permisos> ListaPermisos = new CN_Permisos().Listar(usuarioActual.IdUsuario);

            //Restringir la vista de formulario
            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);

                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }

            
            lblUsuarioLogin.Text = (usuarioActual.NombreCompleto + " ↔ " + rolActual.Descripcion).ToUpper();
            
            List<Rol> ListaRol = new CN_DescripcionRol().Listar(rolActual.IdRol);
            //Restringir la vista de formulario
            foreach(IconMenuItem iconMenuItem in menu.Items)
            {
                bool rolEncontrado = ListaRol.Any(m => m.Descripcion == iconMenuItem.Name);

            }
            //lblUsuarioLogin.Text = nombreUsuario.ToUpper();

        }//Cierre Del Metodo

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
            menuUser.ForeColor = Color.SteelBlue;
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
                menuUser.ForeColor = Color.Black;
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
            //Este Metodo Solo Se Usa, Si No Desea Usas Los IconMenuItem
            //AbrirFormularioVentas((IconMenuItem)sender, new frmSales());
        }

        //Activa El Color De Fondo Para El Formulario Sales
        //private void AbrirFormularioVentas(IconMenuItem menuVentas, Form formVentas)
        //{
        //    menuVentas.BackColor = Color.WhiteSmoke;
        //    Ventas.ForeColor = Color.SteelBlue;
        //    MenuActivo = menuVentas;

        //    if (FormularioActivo != null)
        //    {
        //        FormularioActivo.Close();
        //    }

        //    FormularioActivo = formVentas;
        //    formVentas.TopLevel = false;
        //    formVentas.FormBorderStyle = FormBorderStyle.None;
        //    formVentas.Dock = DockStyle.Fill;
        //    formVentas.BackColor = Color.WhiteSmoke;

        //    //Manejador Para Cambiar El Color Al Cerrar El Formulario
        //    formVentas.FormClosed += (s, e) =>
        //    {
        //        Ventas.ForeColor = Color.Black;
        //    };


        //    Contenedor.Controls.Add(formVentas);
        //    formVentas.Show();
        //}//Cerrar El Metodo

        //Evento Click
        private void Compras_Click(object sender, EventArgs e)
        {
            //AbrirFormularioShopping((IconMenuItem)sender, new frmShopping());
        }
        //Activa El Color De Fondo Para El Formulario Shopping
        //private void AbrirFormularioShopping(IconMenuItem menuShopping, Form frmShopping)
        //{
        //    menuShopping.BackColor = Color.WhiteSmoke;
        //    Shopping.ForeColor = Color.SteelBlue;
        //    MenuActivo = menuShopping;

        //    if (FormularioActivo != null)
        //    {
        //        FormularioActivo.Close();
        //    }

        //    FormularioActivo = frmShopping;
        //    frmShopping.TopLevel = false;
        //    frmShopping.FormBorderStyle = FormBorderStyle.None;
        //    frmShopping.Dock = DockStyle.Fill;
        //    frmShopping.BackColor = Color.WhiteSmoke;

        //    //Manejador Para Cambiar El Color Al Cerrar El Formulario
        //    frmShopping.FormClosed += (s, e) =>
        //    {
        //        Shopping.ForeColor = Color.Black;
        //    };

        //    Contenedor.Controls.Add(frmShopping);
        //    frmShopping.Show();

        //}//Cerrar Metodo

        //Evento Click
        private void Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioClients((IconMenuItem)sender, new frmClients());
        }

        //Activa El Color De Fondo Para El Formulario Clients
        private void AbrirFormularioClients(IconMenuItem menuClients, Form frmClients)
        {
            menuClients.BackColor = Color.WhiteSmoke;
            this.menuClients.ForeColor = Color.SteelBlue;
            MenuActivo = menuClients;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = frmClients;
            frmClients.TopLevel = false;
            frmClients.FormBorderStyle = FormBorderStyle.None;
            frmClients.Dock = DockStyle.Fill;
            frmClients.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            frmClients.FormClosed += (s, e) =>
            {
                this.menuClients.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(frmClients);
            frmClients.Show();

        }//Cierra Del Metodo


        //Evento Click
        private void Proveedores_Click(object sender, EventArgs e)
        {
            AbrirElFormularioSuppliers((IconMenuItem)sender, new frmSuppliers());
        }

        //Activa El Color De Fondo Para El Formulario Suppliers
        private void AbrirElFormularioSuppliers(IconMenuItem menuAdmSuppliers, Form frmSuppliers)
        {
            menuAdmSuppliers.BackColor = Color.WhiteSmoke;
            menuSuppliers.ForeColor = Color.SteelBlue;
            MenuActivo = menuAdmSuppliers;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = frmSuppliers;
            frmSuppliers.TopLevel = false;
            frmSuppliers.FormBorderStyle = FormBorderStyle.None;
            frmSuppliers.Dock = DockStyle.Fill;
            frmSuppliers.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            frmSuppliers.FormClosed += (s, e) =>
            {
                menuSuppliers.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(frmSuppliers);
            frmSuppliers.Show();
        }//Cierre Del Metodo

        //Evento Click
        private void Reportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioReports((IconMenuItem)sender, new frmReports());
        }

        //Activa El Color De Fondo Para El Formulario Reports
        private void AbrirFormularioReports(IconMenuItem menuAdmReports, Form frmReports)
        {
            menuAdmReports.BackColor = Color.WhiteSmoke;
            menuReports.ForeColor = Color.SteelBlue;
            MenuActivo = menuAdmReports;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = frmReports;
            frmReports.TopLevel = false;
            frmReports.FormBorderStyle = FormBorderStyle.None;
            frmReports.Dock = DockStyle.Fill;
            frmReports.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            frmReports.FormClosed += (s, e) =>
            {
                menuReports.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(frmReports);
            frmReports.Show();
        }//CierreDelMetodo


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
            this.Hide(); //Ocultar El Formulario Actual
            LoginV2 objLoginV2 = new LoginV2(); //Se Crea El Objeto
            
            this.Close(); 
        }

        //Evento Click Moes
        private void subMenuCategory_Click(object sender, EventArgs e)
        {
            AbrirFormularioAdministradorCategorias((IconMenuItem)sender, new frmCategorys());
        }

        //Activa El Color De Fondo Para El Formulario Administrador-Categoria
        private void AbrirFormularioAdministradorCategorias(IconMenuItem menuAdmCategoria, Form frmCategorys)
        {
            //if (MenuActivo != null)
            //{
            //    MenuActivo.BackColor = Color.White;
            //}

            menu.BackColor = Color.WhiteSmoke;
            menuAdministrator.ForeColor = Color.SteelBlue;
            MenuActivo = menuAdmCategoria;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = frmCategorys;
            frmCategorys.TopLevel = false;
            frmCategorys.FormBorderStyle = FormBorderStyle.None;
            frmCategorys.Dock = DockStyle.Fill;
            frmCategorys.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            frmCategorys.FormClosed += (s, e) =>
            {
                menuAdministrator.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(frmCategorys);
            frmCategorys.Show();
        }

        private void subMenuProduct_Click(object sender, EventArgs e)
        {
            AbrirFormularioAdministradorProductos((IconMenuItem)sender, new frmProducts());
        }

        //Activa El Color De Fondo Para El Formulario Administrador-Productos
        private void AbrirFormularioAdministradorProductos(IconMenuItem menuAdmProductos, Form frmProducts)
        {
            menuAdmProductos.BackColor = Color.WhiteSmoke;
            menuAdministrator.ForeColor = Color.SteelBlue;
            MenuActivo = menuAdmProductos;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = frmProducts;
            frmProducts.TopLevel = false;
            frmProducts.FormBorderStyle = FormBorderStyle.None;
            frmProducts.Dock = DockStyle.Fill;
            frmProducts.BackColor = Color.WhiteSmoke;

            // Manejador Para Cambiar El Color Al Cerrar El Formulario
            frmProducts.FormClosed += (s, e) =>
            {
                menuAdministrator.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(frmProducts);
            frmProducts.Show();

        }//Cerrar El Metodo

        private void subRegister_Click(object sender, EventArgs e)
        {
            //Evento Click
            AbrirFormularioRegisterSales((IconMenuItem)sender, new frmSalesRegister());
        }

        //Activa El Color De Fondo Para El SubFormulario Registrar Venta
        private void AbrirFormularioRegisterSales(IconMenuItem menuRegistrarVenta, Form frmSalesRegister)
        {
            menuRegistrarVenta.BackColor = Color.WhiteSmoke;
            menuSales.ForeColor = Color.SteelBlue;
            MenuActivo = menuRegistrarVenta;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }


            FormularioActivo = frmSalesRegister;
            frmSalesRegister.TopLevel = false;
            frmSalesRegister.FormBorderStyle = FormBorderStyle.None;
            frmSalesRegister.Dock = DockStyle.Fill;
            frmSalesRegister.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            frmSalesRegister.FormClosed += (s, e) =>
            {
                menuSales.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(frmSalesRegister);
            frmSalesRegister.Show();
        }//Cierre Del Metodo

        //Evento Click
        private void subSaleDetail_Click(object sender, EventArgs e)
        {
            AbrirFormulariofrmSalesDetail((IconMenuItem)sender, new frmSalesDetail());
        }
    
        private void AbrirFormulariofrmSalesDetail(IconMenuItem menuDetalleVenta, Form frmSalesDetail)
        {
            menuDetalleVenta.BackColor = Color.WhiteSmoke;
            menuSales.ForeColor = Color.SteelBlue;
            MenuActivo = menuDetalleVenta;

            if (FormularioActivo != null)
            {
                FormularioActivo = frmSalesDetail;
                frmSalesDetail.TopLevel = false;
                frmSalesDetail.FormBorderStyle = FormBorderStyle.None;
                frmSalesDetail.Dock = DockStyle.Fill;
                frmSalesDetail.BackColor = Color.WhiteSmoke;

                //Manejador Para Cambiar El Color Al Cerrar El Formulario
                frmSalesDetail.FormClosed += (s, e) =>
                {
                    menuSales.ForeColor = Color.Black;
                };

                //frmSalesDetail
                Contenedor.Controls.Add(frmSalesDetail);
                frmSalesDetail.Show();
            }
        }

        //Evento Click Shopping Register
        private void subShoppingRegister_Click(object sender, EventArgs e)
        {
            AbrirFormularioShoppingRegister((IconMenuItem)sender, new frmShoppingRegister());
        }

        //Activar El Color De Fondo Para El Formulario Shopping Register
        private void AbrirFormularioShoppingRegister(IconMenuItem menuShoppingRegister, Form frmShoppingRegister)
        {
            //frmShoppingRegister
            menu.BackColor = Color.WhiteSmoke;
            menuShopping.ForeColor = Color.SteelBlue;
            MenuActivo = menuShoppingRegister;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = frmShoppingRegister;
            frmShoppingRegister.TopLevel = false;
            frmShoppingRegister.FormBorderStyle = FormBorderStyle.None;
            frmShoppingRegister.Dock = DockStyle.Fill;
            frmShoppingRegister.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El Color Al Cerrar El Formulario
            frmShoppingRegister.FormClosed += (s, e) =>
            {
                menuShopping.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(frmShoppingRegister);
            frmShoppingRegister.Show();
        }

        //Evento Click Shopping Detail
        private void subShoppingDetail_Click(object sender, EventArgs e)
        {
            AbrirFormularioShoppingDetail((IconMenuItem)sender, new frmShoppingDetail());
        }

        //Activa El Color De Fondo Para El Formulario ShoppingDetail
        private void AbrirFormularioShoppingDetail(IconMenuItem menuShoppingDetails, Form frmShoppingDetail)
        {
            menuShoppingDetails.BackColor = Color.WhiteSmoke;
            menuShopping.ForeColor = Color.SteelBlue;
            MenuActivo = menuShoppingDetails;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = frmShoppingDetail;
            frmShoppingDetail.TopLevel = false;
            frmShoppingDetail.FormBorderStyle = FormBorderStyle.None;
            frmShoppingDetail.Dock = DockStyle.Fill;
            frmShoppingDetail.BackColor = Color.WhiteSmoke;

            //Manejador Para Cambiar El color Al Cerrar El Formulario
            frmShoppingDetail.FormClosed += (s, e) =>
            {
                menuShopping.ForeColor = Color.Black;
            };

            Contenedor.Controls.Add(frmShoppingDetail);
            frmShoppingDetail.Show();
           
        }

        private void lblRolLogin_Click(object sender, EventArgs e)
        {
        }
    }

}