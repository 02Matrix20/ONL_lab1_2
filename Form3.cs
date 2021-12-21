using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace lab1_2
{
    public partial class Form3 : Form
    {
        
        int a1, a2, b1, b2;

      

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 f2)
        {
            InitializeComponent();
        }

        
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            b1 = 1;
            b2 = 1;
            int counter=0;
            string s, b;
            b = form2.n.Text;
            int k = Convert.ToInt32(b);
            while (k > counter)
            {
                s = textBox1.Text;
                a1 = Convert.ToInt32(s);
                s = textBox2.Text;
                a2 = Convert.ToInt32(s);
                int[] numbs = { a1 * b1, a1 * b2, a2 * b1, a2 * b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                b1 = minValue;
                b2 = maxValue;
                counter++;
                this.Show();
            }
            this.Close();
            form1.label1.Text = ("[") + Convert.ToString(b1) + (";") + Convert.ToString(b2) + ("]");
        }
    }
}

