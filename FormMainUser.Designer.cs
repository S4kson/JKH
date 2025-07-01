namespace JKH
{
    partial class FormMainUser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUser));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.мойПрофильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиЗаявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мояНедвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квитанцииИОплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ОплатитьКвитанцию = new System.Windows.Forms.Button();
            this.Заявки = new System.Windows.Forms.Label();
            this.button_ОтправитьЗаявку = new System.Windows.Forms.Button();
            this.label_ФИО = new System.Windows.Forms.Label();
            this.label_СуммаОплаты = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мойПрофильToolStripMenuItem,
            this.моиЗаявкиToolStripMenuItem,
            this.мояНедвижимостьToolStripMenuItem,
            this.квитанцииИОплатаToolStripMenuItem,
            this.новостиToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(226, 450);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "Меню";
            // 
            // мойПрофильToolStripMenuItem
            // 
            this.мойПрофильToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.мойПрофильToolStripMenuItem.Name = "мойПрофильToolStripMenuItem";
            this.мойПрофильToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.мойПрофильToolStripMenuItem.Text = "Мой профиль";
            this.мойПрофильToolStripMenuItem.Click += new System.EventHandler(this.button_МойПрофиль_Click);
            // 
            // моиЗаявкиToolStripMenuItem
            // 
            this.моиЗаявкиToolStripMenuItem.Name = "моиЗаявкиToolStripMenuItem";
            this.моиЗаявкиToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.моиЗаявкиToolStripMenuItem.Text = "Мои заявки";
            this.моиЗаявкиToolStripMenuItem.Click += new System.EventHandler(this.button_МоиЗаявки_Click);
            // 
            // мояНедвижимостьToolStripMenuItem
            // 
            this.мояНедвижимостьToolStripMenuItem.Name = "мояНедвижимостьToolStripMenuItem";
            this.мояНедвижимостьToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.мояНедвижимостьToolStripMenuItem.Text = "Моя недвижимость";
            this.мояНедвижимостьToolStripMenuItem.Click += new System.EventHandler(this.button_МояНедвижимость_Click);
            // 
            // квитанцииИОплатаToolStripMenuItem
            // 
            this.квитанцииИОплатаToolStripMenuItem.Name = "квитанцииИОплатаToolStripMenuItem";
            this.квитанцииИОплатаToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.квитанцииИОплатаToolStripMenuItem.Text = "Квитанции и оплата";
            this.квитанцииИОплатаToolStripMenuItem.Click += new System.EventHandler(this.button_Квитанции_Click);
            // 
            // новостиToolStripMenuItem
            // 
            this.новостиToolStripMenuItem.Name = "новостиToolStripMenuItem";
            this.новостиToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.новостиToolStripMenuItem.Text = "Новости";
            this.новостиToolStripMenuItem.Click += new System.EventHandler(this.button_Новости_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.button_Выйти_Click);
            // 
            // button_ОплатитьКвитанцию
            // 
            this.button_ОплатитьКвитанцию.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ОплатитьКвитанцию.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ОплатитьКвитанцию.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ОплатитьКвитанцию.Location = new System.Drawing.Point(243, 145);
            this.button_ОплатитьКвитанцию.Name = "button_ОплатитьКвитанцию";
            this.button_ОплатитьКвитанцию.Size = new System.Drawing.Size(155, 64);
            this.button_ОплатитьКвитанцию.TabIndex = 1;
            this.button_ОплатитьКвитанцию.Text = "Оплатить квитанцию";
            this.button_ОплатитьКвитанцию.UseVisualStyleBackColor = false;
            this.button_ОплатитьКвитанцию.Click += new System.EventHandler(this.button_ОплатитьКвитанцию_Click);
            // 
            // Заявки
            // 
            this.Заявки.AutoSize = true;
            this.Заявки.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Заявки.Location = new System.Drawing.Point(251, 273);
            this.Заявки.Name = "Заявки";
            this.Заявки.Size = new System.Drawing.Size(76, 28);
            this.Заявки.TabIndex = 2;
            this.Заявки.Text = "Заявки";
            // 
            // button_ОтправитьЗаявку
            // 
            this.button_ОтправитьЗаявку.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_ОтправитьЗаявку.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ОтправитьЗаявку.Location = new System.Drawing.Point(245, 316);
            this.button_ОтправитьЗаявку.Name = "button_ОтправитьЗаявку";
            this.button_ОтправитьЗаявку.Size = new System.Drawing.Size(153, 65);
            this.button_ОтправитьЗаявку.TabIndex = 3;
            this.button_ОтправитьЗаявку.Text = "Создать заявку";
            this.button_ОтправитьЗаявку.UseVisualStyleBackColor = false;
            this.button_ОтправитьЗаявку.Click += new System.EventHandler(this.button_ОтправитьЗаявку_Click);
            // 
            // label_ФИО
            // 
            this.label_ФИО.AutoSize = true;
            this.label_ФИО.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ФИО.Location = new System.Drawing.Point(251, 55);
            this.label_ФИО.Name = "label_ФИО";
            this.label_ФИО.Size = new System.Drawing.Size(65, 28);
            this.label_ФИО.TabIndex = 4;
            this.label_ФИО.Text = "label1";
            this.label_ФИО.Click += new System.EventHandler(this.label_ФИО_Click);
            // 
            // label_СуммаОплаты
            // 
            this.label_СуммаОплаты.AutoSize = true;
            this.label_СуммаОплаты.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_СуммаОплаты.Location = new System.Drawing.Point(251, 103);
            this.label_СуммаОплаты.Name = "label_СуммаОплаты";
            this.label_СуммаОплаты.Size = new System.Drawing.Size(65, 28);
            this.label_СуммаОплаты.TabIndex = 5;
            this.label_СуммаОплаты.Text = "label1";
            this.label_СуммаОплаты.Click += new System.EventHandler(this.label_СуммаОплаты_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripDropDownButton1});
            this.toolStripMain.Location = new System.Drawing.Point(226, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(574, 31);
            this.toolStripMain.TabIndex = 11;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
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
            // FormMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.label_СуммаОплаты);
            this.Controls.Add(this.label_ФИО);
            this.Controls.Add(this.button_ОтправитьЗаявку);
            this.Controls.Add(this.Заявки);
            this.Controls.Add(this.button_ОплатитьКвитанцию);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMainUser";
            this.Text = "Главная страница пользователя";
            this.Load += new System.EventHandler(this.FormMainUser_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem мойПрофильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиЗаявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мояНедвижимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квитанцииИОплатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Button button_ОплатитьКвитанцию;
        private System.Windows.Forms.Label Заявки;
        private System.Windows.Forms.Button button_ОтправитьЗаявку;
        private System.Windows.Forms.Label label_ФИО;
        private System.Windows.Forms.Label label_СуммаОплаты;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактнаяИнформацияToolStripMenuItem;
    }
}

