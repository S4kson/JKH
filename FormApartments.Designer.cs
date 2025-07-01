namespace JKH
{
    partial class FormApartments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvApartments = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApartments
            // 
            this.dgvApartments.AllowUserToAddRows = false;
            this.dgvApartments.AllowUserToDeleteRows = false;
            this.dgvApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApartments.Location = new System.Drawing.Point(16, 15);
            this.dgvApartments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApartments.Name = "dgvApartments";
            this.dgvApartments.ReadOnly = true;
            this.dgvApartments.RowHeadersWidth = 51;
            this.dgvApartments.Size = new System.Drawing.Size(1013, 492);
            this.dgvApartments.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(896, 514);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvApartments);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormApartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Моя недвижимость";
            this.Load += new System.EventHandler(this.FormApartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApartments)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvApartments;
        private System.Windows.Forms.Button btnClose;
    }
}