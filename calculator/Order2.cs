using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Order2 : UserControl
    {
        public Order2()
        {
            InitializeComponent();
        }

        public void num()
        {
            int a11 = Convert.ToInt16(textBox1);
            int a12 = Convert.ToInt16(textBox2);
            int a21 = Convert.ToInt16(textBox3);
            int a22 = Convert.ToInt16(textBox4);
        }
        
    }
}
