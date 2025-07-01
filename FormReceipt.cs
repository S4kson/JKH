using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormReceipt : Form
    {
        private readonly int _userId;
        private DataTable _receiptsData;

        public FormReceipt(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadReceiptsData();
            DisplayLastUnpaidReceipt();
        }

        private void LoadReceiptsData()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT 
                                    ID_Квитанция as 'Номер квитанции',
                                    СтатусОплаты_Квитанция as 'Статус оплаты',
                                    СуммаОплаты_Квитанция as 'Сумма'
                                   FROM Receipt 
                                   WHERE ID_Пользователь = @userId
                                   ORDER BY ID_Квитанция DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    _receiptsData = new DataTable();
                    adapter.Fill(_receiptsData);

                    dataGridViewReceipts.DataSource = _receiptsData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки квитанций:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void DisplayLastUnpaidReceipt()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT TOP 1 
                                    СтатусОплаты_Квитанция,
                                    СуммаОплаты_Квитанция
                                   FROM Receipt 
                                   WHERE ID_Пользователь = @userId 
                                   AND СтатусОплаты_Квитанция = 'Требует оплаты'
                                   ORDER BY ID_Квитанция DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        labelStatus.Text = $"Статус: {reader["СтатусОплаты_Квитанция"]}";
                        labelAmount.Text = $"Сумма к оплате: {Convert.ToDecimal(reader["СуммаОплаты_Квитанция"]):N2} руб.";
                    }
                    else
                    {
                        labelStatus.Text = "Статус: Нет неоплаченных квитанций";
                        labelAmount.Text = "Сумма к оплате: 0.00 руб.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении данных о последней квитанции:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            string url = "https://online.sberbank.ru/CSAFront/index.do";
            System.Diagnostics.Process.Start(url);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadReceiptsData();
            DisplayLastUnpaidReceipt();
        }
    }
}