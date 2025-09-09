using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 f2 = new frm2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void frm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 f3 = new frm3();
            f3.MdiParent = this;
            f3.Show();
        }
    }
}
