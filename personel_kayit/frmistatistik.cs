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

namespace personel_kayit
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-323TRBO\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void frmistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            //Toplam Personel Sayısı
            SqlCommand cmd1 = new SqlCommand("select count(*) from personeller", baglanti);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                lbltoplampersonel.Text = dr1[0].ToString();
            }
           
            baglanti.Close();

            //Evli Personel Sayısı
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select Count(*) From personeller Where personel_medeni_durum=1",baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblevlipersonel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select Count(*) from personeller where personel_medeni_durum=0", baglanti);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
                lblbekarpersonel.Text = dr3[0].ToString();
            baglanti.Close();

            //Farklı Şehir Sayısı
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select count(distinct(personel_sehir)) from personeller",baglanti);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
                lblsehirsayisi.Text = dr4[0].ToString();
            baglanti.Close();

            //Toplam Maaş
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select sum(personel_maas) from personeller", baglanti);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
                lbltoplammaas.Text = dr5[0].ToString();
            baglanti.Close();

            //Ortalama Maaş
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select avg(personel_maas) from personeller", baglanti);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
                lblortalamamaas.Text = dr6[0].ToString();
            baglanti.Close();
        }
    }
}
