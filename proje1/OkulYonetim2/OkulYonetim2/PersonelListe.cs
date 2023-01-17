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
    public partial class PersonelListe : Form
    {
        public PersonelListe()
        {
            InitializeComponent();
        }

        int secilenSatir = 0;
        SqlConnection baglan = new SqlConnection(Baglanti.ConnectionString);

        private void PersonelListe_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void Liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel", Baglanti.ConnectionString);

            DataTable tablo = new DataTable();

            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            secilenSatir = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel WHERE AdSoyad like '%" + txtAra.Text + "%'", Baglanti.ConnectionString);

            DataTable tablo = new DataTable();

            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);


            if (dialogResult == DialogResult.Yes)
            {
                baglan.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM Personel WHERE Id = '" + secilenSatir + "'", baglan);
                komut.ExecuteNonQuery();

                baglan.Close();
                Liste();

            }
          
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle form = new PersonelGuncelle();
            form.secilenSatir = secilenSatir;
            form.Show();
            this.Hide();
        }
    }
}
