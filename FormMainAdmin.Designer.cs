namespace JKH
{
    partial class FormMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
            this.label_ФИО = new System.Windows.Forms.Label();
            this.button_СоздатьНовость = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.мойПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеЗаявкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.управлениеПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ФИО
            // 
            this.label_ФИО.AutoSize = true;
            this.label_ФИО.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ФИО.Location = new System.Drawing.Point(388, 45);
            this.label_ФИО.Name = "label_ФИО";
            this.label_ФИО.Size = new System.Drawing.Size(65, 28);
            this.label_ФИО.TabIndex = 10;
            this.label_ФИО.Text = "label1";
            // 
            // button_СоздатьНовость
            // 
            this.button_СоздатьНовость.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_СоздатьНовость.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_СоздатьНовость.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_СоздатьНовость.Location = new System.Drawing.Point(393, 104);
            this.button_СоздатьНовость.Name = "button_СоздатьНовость";
            this.button_СоздатьНовость.Size = new System.Drawing.Size(155, 64);
            this.button_СоздатьНовость.TabIndex = 7;
            this.button_СоздатьНовость.Text = "Создать новость";
            this.button_СоздатьНовость.UseVisualStyleBackColor = false;
            this.button_СоздатьНовость.Click += new System.EventHandler(this.button_СоздатьНовость_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мойПрофильToolStripMenuItem,
            this.управлениеЗаявкамиToolStripMenuItem,
            this.управлениеПользователямиToolStripMenuItem,
            this.новостиToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(312, 450);
            this.menuStripMain.TabIndex = 6;
            this.menuStripMain.Text = "Меню";
            // 
            // мойПрофильToolStripMenuItem
            // 
            this.мойПрофильToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.мойПрофильToolStripMenuItem.Name = "мойПрофильToolStripMenuItem";
            this.мойПрофильToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.мойПрофильToolStripMenuItem.Text = "Мой профиль";
            this.мойПрофильToolStripMenuItem.Click += new System.EventHandler(this.мойПрофильToolStripMenuItem_Click);
            // 
            // управлениеЗаявкамиToolStripMenuItem
            // 
            this.управлениеЗаявкамиToolStripMenuItem.Name = "управлениеЗаявкамиToolStripMenuItem";
            this.управлениеЗаявкамиToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.управлениеЗаявкамиToolStripMenuItem.Text = "Управление заявками";
            this.управлениеЗаявкамиToolStripMenuItem.Click += new System.EventHandler(this.управлениеЗаявкамиToolStripMenuItem_Click);
            // 
            // новостиToolStripMenuItem
            // 
            this.новостиToolStripMenuItem.Name = "новостиToolStripMenuItem";
            this.новостиToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.новостиToolStripMenuItem.Text = "Новости";
            this.новостиToolStripMenuItem.Click += new System.EventHandler(this.новостиToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripMain.Location = new System.Drawing.Point(312, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(488, 27);
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "О программе";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // управлениеПользователямиToolStripMenuItem
            // 
            this.управлениеПользователямиToolStripMenuItem.Name = "управлениеПользователямиToolStripMenuItem";
            this.управлениеПользователямиToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.управлениеПользователямиToolStripMenuItem.Text = "Управление пользователями";
            this.управлениеПользователямиToolStripMenuItem.Click += new System.EventHandler(this.управлениеПользователямиToolStripMenuItem_Click);
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.label_ФИО);
            this.Controls.Add(this.button_СоздатьНовость);
            this.Controls.Add(this.menuStripMain);
            this.Name = "FormMainAdmin";
            this.Text = "Главная страница администратора";
            this.Load += new System.EventHandler(this.FormMainAdmin_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ФИО;
        private System.Windows.Forms.Button button_СоздатьНовость;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem мойПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеЗаявкамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem управлениеПользователямиToolStripMenuItem;
    }
}