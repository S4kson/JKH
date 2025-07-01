namespace JKH
{
    partial class FormBidAdmin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewBids;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelButtons;

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
            this.dataGridViewBids = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBids)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBids
            // 
            this.dataGridViewBids.AllowUserToAddRows = false;
            this.dataGridViewBids.AllowUserToDeleteRows = false;
            this.dataGridViewBids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBids.Location = new System.Drawing.Point(16, 62);
            this.dataGridViewBids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewBids.Name = "dataGridViewBids";
            this.dataGridViewBids.RowHeadersWidth = 51;
            this.dataGridViewBids.Size = new System.Drawing.Size(1200, 492);
            this.dataGridViewBids.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Location = new System.Drawing.Point(13, 12);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(160, 43);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.Location = new System.Drawing.Point(187, 12);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(160, 43);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClose.Location = new System.Drawing.Point(360, 12);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(160, 43);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(16, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(294, 29);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Управление заявками";
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.buttonSave);
            this.panelButtons.Controls.Add(this.buttonRefresh);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Location = new System.Drawing.Point(16, 566);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1200, 68);
            this.panelButtons.TabIndex = 5;
            // 
            // FormBidAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1232, 649);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewBids);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "FormBidAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление заявками";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBids)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}