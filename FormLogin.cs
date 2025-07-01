using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormLogin : Form
    {
        private string role; // Роль: "Жилец" или "Администратор"

        public FormLogin(string selectedRole)
        {
            InitializeComponent();
            role = selectedRole;
            Text = $"Вход как {role}";

            // Настройка элементов формы
            textBox_Пароль.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_Войти_Click(object sender, EventArgs e)
        {
            string login = textBox_Логин.Text.Trim();
            string password = textBox_Пароль.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните логин и пароль.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "";
                    if (role == "Жилец")
                    {
                        query = @"SELECT ID_Пользователь, ФИО_Пользователь 
                                FROM [User] 
                                WHERE Логин_Пользователь = @login 
                                AND Пароль_Пользователь = @password";
                    }
                    else
                    {
                        query = @"SELECT ID_Админ, ФИО_Админ 
                                FROM Admin 
                                WHERE Логин_Админ = @login 
                                AND Пароль_Админ = @password";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Сохраняем данные пользователя
                                if (role == "Жилец")
                                {
                                    CurrentUser.Id = reader.GetInt32(0);
                                    CurrentUser.FullName = reader.GetString(1);
                                    CurrentUser.UserType = "User";

                                    // Открываем главную форму жильца как отдельное окно
                                    FormMainUser userForm = new FormMainUser();
                                    userForm.Show();
                                }
                                else
                                {
                                    CurrentUser.Id = reader.GetInt32(0);
                                    CurrentUser.FullName = reader.GetString(1);
                                    CurrentUser.UserType = "Admin";

                                    // Открываем главную форму администратора как отдельное окно
                                    FormMainAdmin adminForm = new FormMainAdmin();
                                    adminForm.Show();
                                }

                                // Закрываем форму входа
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль.", "Ошибка входа",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Отмена_Click(object sender, EventArgs e)
        {
            // Возвращаемся на главную страницу
            HomePage homeForm = new HomePage();
            homeForm.Show();
            this.Close();
        }

        private void linkLabel_ЗабылиПароль_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Обратитесь к администратору для восстановления пароля.", "Восстановление пароля",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void контактнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ООО ЖКХ \n тел. 800-700", "Контактная информация",
   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, каф.КСУП \n Денисова Полина Витальевна, группа 522 \n 2025 год", "О программе",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}