using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Детский_центр
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    namespace Детский_центр
    {
        internal class DataBase
        {

            private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SchoolDB.mdf;Integrated Security=True";


            public bool CheckLogin(string login, string password)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Students WHERE Login = @login AND Password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
        }
    }
}