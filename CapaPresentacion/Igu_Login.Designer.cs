namespace CapaPresentacion
{
    partial class Igu_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igu_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Document_Number = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Credencial = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Number_Document = new System.Windows.Forms.Label();
            this.User_Credential = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Credencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login in to your account to continue";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Document_Number
            // 
            this.Document_Number.ForeColor = System.Drawing.Color.Transparent;
            this.Document_Number.Location = new System.Drawing.Point(292, 135);
            this.Document_Number.Name = "Document_Number";
            this.Document_Number.Size = new System.Drawing.Size(153, 20);
            this.Document_Number.TabIndex = 4;
            this.Document_Number.Text = "Hola";
            this.Document_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(289, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Hola";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Credencial
            // 
            this.Credencial.BackColor = System.Drawing.Color.Transparent;
            this.Credencial.ForeColor = System.Drawing.Color.DarkGreen;
            this.Credencial.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.Credencial.IconColor = System.Drawing.Color.DarkGreen;
            this.Credencial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Credencial.IconSize = 33;
            this.Credencial.Location = new System.Drawing.Point(257, 135);
            this.Credencial.Name = "Credencial";
            this.Credencial.Size = new System.Drawing.Size(33, 33);
            this.Credencial.TabIndex = 7;
            this.Credencial.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 33;
            this.iconPictureBox1.Location = new System.Drawing.Point(254, 196);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(33, 33);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // Number_Document
            // 
            this.Number_Document.AutoSize = true;
            this.Number_Document.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number_Document.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Document.Location = new System.Drawing.Point(294, 155);
            this.Number_Document.Name = "Number_Document";
            this.Number_Document.Size = new System.Drawing.Size(109, 13);
            this.Number_Document.TabIndex = 9;
            this.Number_Document.Text = "Document Number";
            // 
            // User_Credential
            // 
            this.User_Credential.AutoSize = true;
            this.User_Credential.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_Credential.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Credential.Location = new System.Drawing.Point(291, 216);
            this.User_Credential.Name = "User_Credential";
            this.User_Credential.Size = new System.Drawing.Size(93, 13);
            this.User_Credential.TabIndex = 10;
            this.User_Credential.Text = "User Credential";
            // 
            // Igu_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.User_Credential);
            this.Controls.Add(this.Number_Document);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.Credencial);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Document_Number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Igu_Login";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Igu_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Credencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Document_Number;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox Credencial;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label Number_Document;
        private System.Windows.Forms.Label User_Credential;
    }
}
