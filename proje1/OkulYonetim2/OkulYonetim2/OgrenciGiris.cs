using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulYonetim2
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(Baglanti.ConnectionString);

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Ogrenci (AdSoyad,KayitTarih, OgrenciNo, DTarih, Bolum) values (@p1, @p2, @p3, @p4, @p5)", baglan);
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", DateTime.Now);
            komut.Parameters.AddWithValue("@p3", txtOgrNo.Text);
            komut.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p5", txtBolum.Text);

            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kayıt başarılı");

            txtAdSoyad.Text = "";
            txtOgrNo.Text = "";
            txtBolum.Text = "";
        }
    }
}
