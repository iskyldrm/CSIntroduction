
namespace FileForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UPgelir = new System.Windows.Forms.NumericUpDown();
            this.Gelir = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.memleket = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Takım = new System.Windows.Forms.Label();
            this.comboMedeni = new System.Windows.Forms.ComboBox();
            this.MedeniHal = new System.Windows.Forms.Label();
            this.Combomeslek = new System.Windows.Forms.ComboBox();
            this.Meslek = new System.Windows.Forms.Label();
            this.EgitimD = new System.Windows.Forms.Label();
            this.EgitimDurumu = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Cinsiyet = new System.Windows.Forms.Label();
            this.DogumTarihi = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPgelir)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.UPgelir);
            this.groupBox1.Controls.Add(this.Gelir);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.memleket);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Takım);
            this.groupBox1.Controls.Add(this.comboMedeni);
            this.groupBox1.Controls.Add(this.MedeniHal);
            this.groupBox1.Controls.Add(this.Combomeslek);
            this.groupBox1.Controls.Add(this.Meslek);
            this.groupBox1.Controls.Add(this.EgitimD);
            this.groupBox1.Controls.Add(this.EgitimDurumu);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.Cinsiyet);
            this.groupBox1.Controls.Add(this.DogumTarihi);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temel Bilgiler";
            // 
            // UPgelir
            // 
            this.UPgelir.Location = new System.Drawing.Point(63, 254);
            this.UPgelir.Name = "UPgelir";
            this.UPgelir.Size = new System.Drawing.Size(100, 20);
            this.UPgelir.TabIndex = 20;
            // 
            // Gelir
            // 
            this.Gelir.AutoSize = true;
            this.Gelir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Gelir.Location = new System.Drawing.Point(6, 257);
            this.Gelir.Name = "Gelir";
            this.Gelir.Size = new System.Drawing.Size(28, 13);
            this.Gelir.TabIndex = 19;
            this.Gelir.Text = "Gelir";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Maroon;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSave.Location = new System.Drawing.Point(63, 280);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 34);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.comboBox2.Location = new System.Drawing.Point(63, 227);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // memleket
            // 
            this.memleket.AutoSize = true;
            this.memleket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.memleket.Location = new System.Drawing.Point(6, 230);
            this.memleket.Name = "memleket";
            this.memleket.Size = new System.Drawing.Size(31, 13);
            this.memleket.TabIndex = 17;
            this.memleket.Text = "Sehir";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trabzonspor",
            "Konyaspor",
            "Başakşehir\t",
            "Adana Demirspor",
            "Fenerbahçe",
            "Beşiktaş",
            "Alanyaspor",
            "Hatayspor",
            "Kayserispor",
            "Gaziantep FK",
            "Karagümrük",
            "Sivasspor",
            "Galatasaray",
            "Antalyaspor"});
            this.comboBox1.Location = new System.Drawing.Point(63, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // Takım
            // 
            this.Takım.AutoSize = true;
            this.Takım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Takım.Location = new System.Drawing.Point(6, 203);
            this.Takım.Name = "Takım";
            this.Takım.Size = new System.Drawing.Size(36, 13);
            this.Takım.TabIndex = 15;
            this.Takım.Text = "Takım";
            // 
            // comboMedeni
            // 
            this.comboMedeni.FormattingEnabled = true;
            this.comboMedeni.Items.AddRange(new object[] {
            "Evli",
            "Bekar",
            "Dul"});
            this.comboMedeni.Location = new System.Drawing.Point(63, 173);
            this.comboMedeni.Name = "comboMedeni";
            this.comboMedeni.Size = new System.Drawing.Size(100, 21);
            this.comboMedeni.TabIndex = 14;
            // 
            // MedeniHal
            // 
            this.MedeniHal.AutoSize = true;
            this.MedeniHal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MedeniHal.Location = new System.Drawing.Point(6, 176);
            this.MedeniHal.Name = "MedeniHal";
            this.MedeniHal.Size = new System.Drawing.Size(38, 13);
            this.MedeniHal.TabIndex = 13;
            this.MedeniHal.Text = "M. Hal";
            // 
            // Combomeslek
            // 
            this.Combomeslek.FormattingEnabled = true;
            this.Combomeslek.Items.AddRange(new object[] {
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
            this.Combomeslek.Location = new System.Drawing.Point(63, 146);
            this.Combomeslek.Name = "Combomeslek";
            this.Combomeslek.Size = new System.Drawing.Size(100, 21);
            this.Combomeslek.TabIndex = 12;
            // 
            // Meslek
            // 
            this.Meslek.AutoSize = true;
            this.Meslek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Meslek.Location = new System.Drawing.Point(6, 149);
            this.Meslek.Name = "Meslek";
            this.Meslek.Size = new System.Drawing.Size(41, 13);
            this.Meslek.TabIndex = 11;
            this.Meslek.Text = "Meslek";
            // 
            // EgitimD
            // 
            this.EgitimD.AutoSize = true;
            this.EgitimD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EgitimD.Location = new System.Drawing.Point(6, 125);
            this.EgitimD.Name = "EgitimD";
            this.EgitimD.Size = new System.Drawing.Size(54, 13);
            this.EgitimD.TabIndex = 10;
            this.EgitimD.Text = "E.Durumu";
            // 
            // EgitimDurumu
            // 
            this.EgitimDurumu.FormattingEnabled = true;
            this.EgitimDurumu.Items.AddRange(new object[] {
            "İlk Okul",
            "Orta Okul",
            "Lise",
            "Ön Lisans",
            "Lisans",
            "Y.Lisans",
            "Doktora"});
            this.EgitimDurumu.Location = new System.Drawing.Point(63, 122);
            this.EgitimDurumu.Name = "EgitimDurumu";
            this.EgitimDurumu.Size = new System.Drawing.Size(100, 21);
            this.EgitimDurumu.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(121, 99);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Erkek";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(63, 99);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kadın";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.AutoSize = true;
            this.Cinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cinsiyet.Location = new System.Drawing.Point(6, 103);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(43, 13);
            this.Cinsiyet.TabIndex = 6;
            this.Cinsiyet.Text = "Cinsiyet";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.AutoSize = true;
            this.DogumTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DogumTarihi.Location = new System.Drawing.Point(6, 80);
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.Size = new System.Drawing.Size(44, 13);
            this.DogumTarihi.TabIndex = 5;
            this.DogumTarihi.Text = "D.Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(63, 48);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(63, 22);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 384);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.Load += new System.EventHandler(this.FileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPgelir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DogumTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EgitimD;
        private System.Windows.Forms.ComboBox EgitimDurumu;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Cinsiyet;
        private System.Windows.Forms.ComboBox comboMedeni;
        private System.Windows.Forms.Label MedeniHal;
        private System.Windows.Forms.ComboBox Combomeslek;
        private System.Windows.Forms.Label Meslek;
        private System.Windows.Forms.Label Gelir;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label memleket;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Takım;
        private System.Windows.Forms.NumericUpDown UPgelir;
    }
}

