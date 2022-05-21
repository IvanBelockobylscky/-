using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Var3Zach
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            label8.Text = "Q";
            label9.Text = "J";

            label6.Text = Class1.ChngN1;
            label8.Text = Class1.ChngN2;
            label9.Text = Class1.ChngN3;
            Random random = new Random(); int a; a = (random.Next(100, 200)); label5.Text = a.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_TextChanged(object sender, EventArgs e)
        {
            label6.Text = Class1.ChngN1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
