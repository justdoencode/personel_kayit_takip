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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-323TRBO\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void btn_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("Select* from kullanici_giris where kullanici_adi=@p1 and sifre=@p2",baglanti);
            cmd1.Parameters.AddWithValue("@p1", txt_kullaniciadi.Text);
            cmd1.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read()) 
            {
                frmanasayfa frmanasayfa = new frmanasayfa();
                frmanasayfa.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            

            baglanti.Close();
        }
    }
}
