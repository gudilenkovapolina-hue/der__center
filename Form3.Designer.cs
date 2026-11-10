namespace Детский_центр
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            Ученик = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ПРИВЕЕЕТ;
            pictureBox1.Location = new Point(350, 61);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unbounded", 20F);
            label1.Location = new Point(204, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 61);
            label1.TabIndex = 1;
            label1.Text = "{XY}";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unbounded", 20F);
            label2.Location = new Point(927, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 61);
            label2.TabIndex = 2;
            label2.Text = "{XY}";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Group_1;
            pictureBox2.Location = new Point(56, 186);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1133, 412);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unbounded", 5F);
            label3.Location = new Point(395, 270);
            label3.Name = "label3";
            label3.Size = new Size(202, 48);
            label3.TabIndex = 4;
            label3.Text = "лучшие аудитории\nчеткие направления\nмолодые ПРОФпреподаватели";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Современность;
            pictureBox3.Location = new Point(395, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(202, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Unbounded", 6F);
            label4.Location = new Point(643, 465);
            label4.Name = "label4";
            label4.Size = new Size(200, 95);
            label4.TabIndex = 6;
            label4.Text = "обьясняем просто и легко для самых маленьких и постарше, сразу погружаемся в мир искусства";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.от_6_до_35_ЛЕТ;
            pictureBox4.Location = new Point(654, 408);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(179, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.Font = new Font("Guano Apes (Rus by sherbackoffa", 30F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(404, 399);
            label5.Name = "label5";
            label5.Size = new Size(115, 76);
            label5.TabIndex = 8;
            label5.Text = "70+";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SSF Breakthrough", 9F);
            label6.Location = new Point(404, 465);
            label6.Name = "label6";
            label6.Size = new Size(176, 27);
            label6.TabIndex = 9;
            label6.Text = "любимых учеников";
            label6.Click += label6_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(163, 465);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 95);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ЗАПИСАТЬСЯ на пробное занятие";
            linkLabel1.TextAlign = ContentAlignment.TopRight;
            // 
            // Ученик
            // 
            Ученик.BackColor = Color.FromArgb(128, 128, 255);
            Ученик.Font = new Font("SSF Breakthrough", 10F);
            Ученик.ForeColor = Color.Navy;
            Ученик.Location = new Point(1080, 12);
            Ученик.Name = "Ученик";
            Ученик.Size = new Size(109, 53);
            Ученик.TabIndex = 12;
            Ученик.Text = "Войти";
            Ученик.UseVisualStyleBackColor = false;
            Ученик.Click += Ученик_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 646);
            Controls.Add(Ученик);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Unbounded", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
        private LinkLabel linkLabel1;
        private Button Ученик;
    }
}