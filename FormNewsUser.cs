using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormNewsUser : Form
    {
        public FormNewsUser()
        {
            InitializeComponent();
            LoadNewsData();
        }

        private void LoadNewsData()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT 
                                    ID_Новости as 'Номер новости',
                                    FORMAT(ДатаСоздания_Новости, 'dd.MM.yyyy HH:mm') as 'Дата',
                                    Тема_Новости as 'Тема',
                                    Описание_Новости as 'Описание'
                                   FROM News
                                   ORDER BY ДатаСоздания_Новости DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable newsData = new DataTable();
                    adapter.Fill(newsData);

                    dataGridViewNews.DataSource = newsData;
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadNewsData();
        }
    }
}