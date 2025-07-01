namespace JKH
{
    partial class FormReceipt
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewReceipts;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelTitle;

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
            this.dataGridViewReceipts = new System.Windows.Forms.DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReceipts
            // 
            this.dataGridViewReceipts.AllowUserToAddRows = false;
            this.dataGridViewReceipts.AllowUserToDeleteRows = false;
            this.dataGridViewReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipts.Location = new System.Drawing.Point(16, 62);
            this.dataGridViewReceipts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewReceipts.Name = "dataGridViewReceipts";
            this.dataGridViewReceipts.ReadOnly = true;
            this.dataGridViewReceipts.RowHeadersVisible = false;
            this.dataGridViewReceipts.RowHeadersWidth = 51;
            this.dataGridViewReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReceipts.Size = new System.Drawing.Size(747, 308);
            this.dataGridViewReceipts.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(16, 394);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(155, 25);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Статус: Загрузка";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(16, 431);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(226, 23);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Сумма к оплате: 0.00 руб.";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPay.Location = new System.Drawing.Point(467, 394);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(133, 45);
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonClose.Location = new System.Drawing.Point(627, 394);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 45);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.Location = new System.Drawing.Point(627, 18);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(133, 31);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(16, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(169, 28);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Мои квитанции";
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 469);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dataGridViewReceipts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Квитанции";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}