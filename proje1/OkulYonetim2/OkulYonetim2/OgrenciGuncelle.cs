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
    public partial class OgrenciGuncelle : Form
    {
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(Baglanti.ConnectionString);
        public int secilenSatir = 0;

        private void OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select TOP 1 AdSoyad,Bolum,DTarih,OgrenciNo from Ogrenci WHERE Id = '" + secilenSatir + "'";

            SqlCommand cmd = new SqlCommand(sqlQuery, baglan);
            baglan.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtAd.Text = reader["AdSoyad"].ToString();
                    txtBolum.Text = reader["Bolum"].ToString();
                    txtOgrenciNo.Text = reader["OgrenciNo"].ToString();

                    DateTime dTarih = Convert.ToDateTime(reader["DTarih"]);
                    txtDogumTarih.Text = dTarih.ToString("dd/MM/yyyy");
                }

                baglan.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Ogrenci set AdSoyad=@p1, OgrenciNo=@p2, Bolum=@p3 WHERE Id = '" + secilenSatir + "'", baglan);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p3", txtBolum.Text);

            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Güncelleme başarılı");
        }

        private void OgrenciGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            OgrenciListe form = new OgrenciListe();
            form.Show();
            this.Hide();
        }
    }
}
