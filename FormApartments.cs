using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JKH
{
    public partial class FormApartments : Form
    {
        private readonly int _userId;

        public FormApartments(int userId)
        {
            InitializeComponent();
            _userId = userId;
            ConfigureDataGridView();
            LoadApartments();
        }

        private void ConfigureDataGridView()
        {
            // Очистка и настройка столбцов
            dgvApartments.Columns.Clear();

            // Добавление столбцов вручную
            dgvApartments.Columns.Add("colId", "Номер недвижимости");
            dgvApartments.Columns.Add("colStreet", "Улица");
            dgvApartments.Columns.Add("colHouse", "Дом");
            dgvApartments.Columns.Add("colApartment", "Квартира");
            dgvApartments.Columns.Add("colArea", "Площадь (м²)");

            // Настройка ширины столбцов
            dgvApartments.Columns["colId"].Width = 120;
            dgvApartments.Columns["colStreet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvApartments.Columns["colHouse"].Width = 60;
            dgvApartments.Columns["colApartment"].Width = 80;
            dgvApartments.Columns["colArea"].Width = 100;

            // Общие настройки
            dgvApartments.AllowUserToAddRows = false;
            dgvApartments.ReadOnly = true;
            dgvApartments.RowHeadersVisible = false;
        }

        private void LoadApartments()
        {
            try
            {
                dgvApartments.Rows.Clear();

                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT 
                                    ID_Недвижимости,
                                    Улица,
                                    НомерДома,
                                    Квартира,
                                    Площадь
                                   FROM Apartments 
                                   WHERE ID_Пользователя = @userId
                                   ORDER BY Улица, НомерДома, Квартира";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvApartments.Rows.Add(
                            reader["ID_Недвижимости"],
                            reader["Улица"],
                            reader["НомерДома"],
                            reader["Квартира"],
                            reader["Площадь"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных о недвижимости:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormApartments_Load(object sender, EventArgs e)
        {

        }
    }
}