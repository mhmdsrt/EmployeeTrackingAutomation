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
    public partial class Form_istatistik : Form
    {
        public Form_istatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-50T6SSM\\SQLEXPRESS;Initial Catalog=PersonelTakipSistemi;Integrated Security=True;Encrypt=False");

        private void Form_istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) from Table_personel ", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamPersonel.Text = dr1[0].ToString();
            }
            
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) from Table_personel where Personel_durum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvliPersonel.Text = dr2[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) from Table_personel where Personel_durum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekarPersonel.Text = dr3[0].ToString();
            }

            baglanti.Close();

            
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(*) from Table_personel where Personel_maas<4000", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lbldörtbindenkucukmaas.Text = dr4[0].ToString();
            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Personel_maas) from Table_personel ", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select AVG(Personel_maas) from Table_personel ", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtalamaMaas.Text = dr6[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand(" Select sum(Personel_maas) from Table_personel where Personel_meslek = 'mühendis'", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblmühendislerintoplammaas.Text = dr7[0].ToString();
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select AVG(Personel_maas) from Table_personel where Personel_meslek = 'Doktor'", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lbldoktorlarınortalamamaası.Text = dr8[0].ToString();
            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select AVG(Personel_maas) from Table_personel where Personel_meslek = 'Doktor'", baglanti);
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lbldoktorlarınortalamamaası.Text = dr9[0].ToString();
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select count(distinct(Personel_sehir)) from Table_personel", baglanti);
            SqlDataReader dr10 = komut10.ExecuteReader();

            while (dr10.Read())
            {
                lblfarklısehir.Text = dr10[0].ToString();
            }
            
            baglanti.Close();
        }
    }
}
