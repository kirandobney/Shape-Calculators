using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int side1;
            int side2;
            int side3;
            int s;

            int perimeter;
            double area;

            side1 = Convert.ToInt32(textBox1.Text);
            side2 = Convert.ToInt32(textBox2.Text);
            side3 = Convert.ToInt32(textBox3.Text);

            perimeter = side1 + side2 + side3;
            

            s = perimeter / 2; //to use heron's formula you need the semiperimeter

            area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)); //heron's formula

            if (area == 0)
            {
                textBox4.Text = ("invalid triangle"); //for if user inputs side lengths that don't make a triangle
                textBox5.Text = ("invalid triangle");
            }
            else
            {
                textBox4.Text = perimeter.ToString();
                textBox5.Text = area.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
