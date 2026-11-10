using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Детский_центр
{
    public partial class Form4 : Form
    {
        // Переменные для хранения данных, которые придут из базы
        public string UserFullName = "";
        public string UserAge = "";
        public string UserPhone = "";
        public string UserParent = "";

        public Form4()
        {
            InitializeComponent();

            // Привязываем событие загрузки формы
            this.Load += new EventHandler(Form4_Load);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Выводим данные в ваши метки
            lblStudentName.Text = UserFullName;
            label1.Text = UserAge;       // Возраст
            label2.Text = UserPhone;     // Номер
            label3.Text = UserParent;    // Родитель
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
            // Этот метод можно оставить пустым
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Позвоните нам по номеру: +79049093404", "Наши специалисты помогут вам!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Сюда можно добавить код для кнопки "Отправить"
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Позвоните нам по номеру: +79049093404", "Наши специалисты помогут вам!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}