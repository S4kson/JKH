using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKH
{
    public partial class FormMyProfil : Form
    {
        private readonly int _userId;
        private readonly bool _isAdmin;

        public FormMyProfil(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _isAdmin = CurrentUser.UserType == "Admin";
            LoadProfileData();

        }



        private void LoadProfileData()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query;
                    if (_isAdmin)
                    {
                        query = @"SELECT ФИО_Админ as FullName, НомерТелефона_Админ as Phone 
                               FROM Admin 
                               WHERE ID_Админ = @userId";
                    }
                    else
                    {
                        query = @"SELECT ФИО_Пользователь as FullName, НомерТелефона_Пользователь as Phone 
                               FROM [User] 
                               WHERE ID_Пользователь = @userId";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox_МоеФИО.Text = reader["FullName"].ToString();
                        textBox_МойНомерТелефона.Text = reader["Phone"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки профиля: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void adminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jKHDataSet);

        }

        private void FormMyProfil_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jKHDataSet.Admin". При необходимости она может быть перемещена или удалена.
            this.adminTableAdapter.Fill(this.jKHDataSet.Admin);

        }

        private void button_ИзменитьПрофиль_Click(object sender, EventArgs e)
        {
            string newFullName = textBox_МоеФИО.Text.Trim();
            string newPhone = textBox_МойНомерТелефона.Text.Trim();

            if (string.IsNullOrEmpty(newFullName))
            {
                MessageBox.Show("Введите ФИО", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query;
                    if (_isAdmin)
                    {
                        query = @"UPDATE Admin 
                               SET ФИО_Админ = @fullName,
                                   НомерТелефона_Админ = @phone
                               WHERE ID_Админ = @userId";
                    }
                    else
                    {
                        query = @"UPDATE [User] 
                               SET ФИО_Пользователь = @fullName,
                                   НомерТелефона_Пользователь = @phone
                               WHERE ID_Пользователь = @userId";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fullName", newFullName);
                    cmd.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(newPhone) ? DBNull.Value : (object)newPhone);
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Профиль успешно обновлен!", "Успех",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CurrentUser.FullName = newFullName;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления профиля: {ex.Message}", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Отмена_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

