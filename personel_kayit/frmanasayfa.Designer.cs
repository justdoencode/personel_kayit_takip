namespace personel_kayit
{
    partial class frmanasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmanasayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_personelmaas = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_personelmeslek = new System.Windows.Forms.TextBox();
            this.radio_bekar = new System.Windows.Forms.RadioButton();
            this.radio_evli = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.txt_personelsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_personelad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_personelid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_grafikler = new System.Windows.Forms.Button();
            this.btn_istatistik = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelmaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelmedenidurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personelmeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new personel_kayit.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personellerTableAdapter = new personel_kayit.PersonelVeriTabaniDataSetTableAdapters.personellerTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_personelmaas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_personelmeslek);
            this.groupBox1.Controls.Add(this.radio_bekar);
            this.groupBox1.Controls.Add(this.radio_evli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_sehir);
            this.groupBox1.Controls.Add(this.txt_personelsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_personelad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_personelid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 219);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Maaş :";
            // 
            // txt_personelmaas
            // 
            this.txt_personelmaas.Location = new System.Drawing.Point(106, 113);
            this.txt_personelmaas.Mask = "0000";
            this.txt_personelmaas.Name = "txt_personelmaas";
            this.txt_personelmaas.Size = new System.Drawing.Size(100, 20);
            this.txt_personelmaas.TabIndex = 4;
            this.txt_personelmaas.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personel Meslek :";
            // 
            // txt_personelmeslek
            // 
            this.txt_personelmeslek.Location = new System.Drawing.Point(107, 189);
            this.txt_personelmeslek.Name = "txt_personelmeslek";
            this.txt_personelmeslek.Size = new System.Drawing.Size(100, 20);
            this.txt_personelmeslek.TabIndex = 6;
            // 
            // radio_bekar
            // 
            this.radio_bekar.AutoSize = true;
            this.radio_bekar.Location = new System.Drawing.Point(154, 166);
            this.radio_bekar.Name = "radio_bekar";
            this.radio_bekar.Size = new System.Drawing.Size(53, 17);
            this.radio_bekar.TabIndex = 21;
            this.radio_bekar.TabStop = true;
            this.radio_bekar.Text = "Bekar";
            this.radio_bekar.UseVisualStyleBackColor = true;
            this.radio_bekar.CheckedChanged += new System.EventHandler(this.radio_bekar_CheckedChanged);
            // 
            // radio_evli
            // 
            this.radio_evli.AutoSize = true;
            this.radio_evli.Location = new System.Drawing.Point(106, 166);
            this.radio_evli.Name = "radio_evli";
            this.radio_evli.Size = new System.Drawing.Size(42, 17);
            this.radio_evli.TabIndex = 20;
            this.radio_evli.TabStop = true;
            this.radio_evli.Text = "Evli";
            this.radio_evli.UseVisualStyleBackColor = true;
            this.radio_evli.CheckedChanged += new System.EventHandler(this.radio_evli_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medeni Durum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir :";
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Location = new System.Drawing.Point(106, 139);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(100, 21);
            this.cmb_sehir.TabIndex = 5;
            // 
            // txt_personelsoyad
            // 
            this.txt_personelsoyad.Location = new System.Drawing.Point(106, 87);
            this.txt_personelsoyad.Name = "txt_personelsoyad";
            this.txt_personelsoyad.Size = new System.Drawing.Size(100, 20);
            this.txt_personelsoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Soyad :";
            // 
            // txt_personelad
            // 
            this.txt_personelad.Location = new System.Drawing.Point(106, 61);
            this.txt_personelad.Name = "txt_personelad";
            this.txt_personelad.Size = new System.Drawing.Size(100, 20);
            this.txt_personelad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Ad :";
            // 
            // txt_personelid
            // 
            this.txt_personelid.Location = new System.Drawing.Point(106, 35);
            this.txt_personelid.Name = "txt_personelid";
            this.txt_personelid.Size = new System.Drawing.Size(100, 20);
            this.txt_personelid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personel ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btn_grafikler);
            this.groupBox2.Controls.Add(this.btn_istatistik);
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.btn_temizle);
            this.groupBox2.Controls.Add(this.btn_listele);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.btn_ekle);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 219);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btn_grafikler
            // 
            this.btn_grafikler.Location = new System.Drawing.Point(20, 190);
            this.btn_grafikler.Name = "btn_grafikler";
            this.btn_grafikler.Size = new System.Drawing.Size(75, 23);
            this.btn_grafikler.TabIndex = 8;
            this.btn_grafikler.Text = "Grafikler";
            this.btn_grafikler.UseVisualStyleBackColor = true;
            this.btn_grafikler.Click += new System.EventHandler(this.btn_grafikler_Click);
            // 
            // btn_istatistik
            // 
            this.btn_istatistik.Location = new System.Drawing.Point(20, 162);
            this.btn_istatistik.Name = "btn_istatistik";
            this.btn_istatistik.Size = new System.Drawing.Size(75, 23);
            this.btn_istatistik.TabIndex = 7;
            this.btn_istatistik.Text = "İstatistik";
            this.btn_istatistik.UseVisualStyleBackColor = true;
            this.btn_istatistik.Click += new System.EventHandler(this.btn_istatistik_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(20, 106);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(20, 133);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 6;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(20, 28);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(75, 23);
            this.btn_listele.TabIndex = 2;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(20, 80);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(20, 54);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 248);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personeladDataGridViewTextBoxColumn,
            this.personelsoyadDataGridViewTextBoxColumn,
            this.personelsehirDataGridViewTextBoxColumn,
            this.personelmaasDataGridViewTextBoxColumn,
            this.personelmedenidurumDataGridViewCheckBoxColumn,
            this.personelmeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personellerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 229);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "personel_id";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "personel_id";
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personeladDataGridViewTextBoxColumn
            // 
            this.personeladDataGridViewTextBoxColumn.DataPropertyName = "personel_ad";
            this.personeladDataGridViewTextBoxColumn.HeaderText = "personel_ad";
            this.personeladDataGridViewTextBoxColumn.Name = "personeladDataGridViewTextBoxColumn";
            // 
            // personelsoyadDataGridViewTextBoxColumn
            // 
            this.personelsoyadDataGridViewTextBoxColumn.DataPropertyName = "personel_soyad";
            this.personelsoyadDataGridViewTextBoxColumn.HeaderText = "personel_soyad";
            this.personelsoyadDataGridViewTextBoxColumn.Name = "personelsoyadDataGridViewTextBoxColumn";
            // 
            // personelsehirDataGridViewTextBoxColumn
            // 
            this.personelsehirDataGridViewTextBoxColumn.DataPropertyName = "personel_sehir";
            this.personelsehirDataGridViewTextBoxColumn.HeaderText = "personel_sehir";
            this.personelsehirDataGridViewTextBoxColumn.Name = "personelsehirDataGridViewTextBoxColumn";
            // 
            // personelmaasDataGridViewTextBoxColumn
            // 
            this.personelmaasDataGridViewTextBoxColumn.DataPropertyName = "personel_maas";
            this.personelmaasDataGridViewTextBoxColumn.HeaderText = "personel_maas";
            this.personelmaasDataGridViewTextBoxColumn.Name = "personelmaasDataGridViewTextBoxColumn";
            // 
            // personelmedenidurumDataGridViewCheckBoxColumn
            // 
            this.personelmedenidurumDataGridViewCheckBoxColumn.DataPropertyName = "personel_medeni_durum";
            this.personelmedenidurumDataGridViewCheckBoxColumn.HeaderText = "personel_medeni_durum";
            this.personelmedenidurumDataGridViewCheckBoxColumn.Name = "personelmedenidurumDataGridViewCheckBoxColumn";
            // 
            // personelmeslekDataGridViewTextBoxColumn
            // 
            this.personelmeslekDataGridViewTextBoxColumn.DataPropertyName = "personel_meslek";
            this.personelmeslekDataGridViewTextBoxColumn.HeaderText = "personel_meslek";
            this.personelmeslekDataGridViewTextBoxColumn.Name = "personelmeslekDataGridViewTextBoxColumn";
            // 
            // personellerBindingSource
            // 
            this.personellerBindingSource.DataMember = "personeller";
            this.personellerBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // personellerTableAdapter
            // 
            this.personellerTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Raporlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmanasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(853, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmanasayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.TextBox txt_personelsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_personelad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_personelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_personelmeslek;
        private System.Windows.Forms.RadioButton radio_bekar;
        private System.Windows.Forms.RadioButton radio_evli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_grafikler;
        private System.Windows.Forms.Button btn_istatistik;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_personelmaas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource personellerBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.personellerTableAdapter personellerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelmaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personelmedenidurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelmeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

