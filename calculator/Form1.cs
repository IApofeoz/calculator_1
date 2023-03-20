namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Поля для значений пусты!");
            }
            else
            {
                label3.Text = textBox1.Text + "*" + textBox3.Text + "-" + textBox2.Text + "*" + textBox4.Text + "\r\n" + "Ответ: " +
                Convert.ToString(Convert.ToInt16(textBox1.Text) * Convert.ToInt16(textBox3.Text) - Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox4.Text));


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}