namespace Детский_центр
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            Ученик = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(194, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1420, 888);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Ученик
            // 
            Ученик.BackColor = Color.FromArgb(128, 128, 255);
            Ученик.Font = new Font("SSF Breakthrough", 15F);
            Ученик.ForeColor = Color.Navy;
            Ученик.Location = new Point(1573, 59);
            Ученик.Name = "Ученик";
            Ученик.Size = new Size(179, 79);
            Ученик.TabIndex = 1;
            Ученик.Text = "Войти";
            Ученик.UseVisualStyleBackColor = false;
            Ученик.Click += Ученик_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SSF Breakthrough", 20F);
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(570, 77);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(153, 61);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Школа";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("SSF Breakthrough", 20F);
            linkLabel2.LinkColor = Color.RoyalBlue;
            linkLabel2.Location = new Point(992, 77);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(274, 61);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Направления";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unbounded", 36F);
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(224, 112);
            label1.TabIndex = 4;
            label1.Text = "{XY}";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Font = new Font("SSF Breakthrough", 10F);
            textBox1.ForeColor = SystemColors.InfoText;
            textBox1.Location = new Point(1074, 328);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 29);
            textBox1.TabIndex = 5;
            textBox1.Text = " Школа современного искусства";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Font = new Font("SSF Breakthrough", 10F);
            textBox2.ForeColor = SystemColors.InfoText;
            textBox2.Location = new Point(1043, 354);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(351, 29);
            textBox2.TabIndex = 6;
            textBox2.Text = "для самых маленьких и чуть старше";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Unbounded Light", 50F);
            textBox3.ForeColor = SystemColors.InfoText;
            textBox3.Location = new Point(702, 389);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(692, 131);
            textBox3.TabIndex = 7;
            textBox3.Text = "ЗАЖИГАЙ";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.WhiteSmoke;
            textBox4.Font = new Font("Guano Apes (Rus by sherbackoffa", 80F);
            textBox4.ForeColor = SystemColors.Highlight;
            textBox4.Location = new Point(1043, 526);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(351, 222);
            textBox4.TabIndex = 8;
            textBox4.Text = "ОГОНЬ";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.WhiteSmoke;
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Font = new Font("Unbounded", 40F);
            textBox5.ForeColor = SystemColors.InfoText;
            textBox5.Location = new Point(702, 705);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(692, 107);
            textBox5.TabIndex = 9;
            textBox5.Text = "ВНУТРИ СЕБЯ!";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1821, 1050);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(Ученик);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Ученик;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
