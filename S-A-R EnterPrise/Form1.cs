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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();

        public bool Normal { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            home h = new home();
            h.Show();
            /* if(textBox1.Text == "admin" && textBox2.Text=="admin")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                Form1 f1 = new Form1();
                f1.Hide();
             //   MessageBox.Show("Welcome to S-A-R Enterprise");
            }
            else
            {
                //MessageBox.Show("Please Enter Correct UserName or Password");
            }

            AddCompany add = new AddCompany();
            StockDeatils sd = new StockDeatils();
          //  sd.Show();
            add.Show();
        
    */
    
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
