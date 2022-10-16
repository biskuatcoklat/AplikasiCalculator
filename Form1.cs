using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Double nilaiA, nilaiB, total;

            if (pilihOperasi.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih dulu cuy");
            }
            else if (pilihOperasi.SelectedIndex == 0)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                total = nilaiA + nilaiB;
                lstHasil.Items.Add(total);
            }
            else if (pilihOperasi.SelectedIndex == 1)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                total = nilaiA - nilaiB;
                lstHasil.Items.Add(total);
            }
            else if (pilihOperasi.SelectedIndex == 2)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                total = nilaiA * nilaiB;
                lstHasil.Items.Add(total);
            }
            else if (pilihOperasi.SelectedIndex == 3)
            {
                nilaiA = Double.Parse(txtNilaiA.Text);
                nilaiB = Double.Parse(txtNilaiB.Text);
                total = nilaiA / nilaiB;
                lstHasil.Items.Add(total);
            }
        }
    }
}
