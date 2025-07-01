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
    public partial class FormProfileAdmin : Form
    {
        private DataTable _usersData;
        private SqlDataAdapter _adapter;
        private string _connectionString;

        public FormProfileAdmin()
        {
            InitializeComponent();
            _connectionString = DatabaseConnection.GetConnectionString(); // Получаем строку подключения
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = @"SELECT 
                                    ID_Пользователь as 'ID',
                                    ФИО_Пользователь as 'ФИО',
                                    Логин_Пользователь as 'Логин',
                                    Пароль_Пользователь as 'Пароль',
                                    НомерТелефона_Пользователь as 'Телефон'
                                   FROM [User] 
                                   ORDER BY ФИО_Пользователь";

                    _adapter = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_adapter);

                    _usersData = new DataTable();
                    _adapter.Fill(_usersData);

                   // dataGridViewUsers.DataSource = _usersData;
                    //dataGridViewUsers.Columns["ID"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки пользователей:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    _adapter.Update(_usersData);
                    MessageBox.Show("Изменения успешно сохранены!", "Успех",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения изменений:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProfileAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jKHDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.jKHDataSet.User);

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jKHDataSet);

        }
    }
}
