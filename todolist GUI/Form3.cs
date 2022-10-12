using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild !=null)
            {
                ActiveMdiChild.Close();
            }
            Form1 frm= new Form1();
            frm.MdiParent = this;
            frm.Show();

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 login = new Form2();
            login.MdiParent = this;
            login.Show();
        }

        private void dISPLAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 disp = new Form4();
            disp.MdiParent = this;
            disp.Show();
        }
    }
}
