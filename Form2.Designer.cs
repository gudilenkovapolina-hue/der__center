namespace Детский_центр
{
    partial class Form2
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Font = new Font("Unbounded", 30F);
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(317, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(595, 82);
            textBox1.TabIndex = 0;
            textBox1.Text = "Путь к знаниям!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(334, 247);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 280);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SSF Breakthrough", 9F);
            label5.Location = new Point(38, 225);
            label5.Name = "label5";
            label5.Size = new Size(216, 27);
            label5.TabIndex = 9;
            label5.Text = "Спроси преподавателя!";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SSF Breakthrough", 9F);
            label4.Location = new Point(38, 198);
            label4.Name = "label4";
            label4.Size = new Size(110, 27);
            label4.TabIndex = 6;
            label4.Text = "Не знаешь?";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveBorder;
            textBox3.Location = new Point(156, 130);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(365, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Location = new Point(138, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 31);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Unbounded ExtraLight", 10F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(38, 53);
            label3.Name = "label3";
            label3.Size = new Size(94, 33);
            label3.TabIndex = 7;
            label3.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Unbounded ExtraLight", 10F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(38, 130);
            label2.Name = "label2";
            label2.Size = new Size(112, 33);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Unbounded", 10F);
            button1.Location = new Point(556, 544);
            button1.Name = "button1";
            button1.Size = new Size(112, 45);
            button1.TabIndex = 6;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 652);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}