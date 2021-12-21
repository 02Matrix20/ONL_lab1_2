using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_2
{
    public partial class Form1 : Form
    {
        string s;
        int a1, a2, b1, b2;
        int addToA, subToB, mulToA, divToB;
        private void textBoxa2_TextChanged(object sender, EventArgs e)
        {
            s = textBoxa2.Text;
            a2 = Convert.ToInt32(s);
        }

        private void textBoxb1_TextChanged(object sender, EventArgs e)
        {
            s = textBoxb1.Text;
            b1 = Convert.ToInt32(s);
        }

        private void addA_TextChanged(object sender, EventArgs e)
        {
            s = addA.Text;
            addToA = Convert.ToInt32(s);
        }

        private void subtractB_TextChanged(object sender, EventArgs e)
        {

            s = subtractB.Text;
            subToB = Convert.ToInt32(s);

        }

        private void multiplyA_TextChanged(object sender, EventArgs e)
        {
            s = multiplyA.Text;
            mulToA = Convert.ToInt32(s);
        }

        private void divideB_TextChanged(object sender, EventArgs e)
        {
            s = divideB.Text;
            divToB = Convert.ToInt32(s);
        }

        private void textBoxb2_TextChanged(object sender, EventArgs e)
        {
            s = textBoxb2.Text;
            b2 = Convert.ToInt32(s);
        }

        private void complete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.OKCancel;
            String message = "Ви дійсно хочете завершити?";
            String caption = "Вихід";
            if (MessageBox.Show(message, caption, msb) == DialogResult.OK)
                this.Close();
        }

        private void textBoxa1_TextChanged(object sender, EventArgs e)
        {
            s = textBoxa1.Text;
            a1 = Convert.ToInt32(s);
        }



        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form3 f)
        {
            InitializeComponent();
        }
        private void resultA_Click(object sender, EventArgs e)
        {
            int res1;
            int res2;
            
            if (radioButton1.Checked)
            {
                res1 = a1 + b1;
                res2 = a2 + b2;
                textBoxa1.Text = Convert.ToString(res1);
                textBoxa2.Text = Convert.ToString(res2);
            }
            else if (radioButton2.Checked)
            {
                res1 = a1 - b1;
                res2 = a2 - b2;
                textBoxa1.Text = Convert.ToString(res1);
                textBoxa2.Text = Convert.ToString(res2);
            }
            else if (radioButton3.Checked)
            {
                int[] numbs = { a1 * b1, a1 * b2, a2 * b1, a2 * b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                res1 = minValue;
                res2 = maxValue;
                textBoxa1.Text = Convert.ToString(res1);
                textBoxa2.Text = Convert.ToString(res2);
            }
            else if (radioButton4.Checked)
            {
                int[] numbs = { a1 / b1, a1 / b2, a2 / b1, a2 / b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                res1 = minValue;
                res2 = maxValue;
                textBoxa1.Text = Convert.ToString(res1);
                textBoxa2.Text = Convert.ToString(res2);
            }
            else if (radioButton5.Checked)
            {
                int[] numbs = { a1 / b1, a1 / b2, a2 / b1, a2 / b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                res1 = minValue;
                res2 = maxValue;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton6.Checked)
            {
                res1 = -a2;
                res2 = -a1;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton7.Checked)
            {

                int[] numbs1 = { a1, b1 };
                int[] numbs2 = { a2, b2 };
                int maxValue1 = numbs1.Max();
                int maxValue2 = numbs2.Max();
                res1 = maxValue1;
                res2 = maxValue2;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton8.Checked)
            {

                res1 = a1 + addToA;
                res2 = a2 + addToA;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton9.Checked)
            {
                res1 = b1 - subToB;
                res2 = b2 - subToB;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton10.Checked)
            {
                res1 = a1 * mulToA;
                res2 = a2 * mulToA;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton11.Checked)
            {
                res1 = b1 / divToB;
                res2 = b2 / divToB;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
        }

        private void resultB_Click(object sender, EventArgs e)
        {
            int res1;
            int res2;
            if (radioButton1.Checked)
            {
                res1 = a1 + b1;
                res2 = a2 + b2;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton2.Checked)
            {
                res1 = a1 - b1;
                res2 = a2 - b2;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton3.Checked)
            {
                int[] numbs = { a1 * b1, a1 * b2, a2 * b1, a2 * b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                res1 = minValue;
                res2 = maxValue;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton4.Checked)
            {
                int[] numbs = { a1 / b1, a1 / b2, a2 / b1, a2 / b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                res1 = minValue;
                res2 = maxValue;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton5.Checked)
            {
                int[] numbs = { a1 / b1, a1 / b2, a2 / b1, a2 / b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                res1 = minValue;
                res2 = maxValue;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton6.Checked)
            {
                res1 = -a2;
                res2 = -a1;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton7.Checked)
            {

                int[] numbs1 = { a1, b1 };
                int[] numbs2 = { a2, b2 };
                int maxValue1 = numbs1.Max();
                int maxValue2 = numbs2.Max();
                res1 = maxValue1;
                res2 = maxValue2;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton8.Checked)
            {

                res1 = a1 + addToA;
                res2 = a2 + addToA;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton9.Checked)
            {
                res1 = b1 - subToB;
                res2 = b2 - subToB;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton10.Checked)
            {
                res1 = a1 * mulToA;
                res2 = a2 * mulToA;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
            else if (radioButton11.Checked)
            {
                res1 = b1 / divToB;
                res2 = b2 / divToB;
                textBoxb1.Text = Convert.ToString(res1);
                textBoxb2.Text = Convert.ToString(res2);
            }
        }
        public void calculate_Click(object sender, EventArgs e)
        {
            int res1;
            int res2;
            if (radioButton1.Checked)
            {
                res1 = a1 + b1;
                res2 = a2 + b2;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton2.Checked)
            {
                res1 = a1 - b1;
                res2 = a2 - b2;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton3.Checked)
            {
                int[] numbs = { a1 * b1, a1 * b2, a2 * b1, a2 * b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                res1 = minValue;
                res2 = maxValue;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton4.Checked)
            {
                res1 = a1 / b1;
                res2 = a2 / b2;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton5.Checked)
            {
                int[] numbs = { a1 / b1, a1 / b2, a2 / b1, a2 / b2 };
                int minValue = numbs.Min();
                int maxValue = numbs.Max();
                res1 = minValue;
                res2 = maxValue;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton6.Checked)
            {
                res1 = -a2;
                res2 = -a1;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton7.Checked)
            {

                int[] numbs1 = { a1, b1 };
                int[] numbs2 = { a2, b2 };
                int maxValue1 = numbs1.Max();
                int maxValue2 = numbs2.Max();
                res1 = maxValue1;
                res2 = maxValue2;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton8.Checked)
            {

                res1 = a1 + addToA;
                res2 = a2 + addToA;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton9.Checked)
            {
                res1 = b1 - subToB;
                res2 = b2 - subToB;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton10.Checked)
            {
                res1 = a1 * mulToA;
                res2 = a2 * mulToA;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton11.Checked)
            {
                res1 = b1 / divToB;
                res2 = b2 / divToB;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton12.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
               
                //label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton13.Checked)
            {
                res1 = 1 / b2;
                res2 = 1 / b1;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
            else if (radioButton14.Checked)
            {
                int[] numbs1 = { a1, b1 };
                int[] numbs2 = { a2, b2 };
                int minValue1 = numbs1.Min();
                int minValue2 = numbs2.Min();
                res1 = minValue1;
                res2 = minValue2;
                label1.Text = ("[") + Convert.ToString(res1) + (";") + Convert.ToString(res2) + ("]");
            }
        }
    }
}
