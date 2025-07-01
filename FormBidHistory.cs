using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormBidHistory : Form
    {
        private readonly int _userId;

        public FormBidHistory(int userId)
        {
            InitializeComponent();
            _userId = userId;
            ConfigureDataGridView();
            LoadBidHistory();
        }

        private void ConfigureDataGridView()
        {
            // Очистка и настройка столбцов
            dgvBidHistory.Columns.Clear();

            // Добавление столбцов вручную
            dgvBidHistory.Columns.Add("colId", "№");
            dgvBidHistory.Columns.Add("colTheme", "Тема");
            dgvBidHistory.Columns.Add("colStatus", "Статус");
            dgvBidHistory.Columns.Add("colDate", "Дата создания");
            dgvBidHistory.Columns.Add("colComment", "Комментарий администратора");

            // Настройка ширины столбцов
            dgvBidHistory.Columns["colId"].Width = 50;
            dgvBidHistory.Columns["colTheme"].Width = 150;
            dgvBidHistory.Columns["colStatus"].Width = 100;
            dgvBidHistory.Columns["colDate"].Width = 120;
            dgvBidHistory.Columns["colComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Общие настройки
            dgvBidHistory.AllowUserToAddRows = false;
            dgvBidHistory.ReadOnly = true;
            dgvBidHistory.RowHeadersVisible = false;
        }

        private void LoadBidHistory()
        {
            try
            {
                dgvBidHistory.Rows.Clear();

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT 
                                    ID_Заявка,
                                    Тема_Заявка,
                                    Статус_Заявка,
                                    FORMAT(ДатаСоздания_Заявка, 'dd.MM.yyyy HH:mm') as Дата,
                                    ISNULL(КомментарийАдмина_Заявка, '') as Комментарий
                                   FROM Bid 
                                   WHERE ID_Пользователь = @userId
                                   ORDER BY ДатаСоздания_Заявка DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvBidHistory.Rows.Add(
                            reader["ID_Заявка"],
                            reader["Тема_Заявка"],
                            reader["Статус_Заявка"],
                            reader["Дата"],
                            reader["Комментарий"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заявок:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBidHistory();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBidHistory_Load(object sender, EventArgs e)
        {

        }
    }
}