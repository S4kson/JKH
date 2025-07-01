using System;
using System.Configuration;
using System.Data.SqlClient;

namespace JKH
{
    public static class DatabaseConnection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["JKHConnectionString"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
        public static decimal GetUserDebt(int userId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = @"SELECT ISNULL(SUM(СуммаОплаты_Квитанция), 0) 
                        FROM Receipt 
                        WHERE ID_Пользователь = @userId 
                        AND СтатусОплаты_Квитанция = 'Требует оплаты'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

    }
}