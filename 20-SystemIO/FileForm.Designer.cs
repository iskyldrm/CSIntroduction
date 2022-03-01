
namespace _20_SystemIO
{
    partial class FileForm
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
            this.grupTemel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDogumYeri = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTakim = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMedeniDurum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMeslek = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmGelir = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEgitim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdrErkek = new System.Windows.Forms.RadioButton();
            this.rdrKadin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupTemel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGelir)).BeginInit();
            this.SuspendLayout();
            // 
            // grupTemel
            // 
            this.grupTemel.Controls.Add(this.button1);
            this.grupTemel.Controls.Add(this.cmbDogumYeri);
            this.grupTemel.Controls.Add(this.label10);
            this.grupTemel.Controls.Add(this.cmbTakim);
            this.grupTemel.Controls.Add(this.label9);
            this.grupTemel.Controls.Add(this.cmbMedeniDurum);
            this.grupTemel.Controls.Add(this.label8);
            this.grupTemel.Controls.Add(this.cmbMeslek);
            this.grupTemel.Controls.Add(this.label7);
            this.grupTemel.Controls.Add(this.nmGelir);
            this.grupTemel.Controls.Add(this.label6);
            this.grupTemel.Controls.Add(this.cmbEgitim);
            this.grupTemel.Controls.Add(this.label5);
            this.grupTemel.Controls.Add(this.rdrErkek);
            this.grupTemel.Controls.Add(this.rdrKadin);
            this.grupTemel.Controls.Add(this.label4);
            this.grupTemel.Controls.Add(this.dtDogumTarihi);
            this.grupTemel.Controls.Add(this.label3);
            this.grupTemel.Controls.Add(this.txtSoyad);
            this.grupTemel.Controls.Add(this.label2);
            this.grupTemel.Controls.Add(this.txtAd);
            this.grupTemel.Controls.Add(this.label1);
            this.grupTemel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grupTemel.Location = new System.Drawing.Point(12, 12);
            this.grupTemel.Name = "grupTemel";
            this.grupTemel.Size = new System.Drawing.Size(439, 563);
            this.grupTemel.TabIndex = 0;
            this.grupTemel.TabStop = false;
            this.grupTemel.Text = "Temel Bilgiler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDogumYeri
            // 
            this.cmbDogumYeri.FormattingEnabled = true;
            this.cmbDogumYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmbDogumYeri.Location = new System.Drawing.Point(160, 470);
            this.cmbDogumYeri.Name = "cmbDogumYeri";
            this.cmbDogumYeri.Size = new System.Drawing.Size(250, 31);
            this.cmbDogumYeri.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dogum Yeri";
            // 
            // cmbTakim
            // 
            this.cmbTakim.FormattingEnabled = true;
            this.cmbTakim.Items.AddRange(new object[] {
            "Beşiktaş",
            "Fenerbahçe",
            "Galatasaray",
            "Trabzonspor"});
            this.cmbTakim.Location = new System.Drawing.Point(160, 425);
            this.cmbTakim.Name = "cmbTakim";
            this.cmbTakim.Size = new System.Drawing.Size(250, 31);
            this.cmbTakim.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tuttugu Takim";
            // 
            // cmbMedeniDurum
            // 
            this.cmbMedeniDurum.FormattingEnabled = true;
            this.cmbMedeniDurum.Items.AddRange(new object[] {
            "Bekar",
            "Evli",
            "Bosanmis"});
            this.cmbMedeniDurum.Location = new System.Drawing.Point(160, 380);
            this.cmbMedeniDurum.Name = "cmbMedeniDurum";
            this.cmbMedeniDurum.Size = new System.Drawing.Size(250, 31);
            this.cmbMedeniDurum.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Medeni Durum";
            // 
            // cmbMeslek
            // 
            this.cmbMeslek.FormattingEnabled = true;
            this.cmbMeslek.Items.AddRange(new object[] {
            "Antropolog",
            "Arkeolog",
            "Astronom",
            "Avukat Yardımcısı",
            "Ayak Hastalıkları Uzmanı",
            "Bilgisayar Programcısı",
            "Bilgisayar Sistem Analisti",
            "Bilirkişi",
            "Biyolog",
            "Biyomedikal Mühendisliği",
            "Cam Ustası",
            "Cerrah",
            "Cilt Bakım Uzmanı",
            "Çevre Mühendisi",
            "Diş Sağlığı Uzmanı",
            "Dişçi",
            "Diyetisyen",
            "Duvar Ustası",
            "Eczacı",
            "Elektrik Mühendisi",
            "Elektrikçi",
            "Endüstri Mühendisliği",
            "Endüstriyel Makine Tamircileri",
            "Endüstriyel Tasarımcı",
            "Etkinlik Koordinatörü",
            "Fizikçi",
            "Fizyolog (İnsan vücudu ile ilgili problemlerin çözüme kavuşturulması)",
            "Fizyoterapist (Fizyoterapi alanında en az lisans mezunu sağlık meslek mensubudur)" +
                "",
            "Gözlükçü",
            "Haberleşme Cihazları Mekanik Tamircileri",
            "Halkla İlişkiler Yöneticisi",
            "Havacılık ve Uzay Mühendisi",
            "Hekim (Genel Uygulama)",
            "Hekim Yardımcısı",
            "Hemşire (Kadrolu)",
            "Hemşire (Pratik Lisanslı)",
            "İlkokul Öğretmeni",
            "İnsan Kaynakları Müdürü",
            "İnşaat Mühendisi",
            "İnşaat/ Yapı Müfettişi",
            "İstatistikçi",
            "İş Güvenliği/ Sağlık Müfettişi",
            "İşveren",
            "Jeolog",
            "Kanalizasyon Tesisi Operatör",
            "Kayropraktik Uzmanı (Elle tedavi uzmanı)",
            "Konuşma Bozuklukları Uzmanı",
            "Kredi Yöneticisi",
            "Kütüphaneci",
            "Lojistik"});
            this.cmbMeslek.Location = new System.Drawing.Point(160, 318);
            this.cmbMeslek.Name = "cmbMeslek";
            this.cmbMeslek.Size = new System.Drawing.Size(250, 31);
            this.cmbMeslek.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Meslek";
            // 
            // nmGelir
            // 
            this.nmGelir.Location = new System.Drawing.Point(160, 275);
            this.nmGelir.Name = "nmGelir";
            this.nmGelir.Size = new System.Drawing.Size(250, 30);
            this.nmGelir.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gelir";
            // 
            // cmbEgitim
            // 
            this.cmbEgitim.FormattingEnabled = true;
            this.cmbEgitim.Items.AddRange(new object[] {
            "İlkOkul",
            "OrtaOkul",
            "Lise",
            "ÖnLisans",
            "Lisans",
            "YuksekLisans",
            "Doktora"});
            this.cmbEgitim.Location = new System.Drawing.Point(160, 228);
            this.cmbEgitim.Name = "cmbEgitim";
            this.cmbEgitim.Size = new System.Drawing.Size(250, 31);
            this.cmbEgitim.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Egitim Durumu";
            // 
            // rdrErkek
            // 
            this.rdrErkek.AutoSize = true;
            this.rdrErkek.Location = new System.Drawing.Point(304, 173);
            this.rdrErkek.Name = "rdrErkek";
            this.rdrErkek.Size = new System.Drawing.Size(76, 27);
            this.rdrErkek.TabIndex = 8;
            this.rdrErkek.TabStop = true;
            this.rdrErkek.Text = "Erkek";
            this.rdrErkek.UseVisualStyleBackColor = true;
            // 
            // rdrKadin
            // 
            this.rdrKadin.AutoSize = true;
            this.rdrKadin.Location = new System.Drawing.Point(160, 173);
            this.rdrKadin.Name = "rdrKadin";
            this.rdrKadin.Size = new System.Drawing.Size(77, 27);
            this.rdrKadin.TabIndex = 7;
            this.rdrKadin.TabStop = true;
            this.rdrKadin.Text = "Kadin";
            this.rdrKadin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cinsiyet";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(160, 131);
            this.dtDogumTarihi.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtDogumTarihi.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(250, 30);
            this.dtDogumTarihi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dogum Tarihi";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSoyad.Location = new System.Drawing.Point(160, 78);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 30);
            this.txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadi";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAd.Location = new System.Drawing.Point(160, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 30);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 689);
            this.Controls.Add(this.grupTemel);
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.grupTemel.ResumeLayout(false);
            this.grupTemel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGelir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupTemel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMeslek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmGelir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEgitim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdrErkek;
        private System.Windows.Forms.RadioButton rdrKadin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMedeniDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDogumYeri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTakim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}