using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\huseyinkaradana\Desktop\Kitaplik.mdb");

        public void Listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da= new OleDbDataAdapter("SELECT * FROM Kitaplar",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }
        String durum = 0.ToString();
        private void button2_Click(object sender, EventArgs e)
        {
            if(rbKullanilmis.Checked)
            {
                durum = 0.ToString();
            }else if (rbSifir.Checked)
            {
                durum = 1.ToString();
            }
            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("INSERT INTO Kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) VALUES (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut1.Parameters.AddWithValue("@p1",txtKitapAd.Text);
            komut1.Parameters.AddWithValue("@p2",txtYazarAd.Text);
            komut1.Parameters.AddWithValue("@p3",cbTur.Text);
            komut1.Parameters.AddWithValue("@p4",txtSayfa.Text);
            komut1.Parameters.AddWithValue("@p5",durum);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtKitapid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazarAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rbSifir.Checked = true;
            }
            else
            {
                rbKullanilmis.Checked = true;
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut= new OleDbCommand("DELETE FROM Kitaplar WHERE Kitapid=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txtKitapid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kitap Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE Kitaplar SET KitapAd=@p1,Yazar=@p2,Tur=@p3,Sayfa=@p4,Durum=@p5 WHERE Kitapid=@p6",baglanti);
            komut.Parameters.AddWithValue("@p1",txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2",txtYazarAd.Text);
            komut.Parameters.AddWithValue("@p3",cbTur.Text);
            komut.Parameters.AddWithValue("@p4",txtSayfa.Text);
            if (rbKullanilmis.Checked)
            {
                komut.Parameters.AddWithValue("@p5", "0");
            }
            else
            {
                komut.Parameters.AddWithValue("@p5", "1");
            }
            
            komut.Parameters.AddWithValue("@p6",txtKitapid.Text);
            komut.ExecuteNonQuery() ;
            MessageBox.Show("Kitap Bilgileri Güncelleme Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitaplar WHERE KitapAd=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",txtBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da= new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close() ;
        }

        private void txtBul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM Kitaplar WHERE KitapAd like '%"+txtBul.Text+"%'", baglanti);
            
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
