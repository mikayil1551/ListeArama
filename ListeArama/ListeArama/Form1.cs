using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtİsim.Text!=string.Empty)
            {
                listBox1.Items.Add(txtİsim.Text.Trim().ToUpper());
                txtİsim.Clear();
                txtİsim.Focus();
            }
        }

        private void btnKisiSayisi_Click(object sender, EventArgs e)
        {

            int sayi = listBox1.Items.Count;
            MessageBox.Show(Convert.ToString(sayi));
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtİsimAra.Text!=string.Empty)
            {
                string isim = txtİsimAra.Text.ToUpper().Trim();
                if (listBox1.Items.Contains(isim))
                {
                    MessageBox.Show("Girilen isim listede var");

                }
                else
                {
                    MessageBox.Show("Girilen messaj listede yok");
                }
            }
        }

        private void btnAra_TextChanged(object sender, EventArgs e)
        {
           
        
        }

        private void txtİsimAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtİsimAra.Text.ToUpper().Trim();

            ArrayList isimler = new ArrayList();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                isimler.Add(listBox1.Items[i].ToString());

            }
            foreach (string item in isimler)
            {
                if (!item.Contains(aranan))
                {
                    listBox1.Items.Remove(item);
                }
            }
        }
    }
}
