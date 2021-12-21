using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab1_2
{
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();
        }
        
         
        private void next1_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Close();
        }

       
    }
}
