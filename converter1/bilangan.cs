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
    public partial class bilangan : Form
    {
        public bilangan()
        {
            InitializeComponent();
        }

        private void btn_konversi_Click(object sender, EventArgs e)
        {
            try
            {
                int angkaconvert = int.Parse(txt_angka.Text);
                txtb_biner.Text = Convert.ToString(angkaconvert, 2);
                txtb_dec.Text = Convert.ToString(angkaconvert);
                txtb_hex.Text = Convert.ToString(angkaconvert, 16);
                txtb_oct.Text = Convert.ToString(angkaconvert, 8);

            }

            catch (Exception err)
            {
                DialogResult hasil;
                hasil = MessageBox.Show(err.Message, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (hasil == System.Windows.Forms.DialogResult.Yes)
                {
                    hapus();
                    txt_angka.Focus();
                }
                else
                {
                    this.Close();
                }
            }
        }

        public void hapus()
        {
            txt_angka.Text = "";
            txtb_biner.Text = "";
            txtb_dec.Text = "";
            txtb_hex.Text = "";
            txtb_oct.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            hapus();
        }
    }
}
