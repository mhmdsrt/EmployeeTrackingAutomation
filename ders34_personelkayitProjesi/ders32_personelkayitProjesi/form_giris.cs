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
    public partial class Form_giris : Form
    {
        public Form_giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-50T6SSM\\SQLEXPRESS;Initial Catalog=PersonelTakipSistemi;Integrated Security=True;Encrypt=False");


        private void Form_giris_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from Table_Giris where @p1=Kullanici_adi and @p2=Sifre", baglanti);
            komut1.Parameters.AddWithValue("@p1", txtKullanici_adi.Text);
            komut1.Parameters.AddWithValue("@p2", txtKullanici_sifre.Text);


            SqlDataReader dr1 = komut1.ExecuteReader();

            if (dr1.Read())
            {
                Form_Ana frm = new Form_Ana();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullancı adı ya da Şifre girdiniz");
            }



            baglanti.Close();
        }
    }
}
