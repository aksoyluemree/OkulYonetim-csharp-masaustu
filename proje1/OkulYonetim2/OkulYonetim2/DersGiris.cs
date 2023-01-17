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
    public partial class DersGiris : Form
    {
        public DersGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(Baglanti.ConnectionString);

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Ders (Ad,Kredi, OkulYonetimId, DersRenk) values (@p1, @p2, @p3, @p4)", baglan);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKredi.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(cmbOgretmen.SelectedValue));
            komut.Parameters.AddWithValue("@p4", cmbRenk.Text);

            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Kayıt başarılı");

            txtAd.Text = "";
            txtKredi.Text = "";
            cmbRenk.Text = "";
            cmbOgretmen.Text = "";
        }

        private void DersGiris_Load(object sender, EventArgs e)
        {

            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));

            foreach (KnownColor knowColor in colors)
            {
                Color color = Color.FromKnownColor(knowColor);
                cmbRenk.Items.Add(color.Name);
            }

            SqlDataAdapter da = new SqlDataAdapter("select * from personel where YonetimTip = 'Ögretmen'", baglan);


            DataSet ds = new DataSet();
            da.Fill(ds, "Personel");
            cmbOgretmen.DisplayMember = "AdSoyad";
            cmbOgretmen.ValueMember = "Id";

            cmbOgretmen.DataSource = ds.Tables["Personel"];
        }
    }
}
