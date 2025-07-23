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
            this.iconOption = new FontAwesome.Sharp.IconPictureBox();
            this.labelPages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconOption)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(-2, 0);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(876, 467);
            this.dataGridViewUsuarios.TabIndex = 1;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // menuBarraInferior
            // 
            this.menuBarraInferior.AutoSize = false;
            this.menuBarraInferior.BackColor = System.Drawing.Color.SteelBlue;
            this.menuBarraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBarraInferior.Location = new System.Drawing.Point(0, 444);
            this.menuBarraInferior.Name = "menuBarraInferior";
            this.menuBarraInferior.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuBarraInferior.Size = new System.Drawing.Size(870, 58);
            this.menuBarraInferior.TabIndex = 16;
            this.menuBarraInferior.Text = "menuStrip1";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiguiente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btnSiguiente.IconColor = System.Drawing.Color.Black;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 15;
            this.btnSiguiente.Location = new System.Drawing.Point(149, 472);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(15, 15);
            this.btnSiguiente.TabIndex = 20;
            this.btnSiguiente.TabStop = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnAnterior.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnAnterior.IconColor = System.Drawing.Color.Black;
            this.btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnterior.IconSize = 15;
            this.btnAnterior.Location = new System.Drawing.Point(88, 472);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(15, 15);
            this.btnAnterior.TabIndex = 19;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.iconPictureBox4_Click);
            // 
            // iconOption
            // 
            this.iconOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconOption.BackColor = System.Drawing.Color.SteelBlue;
            this.iconOption.ForeColor = System.Drawing.Color.Black;
            this.iconOption.IconChar = FontAwesome.Sharp.IconChar.Asymmetrik;
            this.iconOption.IconColor = System.Drawing.Color.Black;
            this.iconOption.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOption.IconSize = 70;
            this.iconOption.Location = new System.Drawing.Point(14, 444);
            this.iconOption.Name = "iconOption";
            this.iconOption.Size = new System.Drawing.Size(70, 70);
            this.iconOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconOption.TabIndex = 22;
            this.iconOption.TabStop = false;
            // 
            // labelPages
            // 
            this.labelPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPages.AutoSize = true;
            this.labelPages.BackColor = System.Drawing.Color.SteelBlue;
            this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPages.Location = new System.Drawing.Point(114, 472);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(20, 13);
            this.labelPages.TabIndex = 15;
            this.labelPages.Text = "Pg";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 502);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.iconOption);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.menuBarraInferior);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.MenuStrip menuBarraInferior;
        private FontAwesome.Sharp.IconPictureBox btnSiguiente;
        private FontAwesome.Sharp.IconPictureBox btnAnterior;
        private FontAwesome.Sharp.IconPictureBox iconOption;
        private System.Windows.Forms.Label labelPages;
    }
}