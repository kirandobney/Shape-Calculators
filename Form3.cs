using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radius;
            int diameter;
            double circumference;
            double area;

            radius = Convert.ToInt32(textBox1.Text);
            diameter = radius * 2;

            circumference = diameter * 3.14;
            textBox2.Text = circumference.ToString();

            area = (3.14) * radius * radius;
            textBox3.Text = area.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
