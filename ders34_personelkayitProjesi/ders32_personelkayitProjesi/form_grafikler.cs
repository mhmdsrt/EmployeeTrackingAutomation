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
    public partial class form_grafikler : Form
    {
        public form_grafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-50T6SSM\\SQLEXPRESS;Initial Catalog=PersonelTakipSistemi;Integrated Security=True;Encrypt=False");

        private void form_grafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgrafik = new SqlCommand("select Personel_sehir,count(*) from Table_personel group by Personel_sehir", baglanti);
            SqlDataReader drgrafik = komutgrafik.ExecuteReader();
            while (drgrafik.Read())
            {
                chart1.Series["Sehir Sayıları"].Points.AddXY(drgrafik[0], drgrafik[1]);
            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komutgrafik2 = new SqlCommand("select Personel_meslek,avg(Personel_maas) from Table_personel group by Personel_meslek", baglanti);
            SqlDataReader drgrafik2 = komutgrafik2.ExecuteReader();
            while (drgrafik2.Read())
            {
                chart2.Series["Ortalama Maas"].Points.AddXY(drgrafik2[0], drgrafik2[1]);
            }
            baglanti.Close();

        }
    }
}
