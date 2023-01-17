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
    public partial class DersListe : Form
    {
        public DersListe()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(Baglanti.ConnectionString);
        public int secilenSatir = 0;

        private void DersListe_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            secilenSatir = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value.ToString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Ders WHERE Ad like '%" + txtAra.Text + "%'";

            if(cmbSirala.Text == "Kredi Azalan")
            {
                sql = "SELECT * FROM Ders WHERE Ad like '%" + txtAra.Text + "%' ORDER BY Kredi DESC";
            }
            else if (cmbSirala.Text == "Kredi Artan")
            {
                sql = "SELECT * FROM Ders WHERE Ad like '%" + txtAra.Text + "%' ORDER BY Kredi ASC";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, Baglanti.ConnectionString);

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

                SqlCommand komut = new SqlCommand("DELETE FROM Ders WHERE Id = '" + secilenSatir + "'", baglan);
                komut.ExecuteNonQuery();

                baglan.Close();
                Liste();

            }
        }

        private void Liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ders", Baglanti.ConnectionString);

            DataTable tablo = new DataTable();

            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DersGuncelle form = new DersGuncelle();
            form.secilenSatir = secilenSatir;
            form.Show();
            this.Hide();
        }
    }
}
