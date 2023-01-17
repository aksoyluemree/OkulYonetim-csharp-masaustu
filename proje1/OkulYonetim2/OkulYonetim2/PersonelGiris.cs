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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(Baglanti.ConnectionString);

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (AdSoyad,Gorevi, YonetimTip) values (@p1, @p2, @p3)", baglan);
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtGorev.Text);
            komut.Parameters.AddWithValue("@p3", cmbYonetimTip.Text);

            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kayıt başarılı");

            txtAdSoyad.Text = "";
            txtGorev.Text = "";
            cmbYonetimTip.Text = "";
        }
    }
}
