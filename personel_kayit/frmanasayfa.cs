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
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txt_personelid.Text = "";
            txt_personelad.Text = "";
            txt_personelsoyad.Text = "";
            txt_personelmaas.Text = "";
            cmb_sehir.Text = "";
            radio_evli.Checked = false;
            radio_bekar.Checked = false;
            txt_personelmeslek.Text="";
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-323TRBO\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.personellerTableAdapter.Fill(this.personelVeriTabaniDataSet.personeller);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd=new SqlCommand("insert into personeller (personel_ad,personel_soyad,personel_sehir,personel_maas,personel_meslek,personel_medeni_durum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            cmd.Parameters.AddWithValue("@p1", txt_personelad.Text);
            cmd.Parameters.AddWithValue("@p2", txt_personelsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmb_sehir.Text);
            cmd.Parameters.AddWithValue("@p4", txt_personelmaas.Text);
            cmd.Parameters.AddWithValue("@p5", txt_personelmeslek.Text);
            cmd.Parameters.AddWithValue("@p6", label8.Text);
            
            cmd.ExecuteNonQuery(); 
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");

        }

        private void radio_evli_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_evli.Checked == true)
                label8.Text = "True";
        }

        private void radio_bekar_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_bekar.Checked==true)
                label8.Text = "False";
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_personelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_personelad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_personelsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmb_sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_personelmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txt_personelmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
                radio_evli.Checked = true;
            if (label8.Text == "False")
                radio_bekar.Checked = true;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete From personeller where personel_id=@p1", baglanti);
            cmd.Parameters.AddWithValue("@p1", txt_personelid.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt Silindi");

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update personeller Set personel_ad=@p1,personel_soyad=@p2,personel_sehir=@p3,personel_maas=@p4,personel_medeni_durum=@p5,personel_meslek=@p6 where personel_id=@p7", baglanti);
            cmd.Parameters.AddWithValue("@p1", txt_personelad.Text);
            cmd.Parameters.AddWithValue("@p2", txt_personelsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmb_sehir.Text);
            cmd.Parameters.AddWithValue("@p4", txt_personelmaas.Text);
            cmd.Parameters.AddWithValue("@p5", label8.Text);
            cmd.Parameters.AddWithValue("@p6", txt_personelmeslek.Text);
            cmd.Parameters.AddWithValue("@p7", txt_personelid.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void btn_istatistik_Click(object sender, EventArgs e)
        {
            frmistatistik frmistatistik = new frmistatistik();
            frmistatistik.Show();
        }

        private void btn_grafikler_Click(object sender, EventArgs e)
        {
            frmgrafikler frmgrafikler = new frmgrafikler();
            frmgrafikler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmraporlar frmraporlar = new frmraporlar();
            frmraporlar.Show();
        }
    }
}
