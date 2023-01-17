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
    public partial class DersGuncelle : Form
    {
        public DersGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(Baglanti.ConnectionString);
        public int secilenSatir = 0;

        private void DersGuncelle_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select TOP 1 Ad,Kredi,DersRenk from Ders WHERE Id = '" + secilenSatir + "'";
           
            SqlCommand cmd = new SqlCommand(sqlQuery, baglan);
            baglan.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    txtAd.Text = reader["Ad"].ToString();
                    txtKredi.Text = reader["Kredi"].ToString();
                    txtRenk.Text = reader["DersRenk"].ToString();
                }

                baglan.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Ders set Ad=@p1, Kredi=@p2, DersRenk=@p3 WHERE Id = '" + secilenSatir + "'", baglan);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKredi.Text);
            komut.Parameters.AddWithValue("@p3", txtRenk.Text);

            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Güncelleme başarılı");
        }

        private void DersGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            DersListe dersListe = new DersListe();
            dersListe.Show();
            this.Hide();
        }
    }
}
