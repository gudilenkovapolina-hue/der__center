using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Детский_центр
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;";

            // ВНИМАНИЕ: Здесь мы запрашиваем не COUNT, а конкретные столбцы с данными
            string query = "SELECT FullName, Age, Phone, ParentName FROM users WHERE login = @login AND password = @password";

            try
            {
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();

                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", textBox2.Text);
                        command.Parameters.AddWithValue("@password", textBox3.Text);

                        // Используем SqlDataReader, чтобы прочитать полученные данные
                        using (System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Если пользователь найден
                            {
                                Form4 form4 = new Form4();

                                // Передаем данные из базы в переменные на Форме 4
                                form4.UserFullName = reader["FullName"].ToString();
                                form4.UserAge = reader["Age"].ToString();
                                form4.UserPhone = reader["Phone"].ToString();
                                form4.UserParent = reader["ParentName"].ToString();

                                form4.Show();
                                this.Hide(); // Скрываем текущую форму
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль. Попробуйте еще раз.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе: " + ex.Message);
            }
        }
    }
}
