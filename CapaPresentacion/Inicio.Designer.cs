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
            this.menuUser = new FontAwesome.Sharp.IconMenuItem();
            this.menuAdministrator = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategory = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuProduct = new FontAwesome.Sharp.IconMenuItem();
            this.menuSales = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSalesRegister = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuSalesDetails = new FontAwesome.Sharp.IconMenuItem();
            this.menuShopping = new FontAwesome.Sharp.IconMenuItem();
            this.subShoppingRegister = new FontAwesome.Sharp.IconMenuItem();
            this.subShoppingDetail = new FontAwesome.Sharp.IconMenuItem();
            this.menuClients = new FontAwesome.Sharp.IconMenuItem();
            this.menuSuppliers = new FontAwesome.Sharp.IconMenuItem();
            this.menuReports = new FontAwesome.Sharp.IconMenuItem();
            this.menuGitHub = new FontAwesome.Sharp.IconMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ipbMinimizate = new FontAwesome.Sharp.IconPictureBox();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
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
            this.menuUser,
            this.menuAdministrator,
            this.menuSales,
            this.menuShopping,
            this.menuClients,
            this.menuSuppliers,
            this.menuReports,
            this.menuGitHub});
            this.menu.Location = new System.Drawing.Point(0, 65);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(873, 74);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menuUser
            // 
            this.menuUser.AutoSize = false;
            this.menuUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.menuUser.IconColor = System.Drawing.Color.Black;
            this.menuUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUser.IconSize = 50;
            this.menuUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(100, 70);
            this.menuUser.Text = "Users";
            this.menuUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUser.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // menuAdministrator
            // 
            this.menuAdministrator.AutoSize = false;
            this.menuAdministrator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategory,
            this.subMenuProduct});
            this.menuAdministrator.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.menuAdministrator.IconColor = System.Drawing.Color.Black;
            this.menuAdministrator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAdministrator.IconSize = 50;
            this.menuAdministrator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAdministrator.Name = "menuAdministrator";
            this.menuAdministrator.Size = new System.Drawing.Size(100, 70);
            this.menuAdministrator.Text = "Administrator";
            this.menuAdministrator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAdministrator.Click += new System.EventHandler(this.Administrador_Click);
            // 
            // subMenuCategory
            // 
            this.subMenuCategory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategory.IconColor = System.Drawing.Color.Black;
            this.subMenuCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategory.Name = "subMenuCategory";
            this.subMenuCategory.Size = new System.Drawing.Size(180, 22);
            this.subMenuCategory.Text = "Admin Category";
            this.subMenuCategory.Click += new System.EventHandler(this.subMenuCategory_Click);
            // 
            // subMenuProduct
            // 
            this.subMenuProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuProduct.IconColor = System.Drawing.Color.Black;
            this.subMenuProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuProduct.Name = "subMenuProduct";
            this.subMenuProduct.Size = new System.Drawing.Size(180, 22);
            this.subMenuProduct.Text = "Admin Product";
            this.subMenuProduct.Click += new System.EventHandler(this.subMenuProduct_Click);
            // 
            // menuSales
            // 
            this.menuSales.AutoSize = false;
            this.menuSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuSalesRegister,
            this.subMenuSalesDetails});
            this.menuSales.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.menuSales.IconColor = System.Drawing.Color.Black;
            this.menuSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuSales.IconSize = 50;
            this.menuSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSales.Name = "menuSales";
            this.menuSales.Size = new System.Drawing.Size(100, 70);
            this.menuSales.Text = "Sales";
            this.menuSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuSales.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // subMenuSalesRegister
            // 
            this.subMenuSalesRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSalesRegister.IconColor = System.Drawing.Color.Black;
            this.subMenuSalesRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSalesRegister.Name = "subMenuSalesRegister";
            this.subMenuSalesRegister.Size = new System.Drawing.Size(180, 22);
            this.subMenuSalesRegister.Text = "Sales Register";
            this.subMenuSalesRegister.Click += new System.EventHandler(this.subMenuSalesRegister_Click);
            // 
            // subMenuSalesDetails
            // 
            this.subMenuSalesDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuSalesDetails.IconColor = System.Drawing.Color.Black;
            this.subMenuSalesDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuSalesDetails.Name = "subMenuSalesDetails";
            this.subMenuSalesDetails.Size = new System.Drawing.Size(180, 22);
            this.subMenuSalesDetails.Text = "Sales Details";
            this.subMenuSalesDetails.Click += new System.EventHandler(this.subMenuSalesDetails_Click);
            // 
            // menuShopping
            // 
            this.menuShopping.AutoSize = false;
            this.menuShopping.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subShoppingRegister,
            this.subShoppingDetail});
            this.menuShopping.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.menuShopping.IconColor = System.Drawing.Color.Black;
            this.menuShopping.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuShopping.IconSize = 50;
            this.menuShopping.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShopping.Name = "menuShopping";
            this.menuShopping.Size = new System.Drawing.Size(100, 70);
            this.menuShopping.Text = "Shopping";
            this.menuShopping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuShopping.Click += new System.EventHandler(this.Compras_Click);
            // 
            // subShoppingRegister
            // 
            this.subShoppingRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subShoppingRegister.IconColor = System.Drawing.Color.Black;
            this.subShoppingRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subShoppingRegister.Name = "subShoppingRegister";
            this.subShoppingRegister.Size = new System.Drawing.Size(170, 22);
            this.subShoppingRegister.Text = "Shopping Register";
            this.subShoppingRegister.Click += new System.EventHandler(this.subShoppingRegister_Click);
            // 
            // subShoppingDetail
            // 
            this.subShoppingDetail.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subShoppingDetail.IconColor = System.Drawing.Color.Black;
            this.subShoppingDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subShoppingDetail.Name = "subShoppingDetail";
            this.subShoppingDetail.Size = new System.Drawing.Size(170, 22);
            this.subShoppingDetail.Text = "Shopping Detail";
            this.subShoppingDetail.Click += new System.EventHandler(this.subShoppingDetail_Click);
            // 
            // menuClients
            // 
            this.menuClients.AutoSize = false;
            this.menuClients.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.menuClients.IconColor = System.Drawing.Color.Black;
            this.menuClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClients.IconSize = 50;
            this.menuClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClients.Name = "menuClients";
            this.menuClients.Size = new System.Drawing.Size(100, 70);
            this.menuClients.Text = "Clients";
            this.menuClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClients.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // menuSuppliers
            // 
            this.menuSuppliers.AutoSize = false;
            this.menuSuppliers.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.menuSuppliers.IconColor = System.Drawing.Color.Black;
            this.menuSuppliers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuSuppliers.IconSize = 50;
            this.menuSuppliers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSuppliers.Name = "menuSuppliers";
            this.menuSuppliers.Size = new System.Drawing.Size(100, 70);
            this.menuSuppliers.Text = "Suppliers";
            this.menuSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuSuppliers.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // menuReports
            // 
            this.menuReports.AutoSize = false;
            this.menuReports.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.menuReports.IconColor = System.Drawing.Color.Black;
            this.menuReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReports.IconSize = 50;
            this.menuReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(122, 70);
            this.menuReports.Text = "Reports";
            this.menuReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuReports.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // menuGitHub
            // 
            this.menuGitHub.AutoSize = false;
            this.menuGitHub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.menuGitHub.IconColor = System.Drawing.Color.Black;
            this.menuGitHub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuGitHub.IconSize = 50;
            this.menuGitHub.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuGitHub.Name = "menuGitHub";
            this.menuGitHub.Size = new System.Drawing.Size(122, 70);
            this.menuGitHub.Text = "My GitHub";
            this.menuGitHub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuGitHub.Click += new System.EventHandler(this.MiGitHub_Click);
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
        private System.Windows.Forms.Label label;
        private FontAwesome.Sharp.IconMenuItem menuGitHub;
        private FontAwesome.Sharp.IconMenuItem menuAdministrator;
        private FontAwesome.Sharp.IconMenuItem menuSales;
        private FontAwesome.Sharp.IconMenuItem menuShopping;
        private FontAwesome.Sharp.IconMenuItem menuClients;
        private FontAwesome.Sharp.IconMenuItem menuSuppliers;
        private FontAwesome.Sharp.IconMenuItem menuReports;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ipbMinimizate;
        private FontAwesome.Sharp.IconMenuItem menuUser;
        private FontAwesome.Sharp.IconMenuItem subMenuCategory;
        private FontAwesome.Sharp.IconMenuItem subMenuProduct;
        private FontAwesome.Sharp.IconMenuItem subMenuSalesRegister;
        private FontAwesome.Sharp.IconMenuItem subMenuSalesDetails;
        private FontAwesome.Sharp.IconMenuItem subShoppingRegister;
        private FontAwesome.Sharp.IconMenuItem subShoppingDetail;
        private System.Windows.Forms.MenuStrip menuTitulo;
    }
}

