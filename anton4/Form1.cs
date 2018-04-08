using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anton4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox1.Text);
            double k = Convert.ToDouble(textBox2.Text);
            double i = 0;

            while (n >= k)
            {
                i = i + 1;
                n = n - k;
            }
            double o = n;
            textBox3.Text += "Делимое = " + i + " остаток " + n + Environment.NewLine;
        }
    }
}
