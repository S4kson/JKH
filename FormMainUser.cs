using System;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormMainUser : Form
    {
        public FormMainUser()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadUserData(); // Автоматическая загрузка при открытии
            label_ФИО.Text = $"Здравствуйте, {CurrentUser.FullName}!";
            LoadUserData();
        }

        private void LoadUserData()
        {
            // Здесь можно загрузить дополнительные данные пользователя

            try
            {
                // Получаем и отображаем задолженность
                decimal debt = DatabaseConnection.GetUserDebt(CurrentUser.Id);
                label_СуммаОплаты.Text = $"Ваша задолженность: {debt.ToString("N2")} руб.";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
                label_СуммаОплаты.Text = "Ваша задолженность: информация недоступна";
            }
        }

        private void button_МойПрофиль_Click(object sender, EventArgs e)
        {
            FormMyProfil profileForm = new FormMyProfil(CurrentUser.Id);
            profileForm.ShowDialog(); // Используем ShowDialog для модального окна

            // Обновляем ФИО на главной форме после закрытия
            label_ФИО.Text = $"Здравствуйте, {CurrentUser.FullName}!";
        }

        private void button_МоиЗаявки_Click(object sender, EventArgs e)
        {
            FormBidHistory historyForm = new FormBidHistory(CurrentUser.Id);
            historyForm.Show();
        }

        private void button_МояНедвижимость_Click(object sender, EventArgs e)
        {
            FormApartments apartmentsForm = new FormApartments(CurrentUser.Id);
            apartmentsForm.Show();
        }

        private void button_Квитанции_Click(object sender, EventArgs e)
        {
            FormReceipt receiptsForm = new FormReceipt(CurrentUser.Id);
            receiptsForm.Show();
        }

        private void button_Новости_Click(object sender, EventArgs e)
        {
            FormNewsUser newsForm = new FormNewsUser();
            newsForm.Show();
        }

        private void button_ОтправитьЗаявку_Click(object sender, EventArgs e)
        {
            FormSendBid sendBidForm = new FormSendBid(CurrentUser.Id);
            sendBidForm.ShowDialog();
        }

        private void button_ОплатитьКвитанцию_Click(object sender, EventArgs e)
        {
            string url = "https://online.sberbank.ru/CSAFront/index.do";
            System.Diagnostics.Process.Start(url);
        }

        private void button_Выйти_Click(object sender, EventArgs e)
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
            MessageBox.Show("ООО ЖКХ \n тел. 800-700", "Контактная информация",
   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {

        }

        private void label_СуммаОплаты_Click(object sender, EventArgs e)
        {

        }

        private void label_ФИО_Click(object sender, EventArgs e)
        {

        }
    }
}