namespace JKH
{
    partial class FormNewsUser
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewNews;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefresh;

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
            this.dataGridViewNews = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNews)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNews
            // 
            this.dataGridViewNews.AllowUserToAddRows = false;
            this.dataGridViewNews.AllowUserToDeleteRows = false;
            this.dataGridViewNews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNews.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNews.Location = new System.Drawing.Point(16, 62);
            this.dataGridViewNews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewNews.Name = "dataGridViewNews";
            this.dataGridViewNews.ReadOnly = true;
            this.dataGridViewNews.RowHeadersVisible = false;
            this.dataGridViewNews.RowHeadersWidth = 51;
            this.dataGridViewNews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNews.Size = new System.Drawing.Size(807, 195);
            this.dataGridViewNews.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClose.Location = new System.Drawing.Point(690, 263);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 37);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.Location = new System.Drawing.Point(549, 263);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(133, 37);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(16, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 31);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Новости ";
            // 
            // FormNewsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 313);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewNews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewsUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новости";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
    }
}