using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormSendBid : Form
    {
        private readonly int _userId;

        public FormSendBid(int userId)
        {
            InitializeComponent();
            _userId = userId;

            // Настройка формы
            this.Text = "Новая заявка";
            richTextBox_Описание.Multiline = true;
            
        }

        private void button_Отправить_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            
            
                if (CreateBidInDatabase())
                {
                    MessageBox.Show("Заявка успешно отправлена!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            
      
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox_Тема.Text))
            {
                MessageBox.Show("Введите тему заявки", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(richTextBox_Описание.Text))
            {
                MessageBox.Show("Введите описание заявки", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool CreateBidInDatabase()
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                // 1. Проверяем существование пользователя
                if (!UserExists(conn, _userId))
                {
                    MessageBox.Show("Ошибка: пользователь не найден", "Ошибка");
                    return false;
                }

                // 2. Проверяем существование администратора (ID=1)
                if (!AdminExists(conn, 1))
                {
                    MessageBox.Show("Ошибка системы: администратор не найден", "Ошибка");
                    return false;
                }

                // 3. Создаем заявку
                string query = @"INSERT INTO [Bid] 
                               (ID_Админ, ID_Пользователь, Тема_Заявка, 
                                Описание_Заявка, Статус_Заявка, ДатаСоздания_Заявка)
                               VALUES 
                               (1, @userId, @topic, 
                                @description, 'Создана', GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    cmd.Parameters.AddWithValue("@topic", textBox_Тема.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", richTextBox_Описание.Text.Trim());

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private bool UserExists(SqlConnection conn, int userId)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE ID_Пользователь = @userId";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private bool AdminExists(SqlConnection conn, int adminId)
        {
            string query = "SELECT COUNT(*) FROM Admin WHERE ID_Админ = @adminId";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@adminId", adminId);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        

        private void button_Отмена_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSendBid_Load(object sender, EventArgs e)
        {

        }
    }
}