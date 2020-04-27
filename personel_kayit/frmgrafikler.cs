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
    public partial class frmgrafikler : Form
    {
        public frmgrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-323TRBO\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void frmgrafikler_Load(object sender, EventArgs e)
        {
            //sehirler chart
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select personel_sehir,count(*) from personeller group by personel_sehir", baglanti);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
                chart1.Series["sehirler"].Points.AddXY(dr1[0], dr1[1]);
            baglanti.Close();

            //meslek_maas chart
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select personel_meslek,avg(personel_maas) from personeller group by personel_meslek", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
                chart2.Series["meslek-ortalama_maas"].Points.AddXY(dr2[0], dr2[1]);
            baglanti.Close();
        }
    }
}
