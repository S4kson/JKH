namespace JKH
{
    partial class FormBidHistory
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
            this.dgvBidHistory = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBidHistory
            // 
            this.dgvBidHistory.AllowUserToAddRows = false;
            this.dgvBidHistory.AllowUserToDeleteRows = false;
            this.dgvBidHistory.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvBidHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBidHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvBidHistory.Location = new System.Drawing.Point(16, 15);
            this.dgvBidHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBidHistory.Name = "dgvBidHistory";
            this.dgvBidHistory.ReadOnly = true;
            this.dgvBidHistory.RowHeadersWidth = 51;
            this.dgvBidHistory.Size = new System.Drawing.Size(1013, 316);
            this.dgvBidHistory.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(16, 339);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(899, 339);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Комментарий администратора";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // FormBidHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 389);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvBidHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBidHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Мои заявки";
            this.Load += new System.EventHandler(this.FormBidHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBidHistory)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvBidHistory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}