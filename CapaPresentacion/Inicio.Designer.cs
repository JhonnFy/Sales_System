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
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label = new System.Windows.Forms.Label();
            this.MiGitHub = new FontAwesome.Sharp.IconMenuItem();
            this.Reportes = new FontAwesome.Sharp.IconMenuItem();
            this.Proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.Clientes = new FontAwesome.Sharp.IconMenuItem();
            this.Compras = new FontAwesome.Sharp.IconMenuItem();
            this.Ventas = new FontAwesome.Sharp.IconMenuItem();
            this.Administrador = new FontAwesome.Sharp.IconMenuItem();
            this.Usuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuarios,
            this.Administrador,
            this.Ventas,
            this.Compras,
            this.Clientes,
            this.Proveedores,
            this.Reportes,
            this.MiGitHub});
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(873, 74);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(873, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuTitulo";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.SteelBlue;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(246, 31);
            this.label.TabIndex = 2;
            this.label.Text = "Sistema De Ventas";
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
            this.MiGitHub.Text = "Mi GitHub";
            this.MiGitHub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.Reportes.Text = "Reportes";
            this.Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Clientes
            // 
            this.Clientes.AutoSize = false;
            this.Clientes.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.Clientes.IconColor = System.Drawing.Color.Black;
            this.Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clientes.IconSize = 50;
            this.Clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(100, 70);
            this.Clientes.Text = "Clientes";
            this.Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Compras
            // 
            this.Compras.AutoSize = false;
            this.Compras.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.Compras.IconColor = System.Drawing.Color.Black;
            this.Compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Compras.IconSize = 50;
            this.Compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(100, 70);
            this.Compras.Text = "Compras";
            this.Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.Ventas.Text = "Ventas";
            this.Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Administrador
            // 
            this.Administrador.AutoSize = false;
            this.Administrador.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.Administrador.IconColor = System.Drawing.Color.Black;
            this.Administrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Administrador.IconSize = 50;
            this.Administrador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(100, 70);
            this.Administrador.Text = "Administrador";
            this.Administrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Usuarios
            // 
            this.Usuarios.AutoSize = false;
            this.Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.Usuarios.IconColor = System.Drawing.Color.Black;
            this.Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Usuarios.IconSize = 50;
            this.Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(100, 70);
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 364);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label;
        private FontAwesome.Sharp.IconMenuItem MiGitHub;
        private FontAwesome.Sharp.IconMenuItem Usuarios;
        private FontAwesome.Sharp.IconMenuItem Administrador;
        private FontAwesome.Sharp.IconMenuItem Ventas;
        private FontAwesome.Sharp.IconMenuItem Compras;
        private FontAwesome.Sharp.IconMenuItem Clientes;
        private FontAwesome.Sharp.IconMenuItem Proveedores;
        private FontAwesome.Sharp.IconMenuItem Reportes;
    }
}

