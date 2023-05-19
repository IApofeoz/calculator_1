namespace calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.MouseDown += new MouseEventHandler((o, e) =>
            {
                base.Capture = false;
                Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref message);
            });
        }
        int method = 1;
        Form2 f2;

        private void button1_Click(object sender, EventArgs e)
        {
            if (method == 1)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    {
                        MessageBox.Show("Поля для значений пусты!");
                    }
                    else
                    {
                        solut_2_Tupoi();
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                    {
                        MessageBox.Show("Поля для значений пусты!");
                    }
                    else
                    {
                        solut_3_Tupoi();
                    }
                }
            }

            if (method == 2)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                    {
                        MessageBox.Show("Поля для значений пусты!");
                    }
                    else
                    {
                        solut_2_Tupoi();
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                    {
                        MessageBox.Show("Поля для значений пусты!");
                    }
                    else
                    {
                        solut_3_Smart();
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            
        }

        private void solut_2_Tupoi()
        {
            label3.Text = textBox1.Text + "*" + textBox4.Text + "-" + textBox2.Text + "*" + textBox3.Text + "\r\n" + "Ответ: " +
            Convert.ToString(Convert.ToInt16(textBox1.Text) * Convert.ToInt16(textBox4.Text) - Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox3.Text));
        }

        private void solut_3_Tupoi()
        {
            label3.Text = textBox1.Text + "*" + textBox5.Text + "*" + textBox9.Text + "+" + textBox2.Text + "*" + textBox6.Text + "*" + textBox7.Text + "+" +
            textBox3.Text + "*" + textBox4.Text + "*" + textBox8.Text + "-" + textBox4.Text + "*" + textBox5.Text + "*" + textBox7.Text + "-" +
            textBox1.Text + "*" + textBox6.Text + "*" + textBox8.Text + "-" + textBox2.Text + "*" + textBox4.Text + "*" + textBox9.Text + "\r\n" + "Ответ: " +
            Convert.ToString(Convert.ToInt16(textBox1.Text) * Convert.ToInt16(textBox5.Text) * Convert.ToInt16(textBox9.Text) + Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox6.Text) * Convert.ToInt16(textBox7.Text) +
            Convert.ToInt16(textBox3.Text) * Convert.ToInt16(textBox4.Text) * Convert.ToInt16(textBox8.Text) - Convert.ToInt16(textBox3.Text) * Convert.ToInt16(textBox5.Text) * Convert.ToInt16(textBox7.Text) -
            Convert.ToInt16(textBox1.Text) * Convert.ToInt16(textBox6.Text) * Convert.ToInt16(textBox8.Text) - Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox4.Text) * Convert.ToInt16(textBox9.Text));
        }

        private void solut_3_Smart()
        {
            label3.Text = textBox1.Text + " * (" + textBox5.Text + "*" + textBox9.Text + "-" + textBox6.Text + "*" + textBox8.Text + ") - " + textBox2.Text + " * ("
            + textBox4.Text + "*" + textBox9.Text + "-" + textBox7.Text + "*" + textBox6.Text + ") + " + textBox3.Text + " * (" + textBox4.Text + "*" + textBox8.Text + "-" +
            textBox7.Text + "*" + textBox5.Text + ")" + "\r\n" + "Ответ: " +
            Convert.ToString(Convert.ToInt16(textBox1.Text) * (Convert.ToInt16(textBox5.Text) * Convert.ToInt16(textBox9.Text) - Convert.ToInt16(textBox8.Text) * Convert.ToInt16(textBox6.Text)) -
            Convert.ToInt16(textBox2.Text) * (Convert.ToInt16(textBox4.Text) * Convert.ToInt16(textBox9.Text) - Convert.ToInt16(textBox7.Text) * Convert.ToInt16(textBox6.Text)) +
            Convert.ToInt16(textBox3.Text) * (Convert.ToInt16(textBox4.Text) * Convert.ToInt16(textBox8.Text) - Convert.ToInt16(textBox7.Text) * Convert.ToInt16(textBox5.Text)));
        }

        private void order_3()
        {
            pictureBox1.Location = new Point(34, 62);
            pictureBox1.Size = new Size(5, 140);
            pictureBox2.Location = new Point(179, 62);
            pictureBox2.Size = new Size(5, 140);
            textBox1.Location = new Point(59, 77);
            textBox2.Location = new Point(99, 77);
            textBox3.Location = new Point(139, 77);
            textBox4.Location = new Point(59, 117);
            textBox5.Visible = true;
            textBox5.Location = new Point(99, 117);
            textBox6.Visible = true;
            textBox6.Location = new Point(139, 117);
            textBox7.Visible = true;
            textBox7.Location = new Point(59, 157);
            textBox8.Visible = true;
            textBox8.Location = new Point(99, 157);
            textBox9.Visible = true;
            textBox9.Location = new Point(139, 157);

        }

        private void order_2()
        {
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            pictureBox1.Location = new Point(44, 77);
            pictureBox1.Size = new Size(5, 100);
            pictureBox2.Location = new Point(165, 77);
            pictureBox2.Size = new Size(5, 100);
            textBox1.Location = new Point(73, 93);
            textBox2.Location = new Point(118, 93);
            textBox3.Location = new Point(73, 137);
            textBox4.Location = new Point(118, 137);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                order_2();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                order_3();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            method = 1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            method = 2;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }

    }
}