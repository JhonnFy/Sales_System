using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//Referencia
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class LoginV2 : Form
    {
        public LoginV2()
        {
            InitializeComponent();
        }

        //Funcionalidad Mover Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (lblDni.Text == "Document Number")
            {
                lblDni.Text = "";
                lblDni.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (lblDni.Text == "")
            {
                lblDni.Text = "Document Number";
                lblDni.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (lblPassword.Text == "User Password")
            {
                lblPassword.Text = "";
                lblPassword.ForeColor = Color.LightGray;
                lblPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (lblPassword.Text == "")
            {
                lblPassword.Text = "User Password";
                lblPassword.ForeColor = Color.DimGray;
                lblPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            
        }

        private void pcbexit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginV2_Load(object sender, EventArgs e)
        {

        }

        private void LoginV2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Evento Click Login
        private void btnLogin_Click(object sender, EventArgs e)
        {

            List<Usuario> objTest = new CN_Usuario().Listar();

            //Expresion lamda para conexion
            Usuario objUsuario = new CN_Usuario().Listar().Where(u => u.Documento == lblDni.Text && u.Clave == lblPassword.Text).FirstOrDefault();
            

            //Control Iterador
            if (objUsuario != null)
            {

                // Obtener el objeto Rol relacionado con el usuario 
                Rol objRol = new CN_DescripcionRol().Listar(objUsuario.IdUsuario).FirstOrDefault();


                // Se crea la instancia del formulario Inicio
                Inicio formInicio = new Inicio(objUsuario, objRol);



                // Muestra el nuevo formulario y oculta el actual
                formInicio.Show();
                this.Hide();

                // Suscribe al evento FormClosed en lugar de FormClosing
                formInicio.FormClosed += FormInicio_FormClosed;

            }
            else
            {
                lblDni.Text = "Document Number";
                lblDni.ForeColor = Color.LightGray;
                lblDni.Focus();

                lblPassword.Text = "User Password";
                lblPassword.ForeColor = ColorTranslator.FromHtml("#888888");
                lblPassword.UseSystemPasswordChar = false;
                
                AlertExito objAlertExito = new AlertExito();
                objAlertExito.ShowDialog();

                //MessageBox.Show("The User Cannot Be Found in the DB", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Cierre Del Metodo

        private void FormInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Muestra el formulario actual nuevamente
            this.Show();

            //Itera para consultar 
            if (!string.IsNullOrEmpty(lblDni.Text))
            {
                lblDni.Text = "Document Number";
                lblDni.ForeColor = ColorTranslator.FromHtml("#888888");

                //Cursor Sobre Este Input
                lblDni.Focus();
            }

            if (!string.IsNullOrEmpty(lblPassword.Text))
            {
                lblPassword.Text = "User Password";
                lblPassword.ForeColor = ColorTranslator.FromHtml("#888888");
                lblPassword.UseSystemPasswordChar = false;
            }

        }//Metodo

    }
}
