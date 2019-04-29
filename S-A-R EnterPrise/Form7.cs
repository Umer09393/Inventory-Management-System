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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        Form2 f2 = new Form2();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
        }
    }
}
