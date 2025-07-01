namespace JKH
{
    partial class FormCreateNews
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.Button buttonCancel;
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
            this.labelTopic = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(27, 74);
            this.labelTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(44, 16);
            this.labelTopic.TabIndex = 0;
            this.labelTopic.Text = "Тема:";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(107, 70);
            this.textBoxTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(532, 22);
            this.textBoxTopic.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(27, 123);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 16);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Описание:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(107, 142);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(532, 161);
            this.richTextBoxDescription.TabIndex = 3;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(27, 332);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 16);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Дата:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Location = new System.Drawing.Point(107, 325);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDate.TabIndex = 5;
            // 
            // buttonPublish
            // 
            this.buttonPublish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPublish.Location = new System.Drawing.Point(380, 320);
            this.buttonPublish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(133, 49);
            this.buttonPublish.TabIndex = 6;
            this.buttonPublish.Text = "Опубликовать";
            this.buttonPublish.UseVisualStyleBackColor = false;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.Location = new System.Drawing.Point(527, 320);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 49);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(25, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(215, 31);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Создание новости";
            // 
            // FormCreateNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 382);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPublish);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.labelTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая новость";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}