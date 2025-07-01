using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin()
        {
            InitializeComponent();
            label_ФИО.Text = $"Здравствуйте, {CurrentUser.FullName}!";
        }

        private void моиЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void мойПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMyProfil profileForm = new FormMyProfil(CurrentUser.Id);
            profileForm.ShowDialog(); // Используем ShowDialog для модального окна

            // Обновляем ФИО на главной форме после закрытия
            label_ФИО.Text = $"Здравствуйте, {CurrentUser.FullName}!";
        }

        private void button_СоздатьНовость_Click(object sender, EventArgs e)
        {
            FormCreateNews sendBidForm = new FormCreateNews(CurrentUser.Id);
            sendBidForm.ShowDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очищаем данные пользователя
            CurrentUser.Id = 0;
            CurrentUser.FullName = null;
            CurrentUser.UserType = null;

            // Показываем главную страницу
            HomePage homeForm = new HomePage();
            homeForm.Show();

            // Закрываем текущую форму
            this.Close();
        }

        private void новостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormsNewsAdmin().Show();
        }

        private void управлениеПользователямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfileAdmin formProf = new FormProfileAdmin();
            formProf.ShowDialog();
        }

        private void управлениеЗаявкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormBidAdmin().ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, каф.КСУП \n Денисова Полина Витальевна, группа 522 \n 2025 год", "О программе",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void контактнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
