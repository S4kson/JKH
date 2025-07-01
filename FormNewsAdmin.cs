using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormsNewsAdmin : Form
    {
        private DataTable _newsData;
        private string _connectionString;

        public FormsNewsAdmin()
        {
            InitializeComponent();
            _connectionString = DatabaseConnection.GetConnectionString();
            LoadNewsData();
            SetupDataGridView();
        }

        private void LoadNewsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = @"SELECT 
                                    n.ID_Новости as 'ID',
                                    a.ФИО_Админ as 'Автор',
                                    n.Тема_Новости as 'Тема',
                                    n.Описание_Новости as 'Описание',
                                    n.ДатаСоздания_Новости as 'Дата создания'
                                   FROM News n
                                   LEFT JOIN Admin a ON n.ID_Админ = a.ID_Админ
                                   ORDER BY n.ДатаСоздания_Новости DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    _newsData = new DataTable();
                    adapter.Fill(_newsData);

                    dataGridViewNews.DataSource = _newsData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки новостей:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridViewNews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNews.AllowUserToAddRows = false;
            dataGridViewNews.Columns["ID"].ReadOnly = true;
            dataGridViewNews.Columns["Автор"].ReadOnly = true;
            dataGridViewNews.Columns["Дата создания"].ReadOnly = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    foreach (DataRow row in _newsData.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            string updateQuery = @"UPDATE News SET 
                                                Тема_Новости = @Title, 
                                                Описание_Новости = @Description
                                                WHERE ID_Новости = @ID";

                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Title", row["Тема"]);
                                command.Parameters.AddWithValue("@Description", row["Описание"]);
                                command.Parameters.AddWithValue("@ID", row["ID"]);
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Изменения успешно сохранены!", "Успех",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCreateNews createForm = new FormCreateNews(CurrentUser.Id);
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                LoadNewsData(); // Обновляем данные после добавления
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewNews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите новости для удаления", "Информация",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Удалить выбранные новости?", "Подтверждение",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow selectedRow in dataGridViewNews.SelectedRows)
                        {
                            int newsId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                            string deleteQuery = "DELETE FROM News WHERE ID_Новости = @ID";

                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ID", newsId);
                                command.ExecuteNonQuery();
                            }
                        }

                        LoadNewsData(); // Обновляем данные после удаления
                        MessageBox.Show("Новости успешно удалены!", "Успех",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления:\n{ex.Message}",
                                  "Ошибка",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadNewsData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}