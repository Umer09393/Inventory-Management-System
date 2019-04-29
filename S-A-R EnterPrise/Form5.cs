using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_A_R_EnterPrise
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form4 f4 = new Form4();
        Form2 f2 = new Form2();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            label8.Text = Form4.t1;
            label5.Text = Form4.t2;
            label6.Text = Form4.t3;
            label7.Text = Form4.t4;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("add company sucessfully");

        //    f4.();
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f4.Show();
            this.Close();

           
     
           
            

        }
    }
}
