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
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(Baglanti.ConnectionString);
        public int secilenSatir = 0;

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select TOP 1 AdSoyad,YonetimTip,Gorevi from Personel WHERE Id = '" + secilenSatir + "'";

            SqlCommand cmd = new SqlCommand(sqlQuery, baglan);
            baglan.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtAd.Text = reader["AdSoyad"].ToString();
                    txtGorev.Text = reader["Gorevi"].ToString();
                    cmbYonetimTip.Text = reader["YonetimTip"].ToString();
                }

                baglan.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set AdSoyad=@p1, Gorevi=@p2, YonetimTip=@p3 WHERE Id = '" + secilenSatir + "'", baglan);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtGorev.Text);
            komut.Parameters.AddWithValue("@p3", cmbYonetimTip.Text);

            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Güncelleme başarılı");
        }

        private void PersonelGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            PersonelListe dersListe = new PersonelListe();
            dersListe.Show();
            this.Hide();
        }
    }
}
