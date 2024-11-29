namespace CapaPresentacion
{
    partial class frmSalesDetail
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
            this.lblSaleDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaleDetail
            // 
            this.lblSaleDetail.AutoSize = true;
            this.lblSaleDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDetail.Location = new System.Drawing.Point(12, 9);
            this.lblSaleDetail.Name = "lblSaleDetail";
            this.lblSaleDetail.Size = new System.Drawing.Size(327, 31);
            this.lblSaleDetail.TabIndex = 1;
            this.lblSaleDetail.Text = "This Is Form Sale Detail";
            // 
            // SaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaleDetail);
            this.Name = "SaleDetail";
            this.Text = "SaleDetail";
            this.Load += new System.EventHandler(this.SaleDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaleDetail;
    }
}