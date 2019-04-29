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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }
     
        private void home_Load(object sender, EventArgs e)
        {
           
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCompany ac = new AddCompany();
            ac.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDeatils sd = new StockDeatils();
            sd.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient acl = new AddClient();
            acl.Show();

        }

        private void alertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockAlert sa = new StockAlert();
            sa.Show();
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StockReport2 chh = new StockReport2();
            chh.Show();

        }

        private void stockINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportStockIn rsi = new ReportStockIn();
            rsi.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell s = new Sell();
            s.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            payment p = new payment();
            p.Show();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSell rs = new ReportSell();
            rs.Show();
        }

        private void printBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintBill pb = new PrintBill();
            pb.Show();
        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyPayment cp = new CompanyPayment();
            cp.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            User ua = new User();
            ua.Show();
        }
    }
}
