namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.Administrador = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategory = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProduct = new FontAwesome.Sharp.IconMenuItem();
            this.Ventas = new FontAwesome.Sharp.IconMenuItem();
            this.Shopping = new FontAwesome.Sharp.IconMenuItem();
            this.Clients = new FontAwesome.Sharp.IconMenuItem();
            this.Proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.Reportes = new FontAwesome.Sharp.IconMenuItem();
            this.MiGitHub = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ipbMinimizate = new FontAwesome.Sharp.IconPictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMinimizate)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Administrador,
            this.Ventas,
            this.Shopping,
            this.Clients,
            this.Proveedores,
            this.Reportes,
            this.MiGitHub});
            this.menu.Location = new System.Drawing.Point(0, 65);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(873, 74);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // Usuarios
            // 
            this.Usuarios.AutoSize = false;
            this.Usuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.Usuarios.IconColor = System.Drawing.Color.Black;
            this.Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Usuarios.IconSize = 50;
            this.Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(100, 70);
            this.Usuarios.Text = "Users";
            this.Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Administrador
            // 
            this.Administrador.AutoSize = false;
            this.Administrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategory,
            this.subMenuProduct});
            this.Administrador.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.Administrador.IconColor = System.Drawing.Color.Black;
            this.Administrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Administrador.IconSize = 50;
            this.Administrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(100, 70);
            this.Administrador.Text = "Administrator";
            this.Administrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Administrador.Click += new System.EventHandler(this.Administrador_Click);
            // 
            // subMenuCategory
            // 
            this.subMenuCategory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategory.IconColor = System.Drawing.Color.Black;
            this.subMenuCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategory.Name = "subMenuCategory";
            this.subMenuCategory.Size = new System.Drawing.Size(122, 22);
            this.subMenuCategory.Text = "Category";
            this.subMenuCategory.Click += new System.EventHandler(this.subMenuCategory_Click);
            // 
            // subMenuProduct
            // 
            this.subMenuProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProduct.IconColor = System.Drawing.Color.Black;
            this.subMenuProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProduct.Name = "subMenuProduct";
            this.subMenuProduct.Size = new System.Drawing.Size(122, 22);
            this.subMenuProduct.Text = "Product";
            this.subMenuProduct.Click += new System.EventHandler(this.subMenuProduct_Click);
            // 
            // Ventas
            // 
            this.Ventas.AutoSize = false;
            this.Ventas.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.Ventas.IconColor = System.Drawing.Color.Black;
            this.Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ventas.IconSize = 50;
            this.Ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(100, 70);
            this.Ventas.Text = "Sales";
            this.Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // Shopping
            // 
            this.Shopping.AutoSize = false;
            this.Shopping.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.Shopping.IconColor = System.Drawing.Color.Black;
            this.Shopping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Shopping.IconSize = 50;
            this.Shopping.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Shopping.Name = "Shopping";
            this.Shopping.Size = new System.Drawing.Size(100, 70);
            this.Shopping.Text = "Shopping";
            this.Shopping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Shopping.Click += new System.EventHandler(this.Compras_Click);
            // 
            // Clients
            // 
            this.Clients.AutoSize = false;
            this.Clients.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.Clients.IconColor = System.Drawing.Color.Black;
            this.Clients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clients.IconSize = 50;
            this.Clients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(100, 70);
            this.Clients.Text = "Clients";
            this.Clients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Clients.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.AutoSize = false;
            this.Proveedores.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.Proveedores.IconColor = System.Drawing.Color.Black;
            this.Proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Proveedores.IconSize = 50;
            this.Proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(100, 70);
            this.Proveedores.Text = "Suppliers";
            this.Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // Reportes
            // 
            this.Reportes.AutoSize = false;
            this.Reportes.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.Reportes.IconColor = System.Drawing.Color.Black;
            this.Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportes.IconSize = 50;
            this.Reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(122, 70);
            this.Reportes.Text = "Reports";
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // MiGitHub
            // 
            this.MiGitHub.AutoSize = false;
            this.MiGitHub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.MiGitHub.IconColor = System.Drawing.Color.Black;
            this.MiGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MiGitHub.IconSize = 50;
            this.MiGitHub.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MiGitHub.Name = "MiGitHub";
            this.MiGitHub.Size = new System.Drawing.Size(122, 70);
            this.MiGitHub.Text = "My GitHub";
            this.MiGitHub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MiGitHub.Click += new System.EventHandler(this.MiGitHub_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(873, 65);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuTitulo";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuTitulo_ItemClicked);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.SteelBlue;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label.Location = new System.Drawing.Point(12, 7);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(150, 31);
            this.label.TabIndex = 2;
            this.label.Text = "Kwik E Mar";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 139);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(873, 333);
            this.Contenedor.TabIndex = 3;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Azure;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Azure;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 23;
            this.iconPictureBox1.Location = new System.Drawing.Point(26, 41);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(23, 23);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUsuarioLogin.Location = new System.Drawing.Point(49, 44);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(10, 13);
            this.lblUsuarioLogin.TabIndex = 5;
            this.lblUsuarioLogin.Text = ":";
            this.lblUsuarioLogin.Click += new System.EventHandler(this.lblUsuarioLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ForeColor = System.Drawing.Color.Azure;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnExit.IconColor = System.Drawing.Color.Azure;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 18;
            this.btnExit.Location = new System.Drawing.Point(829, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 18);
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Azure;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Azure;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 20;
            this.iconPictureBox2.Location = new System.Drawing.Point(793, 18);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox2.TabIndex = 13;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // ipbMinimizate
            // 
            this.ipbMinimizate.BackColor = System.Drawing.Color.SteelBlue;
            this.ipbMinimizate.ForeColor = System.Drawing.Color.Azure;
            this.ipbMinimizate.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ipbMinimizate.IconColor = System.Drawing.Color.Azure;
            this.ipbMinimizate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbMinimizate.IconSize = 20;
            this.ipbMinimizate.Location = new System.Drawing.Point(755, 13);
            this.ipbMinimizate.Name = "ipbMinimizate";
            this.ipbMinimizate.Size = new System.Drawing.Size(20, 20);
            this.ipbMinimizate.TabIndex = 14;
            this.ipbMinimizate.TabStop = false;
            this.ipbMinimizate.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 472);
            this.Controls.Add(this.ipbMinimizate);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales System";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMinimizate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label;
        private FontAwesome.Sharp.IconMenuItem MiGitHub;
        private FontAwesome.Sharp.IconMenuItem Administrador;
        private FontAwesome.Sharp.IconMenuItem Ventas;
        private FontAwesome.Sharp.IconMenuItem Shopping;
        private FontAwesome.Sharp.IconMenuItem Clients;
        private FontAwesome.Sharp.IconMenuItem Proveedores;
        private FontAwesome.Sharp.IconMenuItem Reportes;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ipbMinimizate;
        private FontAwesome.Sharp.IconMenuItem Usuarios;
        private FontAwesome.Sharp.IconMenuItem subMenuCategory;
        private FontAwesome.Sharp.IconMenuItem subMenuProduct;
    }
}

