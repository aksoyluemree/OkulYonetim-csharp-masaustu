using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulYonetim2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersGiris form = new DersGiris();
            form.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersListe form = new DersListe();
            form.Show();
        }

        private void girisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelGiris form = new PersonelGiris();
            form.Show();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelListe form = new PersonelListe();
            form.Show();
        }

        private void girisToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciGiris form = new OgrenciGiris();
            form.Show();
        }

        private void listeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OgrenciListe form = new OgrenciListe();
            form.Show();
        }
    }
}
