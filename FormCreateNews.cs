using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormCreateNews : Form
    {
        private readonly int _adminId;

        public FormCreateNews(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTopic.Text))
            {
                MessageBox.Show("Введите тему новости", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
            {
                MessageBox.Show("Введите описание новости", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"INSERT INTO News 
                                   (ДатаСоздания_Новости, Тема_Новости, Описание_Новости, ID_Админ)
                                   VALUES 
                                   (@date, @topic, @description, @adminId)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", dateTimePickerDate.Value);
                    cmd.Parameters.AddWithValue("@topic", textBoxTopic.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", richTextBoxDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@adminId", _adminId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Новость успешно опубликована!", "Успех",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при публикации новости:\n{ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}