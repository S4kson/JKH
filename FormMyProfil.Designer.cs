namespace JKH
{
    partial class FormMyProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMyProfil));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Фио = new System.Windows.Forms.Label();
            this.textBox_МоеФИО = new System.Windows.Forms.TextBox();
            this.textBox_МойНомерТелефона = new System.Windows.Forms.TextBox();
            this.jKHDataSet = new JKH.JKHDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new JKH.JKHDataSetTableAdapters.AdminTableAdapter();
            this.tableAdapterManager = new JKH.JKHDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ИзменитьПрофиль = new System.Windows.Forms.Button();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jKHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripDropDownButton1});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 27);
            this.toolStripMain.TabIndex = 11;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Выход из программы";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "О программе";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.руководствоПользователяToolStripMenuItem,
            this.контактнаяИнформацияToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            this.руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            this.руководствоПользователяToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            // 
            // контактнаяИнформацияToolStripMenuItem
            // 
            this.контактнаяИнформацияToolStripMenuItem.Name = "контактнаяИнформацияToolStripMenuItem";
            this.контактнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.контактнаяИнформацияToolStripMenuItem.Text = "Контактная информация";
            // 
            // Фио
            // 
            this.Фио.AutoSize = true;
            this.Фио.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Фио.Location = new System.Drawing.Point(234, 87);
            this.Фио.Name = "Фио";
            this.Фио.Size = new System.Drawing.Size(113, 28);
            this.Фио.TabIndex = 13;
            this.Фио.Text = "Ваше ФИО:";
            // 
            // textBox_МоеФИО
            // 
            this.textBox_МоеФИО.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_МоеФИО.Location = new System.Drawing.Point(239, 128);
            this.textBox_МоеФИО.Name = "textBox_МоеФИО";
            this.textBox_МоеФИО.Size = new System.Drawing.Size(334, 30);
            this.textBox_МоеФИО.TabIndex = 12;
            // 
            // textBox_МойНомерТелефона
            // 
            this.textBox_МойНомерТелефона.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_МойНомерТелефона.Location = new System.Drawing.Point(239, 216);
            this.textBox_МойНомерТелефона.Name = "textBox_МойНомерТелефона";
            this.textBox_МойНомерТелефона.Size = new System.Drawing.Size(334, 30);
            this.textBox_МойНомерТелефона.TabIndex = 14;
            // 
            // jKHDataSet
            // 
            this.jKHDataSet.DataSetName = "JKHDataSet";
            this.jKHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.jKHDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = this.adminTableAdapter;
            this.tableAdapterManager.ApartmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BidTableAdapter = null;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JKH.JKHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ваш номер телефона:";
            // 
            // button_ИзменитьПрофиль
            // 
            this.button_ИзменитьПрофиль.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ИзменитьПрофиль.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ИзменитьПрофиль.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ИзменитьПрофиль.Location = new System.Drawing.Point(333, 276);
            this.button_ИзменитьПрофиль.Name = "button_ИзменитьПрофиль";
            this.button_ИзменитьПрофиль.Size = new System.Drawing.Size(155, 64);
            this.button_ИзменитьПрофиль.TabIndex = 17;
            this.button_ИзменитьПрофиль.Text = "Записать новые данные";
            this.button_ИзменитьПрофиль.UseVisualStyleBackColor = false;
            this.button_ИзменитьПрофиль.Click += new System.EventHandler(this.button_ИзменитьПрофиль_Click);
            // 
            // FormMyProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ИзменитьПрофиль);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_МойНомерТелефона);
            this.Controls.Add(this.Фио);
            this.Controls.Add(this.textBox_МоеФИО);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormMyProfil";
            this.Text = "Мой профиль";
            this.Load += new System.EventHandler(this.FormMyProfil_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jKHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.Label Фио;
        private System.Windows.Forms.TextBox textBox_МоеФИО;
        private System.Windows.Forms.TextBox textBox_МойНомерТелефона;
        private JKHDataSet jKHDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private JKHDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private JKHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ИзменитьПрофиль;
    }
}