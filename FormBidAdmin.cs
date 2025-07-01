using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormBidAdmin : Form
    {
        private DataTable _bidsData;
        private string _connectionString;

        public FormBidAdmin()
        {
            InitializeComponent();
            _connectionString = DatabaseConnection.GetConnectionString();
            LoadBidsData();
            SetupDataGridView();
        }

        private void LoadBidsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query = @"SELECT 
                                    b.ID_Заявка as 'ID',
                                    u.ФИО_Пользователь as 'Пользователь',
                                    a.ФИО_Админ as 'Администратор',
                                    b.Тема_Заявка as 'Тема',
                                    b.Описание_Заявка as 'Описание',
                                    b.КомментарийАдмина_Заявка as 'Комментарий',
                                    b.Статус_Заявка as 'Статус',
                                    b.ДатаСоздания_Заявка as 'Дата создания'
                                   FROM Bid b
                                   LEFT JOIN [User] u ON b.ID_Пользователь = u.ID_Пользователь
                                   LEFT JOIN Admin a ON b.ID_Админ = a.ID_Админ
                                   ORDER BY b.ДатаСоздания_Заявка DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    _bidsData = new DataTable();
                    adapter.Fill(_bidsData);

                    dataGridViewBids.DataSource = _bidsData;
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

        private void SetupDataGridView()
        {
            dataGridViewBids.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBids.AllowUserToAddRows = false;
            dataGridViewBids.Columns["ID"].ReadOnly = true;
            dataGridViewBids.Columns["Дата создания"].ReadOnly = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    foreach (DataRow row in _bidsData.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            string updateQuery = @"UPDATE Bid SET 
                                                КомментарийАдмина_Заявка = @Comment, 
                                                Статус_Заявка = @Status 
                                                WHERE ID_Заявка = @ID";

                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Comment", row["Комментарий"]);
                                command.Parameters.AddWithValue("@Status", row["Статус"]);
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadBidsData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}