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
    public partial class F_suhu : Form
    {
        public F_suhu()
        {
            InitializeComponent();
        }

        private void btn_konversi_Click(object sender, EventArgs e)
        {
            try
            {
                Double celcius = int.Parse(tb_celcius.Text);
                tb_fahrenheit.Text = Convert.ToString((celcius * 9 / 5) + 32);
                tb_reamur.Text = Convert.ToString(celcius * 4 / 5);
                tb_kelvin.Text = Convert.ToString(celcius + 273.15);
            }
            

            catch (Exception err)
            {
                DialogResult hasil;
                hasil = MessageBox.Show(err.Message, "Pemberitahuan",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(hasil== System.Windows.Forms.DialogResult.Yes)
                {
                    hapus();
                    tb_celcius.Focus();
                }
                else
                {
                    this.Close();
                }
            }
        }

        public void hapus ()
        {
            tb_celcius.Text = "";
            tb_fahrenheit.Text = "";
            tb_reamur.Text = "";
            tb_kelvin.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            hapus();
        }

     
    }
}
