namespace JKH
{
    partial class FormSendBid
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
            this.components = new System.ComponentModel.Container();
            this.textBox_Тема = new System.Windows.Forms.TextBox();
            this.Тема = new System.Windows.Forms.Label();
            this.ОписаниеЗаявки = new System.Windows.Forms.Label();
            this.richTextBox_Описание = new System.Windows.Forms.RichTextBox();
            this.button_ОтправитьЗаявку = new System.Windows.Forms.Button();
            this.jKHDataSet = new JKH.JKHDataSet();
            this.bidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bidTableAdapter = new JKH.JKHDataSetTableAdapters.BidTableAdapter();
            this.tableAdapterManager = new JKH.JKHDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.jKHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Тема
            // 
            this.textBox_Тема.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Тема.Location = new System.Drawing.Point(212, 84);
            this.textBox_Тема.Name = "textBox_Тема";
            this.textBox_Тема.Size = new System.Drawing.Size(394, 30);
            this.textBox_Тема.TabIndex = 1;
            // 
            // Тема
            // 
            this.Тема.AutoSize = true;
            this.Тема.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Тема.Location = new System.Drawing.Point(207, 37);
            this.Тема.Name = "Тема";
            this.Тема.Size = new System.Drawing.Size(203, 28);
            this.Тема.TabIndex = 8;
            this.Тема.Text = "Введите тему заявки:";
            // 
            // ОписаниеЗаявки
            // 
            this.ОписаниеЗаявки.AutoSize = true;
            this.ОписаниеЗаявки.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ОписаниеЗаявки.Location = new System.Drawing.Point(207, 133);
            this.ОписаниеЗаявки.Name = "ОписаниеЗаявки";
            this.ОписаниеЗаявки.Size = new System.Drawing.Size(250, 28);
            this.ОписаниеЗаявки.TabIndex = 9;
            this.ОписаниеЗаявки.Text = "Введите описание заявки:";
            // 
            // richTextBox_Описание
            // 
            this.richTextBox_Описание.Location = new System.Drawing.Point(212, 174);
            this.richTextBox_Описание.Name = "richTextBox_Описание";
            this.richTextBox_Описание.Size = new System.Drawing.Size(394, 133);
            this.richTextBox_Описание.TabIndex = 10;
            this.richTextBox_Описание.Text = "";
            // 
            // button_ОтправитьЗаявку
            // 
            this.button_ОтправитьЗаявку.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ОтправитьЗаявку.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ОтправитьЗаявку.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ОтправитьЗаявку.Location = new System.Drawing.Point(334, 337);
            this.button_ОтправитьЗаявку.Name = "button_ОтправитьЗаявку";
            this.button_ОтправитьЗаявку.Size = new System.Drawing.Size(155, 64);
            this.button_ОтправитьЗаявку.TabIndex = 13;
            this.button_ОтправитьЗаявку.Text = "Отправить заявку";
            this.button_ОтправитьЗаявку.UseVisualStyleBackColor = false;
            this.button_ОтправитьЗаявку.Click += new System.EventHandler(this.button_Отправить_Click);
            // 
            // jKHDataSet
            // 
            this.jKHDataSet.DataSetName = "JKHDataSet";
            this.jKHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bidBindingSource
            // 
            this.bidBindingSource.DataMember = "Bid";
            this.bidBindingSource.DataSource = this.jKHDataSet;
            // 
            // bidTableAdapter
            // 
            this.bidTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.ApartmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BidTableAdapter = this.bidTableAdapter;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JKH.JKHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // FormSendBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ОтправитьЗаявку);
            this.Controls.Add(this.richTextBox_Описание);
            this.Controls.Add(this.ОписаниеЗаявки);
            this.Controls.Add(this.Тема);
            this.Controls.Add(this.textBox_Тема);
            this.Name = "FormSendBid";
            this.Text = "Форма для заявок";
            this.Load += new System.EventHandler(this.FormSendBid_Load);
            this.Click += new System.EventHandler(this.button_Отмена_Click);
            ((System.ComponentModel.ISupportInitialize)(this.jKHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bidBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Тема;
        private System.Windows.Forms.Label Тема;
        private System.Windows.Forms.Label ОписаниеЗаявки;
        private System.Windows.Forms.RichTextBox richTextBox_Описание;
        private System.Windows.Forms.Button button_ОтправитьЗаявку;
        private JKHDataSet jKHDataSet;
        private System.Windows.Forms.BindingSource bidBindingSource;
        private JKHDataSetTableAdapters.BidTableAdapter bidTableAdapter;
        private JKHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}