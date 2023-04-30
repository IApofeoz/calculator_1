namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Поля для значений пусты!");
                }
                else
                {
                    solut_2();
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
                    solut_3();
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

        private void solut_2()
        {
            label3.Text = textBox1.Text + "*" + textBox4.Text + "-" + textBox2.Text + "*" + textBox3.Text + "\r\n" + "Ответ: " +
            Convert.ToString(Convert.ToInt16(textBox1.Text) * Convert.ToInt16(textBox4.Text) - Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox3.Text));
        }

        private void solut_3()
        {
            label3.Text = textBox1.Text + "*" + textBox5.Text + "*" + textBox9.Text + "+" + textBox2.Text + "*" + textBox6.Text + "*" + textBox7.Text + "+" +
            textBox3.Text + "*" + textBox4.Text + "*" + textBox8.Text + "-" + textBox4.Text + "*" + textBox5.Text + "*" + textBox7.Text + "-" +
            textBox1.Text + "*" + textBox6.Text + "*" + textBox8.Text + "-" + textBox2.Text + "*" + textBox4.Text + "*" + textBox9.Text + "\r\n" + "Ответ: " +
            Convert.ToString(Convert.ToInt16(textBox1) * Convert.ToInt16(textBox5) * Convert.ToInt16(textBox9) + Convert.ToInt16(textBox2) * Convert.ToInt16(textBox6) * Convert.ToInt16(textBox7) +
            Convert.ToInt16(textBox3) * Convert.ToInt16(textBox4) * Convert.ToInt16(textBox8) - Convert.ToInt16(textBox4) * Convert.ToInt16(textBox5) * Convert.ToInt16(textBox7) -
            Convert.ToInt16(textBox1) * Convert.ToInt16(textBox6) * Convert.ToInt16(textBox8) - Convert.ToInt16(textBox2) * Convert.ToInt16(textBox4) * Convert.ToInt16(textBox9));

        }

        private void order_3()
        {
            pictureBox1.Location = new Point(34, 62);
            pictureBox1.Size = new Size(10, 140);
            pictureBox2.Location = new Point(179, 62);
            pictureBox2.Size = new Size(10, 140);
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
            pictureBox1.Size = new Size(10, 100);
            pictureBox2.Location = new Point(165, 77);
            pictureBox2.Size = new Size(10, 100);
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

    }
}