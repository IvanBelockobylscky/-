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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            form2 = new Form2();
        }


        Form2 form2;

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            label4.Text = i.ToString();
            form2.label7.Text = i.ToString();
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        int i;
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = (checkedListBox1.SelectedIndex + 1).ToString() + " степень";
            if (checkedListBox1.SelectedIndex == 1)
            {
                if (checkedListBox1.SelectedIndex == 2)
                {
                    i = 150;
                }
                else i = 250;
            }
            else i = 350;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.ChngN1 = textBox1.Text;
            form2.label6.Text = this.textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.ChngN2 = comboBox1.Text;
            form2.label8.Text = this.textBox1.Text;
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            Class1.ChngN3 = comboBox2.Text;
            form2.label9.Text = this.textBox1.Text;
        }

        private void checkBox1_TabIndexChanged(object sender, EventArgs e)
        {
            i = i + 80;
            
        }

        private void checkBox3_TabIndexChanged(object sender, EventArgs e)
        {
            i = i + 95;
            label4.Text = i.ToString();
        }

        private void checkBox2_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_EnabledChanged(object sender, EventArgs e)
        {
            i = i + 150;
            label4.Text = i.ToString();
        }
    }
}
