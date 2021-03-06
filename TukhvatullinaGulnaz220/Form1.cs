using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TukhvatullinaGulnaz220
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string[] procent = textBox3.Text.Split(new char[] { ' ' });

            foreach (string s in procent)
            {
                textBox4.Text = s;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int text1 = Convert.ToInt32(textBox1.Text);
            if (textBox4.Text == "0.90")
            {
                textBox5.Text = (text1 + 90).ToString();
            }
            if (textBox4.Text == "0.70")
            {
                textBox5.Text = (text1 + 70).ToString();
            }
            if (textBox4.Text == "0.60")
            {
                textBox5.Text = (text1 + 60).ToString();
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { return; }
            else
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(textBox1.Text);
            if (money > 500000)
            {
                MessageBox.Show("Превышено ограничение");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int money2 = Convert.ToInt32(textBox2.Text);
            if (money2 > 365)
            {
                MessageBox.Show("Превышено ограничение");
            }
        }
    }
}
