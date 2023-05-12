using System.Drawing;
namespace calculator
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
            Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            Order_2 = new Panel();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel5 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher2 = new FileSystemWatcher();
            fileSystemWatcher3 = new FileSystemWatcher();
            fileSystemWatcher4 = new FileSystemWatcher();
            fileSystemWatcher5 = new FileSystemWatcher();
            button1 = new Button();
            panel1.SuspendLayout();
            Order_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher5).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(67, 76, 94);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(25, 14);
            button1.Name = "button1";
            button1.Size = new Size(175, 40);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(67, 76, 94);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(25, 60);
            button2.Name = "button2";
            button2.Size = new Size(175, 40);
            button2.TabIndex = 1;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "2", "3" });
            comboBox1.Location = new Point(150, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(50, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(25, 103);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 3;
            label1.Text = "Порядок";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(47, 55, 64);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 146);
            panel1.TabIndex = 5;
            // 
            // Order_2
            // 
            Order_2.BackColor = Color.FromArgb(47, 55, 64);
            Order_2.Controls.Add(textBox9);
            Order_2.Controls.Add(textBox8);
            Order_2.Controls.Add(textBox7);
            Order_2.Controls.Add(textBox6);
            Order_2.Controls.Add(textBox5);
            Order_2.Controls.Add(pictureBox2);
            Order_2.Controls.Add(pictureBox1);
            Order_2.Controls.Add(textBox4);
            Order_2.Controls.Add(textBox3);
            Order_2.Controls.Add(textBox2);
            Order_2.Controls.Add(textBox1);
            Order_2.Location = new Point(0, 152);
            Order_2.Name = "Order_2";
            Order_2.Size = new Size(225, 262);
            Order_2.TabIndex = 6;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(139, 157);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(25, 25);
            textBox9.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(99, 157);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(25, 25);
            textBox8.TabIndex = 8;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(59, 157);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(25, 25);
            textBox7.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(139, 117);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(25, 25);
            textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 117);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(25, 25);
            textBox5.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(179, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 140);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(34, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 140);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(59, 117);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(25, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 77);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(25, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 77);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(25, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 77);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(25, 25);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(47, 55, 64);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(256, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 414);
            panel3.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 14);
            label4.Name = "label4";
            label4.Size = new Size(321, 40);
            label4.TabIndex = 1;
            label4.Text = "Решение";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 60);
            label3.Name = "label3";
            label3.Size = new Size(420, 339);
            label3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(518, 487);
            label2.Name = "label2";
            label2.Size = new Size(254, 15);
            label2.TabIndex = 8;
            label2.Text = "Created by IApofeoz && 4igar && Vlados-Poltos\r\n";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(47, 55, 64);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(36, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(706, 45);
            panel4.TabIndex = 9;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 8);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 2;
            label5.Text = "Способ решения";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(593, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(646, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(410, 8);
            button5.Name = "button5";
            button5.Size = new Size(94, 30);
            button5.TabIndex = 3;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(290, 8);
            button4.Name = "button4";
            button4.Size = new Size(94, 30);
            button4.TabIndex = 1;
            button4.Text = "2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(170, 8);
            button3.Name = "button3";
            button3.Size = new Size(94, 30);
            button3.TabIndex = 0;
            button3.Text = "'Тупой'";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(Order_2);
            panel5.Controls.Add(panel3);
            panel5.Location = new Point(36, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(706, 414);
            panel5.TabIndex = 10;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            fileSystemWatcher2.EnableRaisingEvents = true;
            fileSystemWatcher2.SynchronizingObject = this;
            // 
            // fileSystemWatcher3
            // 
            fileSystemWatcher3.EnableRaisingEvents = true;
            fileSystemWatcher3.SynchronizingObject = this;
            // 
            // fileSystemWatcher4
            // 
            fileSystemWatcher4.EnableRaisingEvents = true;
            fileSystemWatcher4.SynchronizingObject = this;
            // 
            // fileSystemWatcher5
            // 
            fileSystemWatcher5.EnableRaisingEvents = true;
            fileSystemWatcher5.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 64);
            ClientSize = new Size(784, 511);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label2);
            MinimumSize = new Size(800, 550);
            Name = "Form1";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            Order_2.ResumeLayout(false);
            Order_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher3).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher4).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel1;
        private Panel Order_2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button button5;
        private Button button4;
        private Button button3;
        private Panel panel5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private FileSystemWatcher fileSystemWatcher1;
        private FileSystemWatcher fileSystemWatcher2;
        private FileSystemWatcher fileSystemWatcher3;
        private FileSystemWatcher fileSystemWatcher4;
        private FileSystemWatcher fileSystemWatcher5;
        private Label label5;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}