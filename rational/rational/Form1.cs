using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rational
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Summa_Click(object sender, EventArgs e)
        {
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(2, 3);
            Rational r3 = r1.Sum(r2);
            textBox1.Text = r3.ToString();
        }
    }
}
