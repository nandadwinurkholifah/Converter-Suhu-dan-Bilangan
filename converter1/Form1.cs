using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter1
{
    public partial class F_home : Form
    {
        public F_home()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Benarkah anda ingin keluar dari program ini ???", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void suhuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_suhu MS = new F_suhu();
            MS.ShowDialog();
        }

        private void bilanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilangan MS = new bilangan();
            MS.ShowDialog();
        }
    }
}
