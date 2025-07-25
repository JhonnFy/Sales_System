﻿using System;
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

        //---------------------------------------------------------------------------------------------
        //Evento Click subMenuCategory_Click
        //---------------------------------------------------------------------------------------------
        private void subMenuCategory_Click(object sender, EventArgs e)
        {
            AbrirFormularioAdministradorCategorias((IconMenuItem)sender, new frmCategorys());
        }

        //---------------------------------------------------------------------------------------------
        //Activa El Color De Fondo Para El Formulario Administrador-Categoria
        //---------------------------------------------------------------------------------------------
        private void AbrirFormularioAdministradorCategorias(IconMenuItem menuAdmCategoria, Form frmCategorys)
        {
            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Is Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo == null)
            {
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuAdministrator.ForeColor = Color.SteelBlue;
            }

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Not Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuAdministrator.ForeColor = Color.SteelBlue;
            }

            if (FormularioActivo == frmCategorys)
            {
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuAdministrator.ForeColor = Color.SteelBlue;
            }

            FormularioActivo = frmCategorys;
            frmCategorys.TopLevel = false;
            frmCategorys.FormBorderStyle = FormBorderStyle.None;
            frmCategorys.Dock = DockStyle.Fill;
            frmCategorys.BackColor = Color.WhiteSmoke;

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[SubMenu]
            //---------------------------------------------------------------------------------------------
            frmCategorys.FormClosed += (s, e) =>
            {
                menuAdministrator.ForeColor = Color.Black;
            };

            //---------------------------------------------------------------------------------------------
            //frmCategorys.[Open]
            //---------------------------------------------------------------------------------------------
            Contenedor.Controls.Add(frmCategorys);
            frmCategorys.Show();
        }

        //---------------------------------------------------------------------------------------------
        //Evento Click subMenuProduct_Click
        //---------------------------------------------------------------------------------------------
        private void subMenuProduct_Click(object sender, EventArgs e)
        {
            AbrirFormularioAdministradorProductos((IconMenuItem)sender, new frmProducts());
        }

        //---------------------------------------------------------------------------------------------
        //Activa El Color De Fondo Para El Formulario Administrador-Productos
        //---------------------------------------------------------------------------------------------
        private void AbrirFormularioAdministradorProductos(IconMenuItem menuAdmProductos, Form frmProducts)
        {
            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Is Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo == null)
            {
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuAdministrator.ForeColor = Color.SteelBlue;
            }

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Not Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuAdministrator.ForeColor = Color.SteelBlue;
            }

            FormularioActivo = frmProducts;
            frmProducts.TopLevel = false;
            frmProducts.FormBorderStyle = FormBorderStyle.None;
            frmProducts.Dock = DockStyle.Fill;
            frmProducts.BackColor = Color.WhiteSmoke;

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[SubMenu]
            //---------------------------------------------------------------------------------------------
            frmProducts.FormClosed += (s, e) =>
            {
                menuAdministrator.ForeColor = Color.Black;
            };

            //---------------------------------------------------------------------------------------------
            //frmProducts.[Open]
            //---------------------------------------------------------------------------------------------
            Contenedor.Controls.Add(frmProducts);
            frmProducts.Show();

        }


        //---------------------------------------------------------------------------------------------
        //Evento Click subMenuSalesRegister_Click
        //---------------------------------------------------------------------------------------------
        private void subMenuSalesRegister_Click(object sender, EventArgs e)
        {
            AbrirFormularioRegisterSales((IconMenuItem)sender, new frmSalesRegister());
        }

        //---------------------------------------------------------------------------------------------
        //Activa El Color De Fondo Para El Formulario Sales-Register
        //---------------------------------------------------------------------------------------------
        private void AbrirFormularioRegisterSales(IconMenuItem menuSalesRegister, Form frmSalesRegister)
        {
            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Is Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo == null)
            {
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuSales.ForeColor = Color.SteelBlue;
            }

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Not Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuSales.ForeColor = Color.SteelBlue;
            }

            FormularioActivo = frmSalesRegister;
            frmSalesRegister.TopLevel = false;
            frmSalesRegister.FormBorderStyle = FormBorderStyle.None;
            frmSalesRegister.Dock = DockStyle.Fill;
            frmSalesRegister.BackColor = Color.WhiteSmoke;

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[SubMenu]
            //---------------------------------------------------------------------------------------------
            frmSalesRegister.FormClosed += (s, e) =>
            {
                menuSales.ForeColor = Color.Black;
            };

            //---------------------------------------------------------------------------------------------
            //frmSalesRegister.[Open]
            //---------------------------------------------------------------------------------------------
            Contenedor.Controls.Add(frmSalesRegister);
            frmSalesRegister.Show();
        }


        //---------------------------------------------------------------------------------------------
        //Evento Click subMenuSalesDetails_Click
        //---------------------------------------------------------------------------------------------
        private void subMenuSalesDetails_Click(object sender, EventArgs e)
        {
            AbrirFormularioSalesDetail((IconMenuItem)sender, new frmSalesDetail());
        }

        //---------------------------------------------------------------------------------------------
        //Activa El Color De Fondo Para El Formulario Sales-Detail
        //---------------------------------------------------------------------------------------------
        private void AbrirFormularioSalesDetail(IconMenuItem menuSalesDetails, Form frmSalesDetail)
        {

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Is Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo == null)
            {
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuSales.ForeColor = Color.SteelBlue;
            }

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Not Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuSales.ForeColor = Color.SteelBlue;
            }

            FormularioActivo = frmSalesDetail;
            frmSalesDetail.TopLevel = false;
            frmSalesDetail.FormBorderStyle = FormBorderStyle.None;
            frmSalesDetail.Dock = DockStyle.Fill;
            frmSalesDetail.BackColor = Color.WhiteSmoke;

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[SubMenu]
            //---------------------------------------------------------------------------------------------
            frmSalesDetail.FormClosed += (s, e) =>
            {
                menuSales.ForeColor = Color.Black;
            };

            //---------------------------------------------------------------------------------------------
            //frmSalesDetail.[Open]
            //---------------------------------------------------------------------------------------------
            Contenedor.Controls.Add(frmSalesDetail);
            frmSalesDetail.Show();
        }


        //---------------------------------------------------------------------------------------------
        //Evento Click subMenuShoppingRegister_Click
        //---------------------------------------------------------------------------------------------
        private void subShoppingRegister_Click(object sender, EventArgs e)
        {
            AbrirFormularioShoppingRegister((IconMenuItem)sender, new frmShoppingRegister());
        }

        //---------------------------------------------------------------------------------------------
        //Activa El Color De Fondo Para El Formulario Shopping-Register
        //---------------------------------------------------------------------------------------------
        private void AbrirFormularioShoppingRegister(IconMenuItem menuShoppingRegister, Form frmShoppingRegister)
        {
            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Is Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo == null)
            {
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuShopping.ForeColor = Color.SteelBlue;
            }

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Not Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuShopping.ForeColor = Color.SteelBlue;
            }

            FormularioActivo = frmShoppingRegister;
            frmShoppingRegister.TopLevel = false;
            frmShoppingRegister.FormBorderStyle = FormBorderStyle.None;
            frmShoppingRegister.Dock = DockStyle.Fill;
            frmShoppingRegister.BackColor = Color.WhiteSmoke;

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[SubMenu]
            //---------------------------------------------------------------------------------------------
            frmShoppingRegister.FormClosed += (s, e) =>
            {
                menuShopping.ForeColor = Color.Black;
            };

            //---------------------------------------------------------------------------------------------
            //frmShoppingRegister.[Open]
            //---------------------------------------------------------------------------------------------
            Contenedor.Controls.Add(frmShoppingRegister);
            frmShoppingRegister.Show();
        }

        //---------------------------------------------------------------------------------------------
        //Evento Click subMenuShoppingDetail_Click
        //---------------------------------------------------------------------------------------------
        private void subShoppingDetail_Click(object sender, EventArgs e)
        {
            AbrirFormularioShoppingDetail((IconMenuItem)sender, new frmShoppingDetail());
        }

        //---------------------------------------------------------------------------------------------
        //Activa El Color De Fondo Para El Formulario Administrador-Categoria
        //---------------------------------------------------------------------------------------------
        private void AbrirFormularioShoppingDetail(IconMenuItem menuShoppingDetails, Form frmShoppingDetail)
        {
            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Is Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo == null)
            {
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuShopping.ForeColor = Color.SteelBlue;
            }

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[Not Null]
            //---------------------------------------------------------------------------------------------
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                menu.BackColor = Color.WhiteSmoke;
                menu.ForeColor = Color.Black;
                menuShopping.ForeColor = Color.SteelBlue;
            }


            FormularioActivo = frmShoppingDetail;
            frmShoppingDetail.TopLevel = false;
            frmShoppingDetail.FormBorderStyle = FormBorderStyle.None;
            frmShoppingDetail.Dock = DockStyle.Fill;
            frmShoppingDetail.BackColor = Color.WhiteSmoke;

            //---------------------------------------------------------------------------------------------
            //Manejador De Colores.[SubMenu]
            //---------------------------------------------------------------------------------------------
            frmShoppingDetail.FormClosed += (s, e) =>
            {
                menuShopping.ForeColor = Color.Black;
            };

            //---------------------------------------------------------------------------------------------
            //frmShoppingDetail.[Open]
            //---------------------------------------------------------------------------------------------
            Contenedor.Controls.Add(frmShoppingDetail);
            frmShoppingDetail.Show();
           
        }

        private void lblRolLogin_Click(object sender, EventArgs e)
        {
        }

        //BtnAnterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            
        }
    }

}