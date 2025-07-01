namespace JKH
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBox_Логин = new System.Windows.Forms.TextBox();
            this.Вход = new System.Windows.Forms.Label();
            this.textBox_Пароль = new System.Windows.Forms.TextBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Вход = new System.Windows.Forms.Button();
            this.button_НачальнаяСтраница = new System.Windows.Forms.Button();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Логин
            // 
            this.textBox_Логин.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Логин.Location = new System.Drawing.Point(304, 157);
            this.textBox_Логин.Name = "textBox_Логин";
            this.textBox_Логин.Size = new System.Drawing.Size(209, 30);
            this.textBox_Логин.TabIndex = 0;
            this.textBox_Логин.Text = "Логин";
            // 
            // Вход
            // 
            this.Вход.AutoSize = true;
            this.Вход.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Вход.Location = new System.Drawing.Point(357, 115);
            this.Вход.Name = "Вход";
            this.Вход.Size = new System.Drawing.Size(85, 28);
            this.Вход.TabIndex = 7;
            this.Вход.Text = "Введите";
            // 
            // textBox_Пароль
            // 
            this.textBox_Пароль.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Пароль.Location = new System.Drawing.Point(304, 206);
            this.textBox_Пароль.Name = "textBox_Пароль";
            this.textBox_Пароль.Size = new System.Drawing.Size(209, 30);
            this.textBox_Пароль.TabIndex = 8;
            this.textBox_Пароль.Text = "Пароль";
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
            this.toolStripMain.TabIndex = 9;
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
            this.контактнаяИнформацияToolStripMenuItem.Click += new System.EventHandler(this.контактнаяИнформацияToolStripMenuItem_Click);
            // 
            // button_Вход
            // 
            this.button_Вход.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Вход.Location = new System.Drawing.Point(322, 261);
            this.button_Вход.Name = "button_Вход";
            this.button_Вход.Size = new System.Drawing.Size(165, 35);
            this.button_Вход.TabIndex = 10;
            this.button_Вход.Text = "Войти";
            this.button_Вход.UseVisualStyleBackColor = true;
            this.button_Вход.Click += new System.EventHandler(this.button_Войти_Click);
            // 
            // button_НачальнаяСтраница
            // 
            this.button_НачальнаяСтраница.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_НачальнаяСтраница.Location = new System.Drawing.Point(322, 302);
            this.button_НачальнаяСтраница.Name = "button_НачальнаяСтраница";
            this.button_НачальнаяСтраница.Size = new System.Drawing.Size(165, 35);
            this.button_НачальнаяСтраница.TabIndex = 11;
            this.button_НачальнаяСтраница.Text = "Назад";
            this.button_НачальнаяСтраница.UseVisualStyleBackColor = true;
            this.button_НачальнаяСтраница.Click += new System.EventHandler(this.button_Отмена_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_НачальнаяСтраница);
            this.Controls.Add(this.button_Вход);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.textBox_Пароль);
            this.Controls.Add(this.Вход);
            this.Controls.Add(this.textBox_Логин);
            this.Name = "FormLogin";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Логин;
        private System.Windows.Forms.Label Вход;
        private System.Windows.Forms.TextBox textBox_Пароль;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.Button button_Вход;
        private System.Windows.Forms.Button button_НачальнаяСтраница;
    }
}