namespace Детский_центр
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            checkBox2 = new CheckedListBox();
            label4 = new Label();
            checkBox1 = new CheckedListBox();
            button1 = new Button();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            colDay = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            lblStudentName = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lblStudentName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 624);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SSF Breakthrough", 9F);
            label3.Location = new Point(48, 220);
            label3.Name = "label3";
            label3.Size = new Size(95, 27);
            label3.TabIndex = 8;
            label3.Text = "Родитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SSF Breakthrough", 9F);
            label2.Location = new Point(48, 179);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 7;
            label2.Text = "Номер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SSF Breakthrough", 9F);
            label1.Location = new Point(48, 131);
            label1.Name = "label1";
            label1.Size = new Size(82, 27);
            label1.TabIndex = 6;
            label1.Text = "Возраст";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(693, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(471, 459);
            panel2.TabIndex = 5;
            // 
            // checkBox2
            // 
            checkBox2.FormattingEnabled = true;
            checkBox2.Items.AddRange(new object[] { "Группповое занятие ", "Индивидуальное" });
            checkBox2.Location = new Point(17, 297);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(354, 60);
            checkBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unbounded", 15F);
            label4.Location = new Point(29, 26);
            label4.Name = "label4";
            label4.Size = new Size(414, 47);
            label4.TabIndex = 1;
            label4.Text = "Твое новое открытие!";
            // 
            // checkBox1
            // 
            checkBox1.FormattingEnabled = true;
            checkBox1.Items.AddRange(new object[] { "Граффити ", "Цифровая иллюстрация и анимация", "Стрит-арт и декор предметов", "Барабаны", "Электронная музыка и битмейкинг ", "Вокальная импровизация и битбокс " });
            checkBox1.Location = new Point(17, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(354, 172);
            checkBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(48, 475);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Вопрос";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PowderBlue;
            listBox1.Font = new Font("SSF Breakthrough", 9F);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "🎨 Художественное: Подготовка к экзаменам (от 8000 р.)", "\U0001f941 Музыкальное: Индивидуальные занятия (от 8000 р.)", "📅 Внимание! В субботу концерт, приходите!" });
            listBox1.Location = new Point(48, 372);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(532, 85);
            listBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDay, colTime, colSubject });
            dataGridView1.Location = new Point(48, 283);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(453, 70);
            dataGridView1.TabIndex = 1;
            // 
            // colDay
            // 
            colDay.HeaderText = "День";
            colDay.MinimumWidth = 8;
            colDay.Name = "colDay";
            colDay.ReadOnly = true;
            colDay.Width = 150;
            // 
            // colTime
            // 
            colTime.HeaderText = "Время";
            colTime.MinimumWidth = 8;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            colTime.Width = 150;
            // 
            // colSubject
            // 
            colSubject.HeaderText = "Направление";
            colSubject.MinimumWidth = 8;
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            colSubject.Width = 150;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Unbounded", 9F);
            lblStudentName.Location = new Point(48, 79);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(68, 28);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "ФИО";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(187, 390);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Вопрос";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 648);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblStudentName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDay;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colSubject;
        private ListBox listBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private CheckedListBox checkBox1;
        private Label label4;
        private CheckedListBox checkBox2;
        private Button button2;
    }
}