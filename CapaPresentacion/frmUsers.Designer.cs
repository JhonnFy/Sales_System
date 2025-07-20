namespace CapaPresentacion
{
    partial class frmUsers
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
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.menuBarraInferior = new System.Windows.Forms.MenuStrip();
            this.btnSiguiente = new FontAwesome.Sharp.IconPictureBox();
            this.btnAnterior = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(-2, 0);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(876, 504);
            this.dataGridViewUsuarios.TabIndex = 1;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // menuBarraInferior
            // 
            this.menuBarraInferior.AutoSize = false;
            this.menuBarraInferior.BackColor = System.Drawing.Color.SteelBlue;
            this.menuBarraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBarraInferior.Location = new System.Drawing.Point(0, 466);
            this.menuBarraInferior.Name = "menuBarraInferior";
            this.menuBarraInferior.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuBarraInferior.Size = new System.Drawing.Size(870, 36);
            this.menuBarraInferior.TabIndex = 16;
            this.menuBarraInferior.Text = "menuStrip1";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiguiente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSiguiente.ForeColor = System.Drawing.Color.Azure;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnSiguiente.IconColor = System.Drawing.Color.Azure;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 23;
            this.btnSiguiente.Location = new System.Drawing.Point(718, 467);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(23, 23);
            this.btnSiguiente.TabIndex = 20;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnterior.ForeColor = System.Drawing.Color.Azure;
            this.btnAnterior.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnAnterior.IconColor = System.Drawing.Color.Azure;
            this.btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnterior.IconSize = 23;
            this.btnAnterior.Location = new System.Drawing.Point(673, 467);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 23);
            this.btnAnterior.TabIndex = 19;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.iconPictureBox4_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Azure;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Azure;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 23;
            this.iconPictureBox3.Location = new System.Drawing.Point(24, 467);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(23, 23);
            this.iconPictureBox3.TabIndex = 18;
            this.iconPictureBox3.TabStop = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 502);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.menuBarraInferior);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.MenuStrip menuBarraInferior;
        private FontAwesome.Sharp.IconPictureBox btnSiguiente;
        private FontAwesome.Sharp.IconPictureBox btnAnterior;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}