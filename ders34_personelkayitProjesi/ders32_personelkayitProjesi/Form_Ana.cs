using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ders32_personelkayitProjesi
{
    public partial class Form_Ana : Form
    {
        public Form_Ana()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-50T6SSM\\SQLEXPRESS;Initial Catalog=PersonelTakipSistemi;Integrated Security=True;Encrypt=False");
        private void temizle()
        {
            txtID.Text = "";
            txtad.Text = "";
            txtmeslek.Text = "";
            txtsoyad.Text = "";
            maskedTextBox1.Text = "";
            radiobtnbekar.Checked = false;
            radiobtnevli.Checked = false;
            comboboxsehir.Text = "";
            txtad.Focus();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From Table_personel", baglanti);
            dr.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_personel (Personel_ad,Personel_soyad,Personel_maas,Personel_sehir,Personel_meslek,Personel_durum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", comboboxsehir.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);

            if (radiobtnevli.Checked)
            {
                komut.Parameters.AddWithValue("@p6", true);

            }
            else if (radiobtnbekar.Checked)
            {
               komut.Parameters.AddWithValue("@p6", false);

            }

            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Eklendi");


            baglanti.Close();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From Table_personel", baglanti);
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();

        }

        

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Table_personel where Personel_ad=@s1", baglanti);
            sil.Parameters.AddWithValue("@s1", txtad.Text);
            
            sil.ExecuteNonQuery();

            
            baglanti.Close();
            MessageBox.Show("Personel Silindi!");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand güncelle = new SqlCommand("Update Table_personel SET Personel_ad=@g1,Personel_soyad=@g2,Personel_sehir=@g3,Personel_maas=@g4,Personel_durum=@g5,Personel_meslek=@g6 Where Personel_id=@g7", baglanti);
            güncelle.Parameters.AddWithValue("@g1", txtad.Text);
            güncelle.Parameters.AddWithValue("@g2", txtsoyad.Text);
            güncelle.Parameters.AddWithValue("@g3", comboboxsehir.Text);
            güncelle.Parameters.AddWithValue("@g4", maskedTextBox1.Text);
            if (radiobtnevli.Checked)
            {
                güncelle.Parameters.AddWithValue("@g5",true);

            }
            else if (radiobtnbekar.Checked)
            {
                güncelle.Parameters.AddWithValue("@g5",false);

            }



            güncelle.Parameters.AddWithValue("@g6", txtmeslek.Text);
            güncelle.Parameters.AddWithValue("@g7", txtID.Text);

            güncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Güncellendi!");
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            Form_istatistik frm = new Form_istatistik();
            frm.Show();
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            form_grafikler frmgrafik = new form_grafikler();
            frmgrafik.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboboxsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value.ToString()) == true)
            {
                radiobtnevli.Checked = true;
                radiobtnbekar.Checked = false;

            }
            else
            {
                radiobtnbekar.Checked = true;
                radiobtnevli.Checked = false;
            }
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }
    }
}
