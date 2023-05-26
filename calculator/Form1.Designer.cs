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

        string versionshow;

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
            pictureBox7 = new PictureBox();
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            panel5 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher2 = new FileSystemWatcher();
            fileSystemWatcher3 = new FileSystemWatcher();
            fileSystemWatcher4 = new FileSystemWatcher();
            fileSystemWatcher5 = new FileSystemWatcher();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            button5 = new Button();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            Order_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(67, 76, 94);
            button1.Cursor = Cursors.Hand;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.Yellow;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(67, 76, 94);
            button2.Cursor = Cursors.Hand;
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.Yellow;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(67, 76, 94);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.Yellow;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(67, 76, 94);
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Yellow;
            label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(47, 55, 64);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Name = "panel1";
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
            resources.ApplyResources(Order_2, "Order_2");
            Order_2.Name = "Order_2";
            // 
            // textBox9
            // 
            resources.ApplyResources(textBox9, "textBox9");
            textBox9.Name = "textBox9";
            // 
            // textBox8
            // 
            resources.ApplyResources(textBox8, "textBox8");
            textBox8.Name = "textBox8";
            // 
            // textBox7
            // 
            resources.ApplyResources(textBox7, "textBox7");
            textBox7.Name = "textBox7";
            // 
            // textBox6
            // 
            resources.ApplyResources(textBox6, "textBox6");
            textBox6.Name = "textBox6";
            // 
            // textBox5
            // 
            resources.ApplyResources(textBox5, "textBox5");
            textBox5.Name = "textBox5";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.Name = "textBox4";
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(47, 55, 64);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.Yellow;
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Yellow;
            label2.Name = "label2";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(47, 55, 64);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // pictureBox7
            // 
            pictureBox7.Cursor = Cursors.Hand;
            resources.ApplyResources(pictureBox7, "pictureBox7");
            pictureBox7.Name = "pictureBox7";
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(67, 76, 94);
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Yellow;
            label5.Name = "label5";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(67, 76, 94);
            button4.Cursor = Cursors.Hand;
            resources.ApplyResources(button4, "button4");
            button4.ForeColor = Color.Yellow;
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(67, 76, 94);
            button3.Cursor = Cursors.Hand;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = Color.Yellow;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(Order_2);
            panel5.Controls.Add(panel3);
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
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
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            resources.ApplyResources(pictureBox6, "pictureBox6");
            pictureBox6.Name = "pictureBox6";
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(67, 76, 94);
            button5.Cursor = Cursors.Hand;
            resources.ApplyResources(button5, "button5");
            button5.ForeColor = Color.Yellow;
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.Yellow;
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.Yellow;
            label7.Name = "label7";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 64);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(pictureBox6);
            Controls.Add(panel5);
            Controls.Add(pictureBox5);
            Controls.Add(panel4);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            Order_2.ResumeLayout(false);
            Order_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher3).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher4).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button button3;
        private Panel panel5;
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
        private Button button4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private Button button5;
        private Label label6;
        private Label label7;
    }
}