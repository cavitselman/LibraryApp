namespace LibraryApp.UI
{
    partial class FormBooks
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooks));
            label8 = new Label();
            groupBox6 = new GroupBox();
            buttonTemizle = new Button();
            buttonKitapEkle = new Button();
            buttonKitapBilgiGuncelle = new Button();
            buttonGecikmeBedeliHesapla = new Button();
            label10 = new Label();
            labelGecikmeBedeli = new Label();
            groupBox2 = new GroupBox();
            buttonKitapSil = new Button();
            buttonAra = new Button();
            buttonTumKitaplarıGoster = new Button();
            buttonKitabİadeEt = new Button();
            label9 = new Label();
            textBoxKitapTurKodu = new TextBox();
            dateTimePickerOduncAlmaTarihi = new DateTimePicker();
            buttonKitapOduncVer = new Button();
            textBoxIsbn = new TextBox();
            textBoxYazarSoyadi = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            label3 = new Label();
            labelID = new Label();
            label7 = new Label();
            label1 = new Label();
            textBoxOduncAlan = new TextBox();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox5 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.Location = new Point(18, 69);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 0;
            label8.Text = "Gecikme Bedeli :";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(128, 128, 255);
            groupBox6.Controls.Add(buttonTemizle);
            groupBox6.Controls.Add(buttonKitapEkle);
            groupBox6.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox6.Location = new Point(3, 246);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(285, 69);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kayıt Düzenleme İşlemleri";
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(189, 18);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(90, 42);
            buttonTemizle.TabIndex = 3;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(97, 18);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(90, 42);
            buttonKitapEkle.TabIndex = 2;
            buttonKitapEkle.Text = "Yeni Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.Location = new Point(5, 18);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(90, 42);
            buttonKitapBilgiGuncelle.TabIndex = 2;
            buttonKitapBilgiGuncelle.Text = "Kitap Bilgi Güncelle";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.Location = new Point(107, 168);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(100, 42);
            buttonGecikmeBedeliHesapla.TabIndex = 2;
            buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(186, 69);
            label10.Name = "label10";
            label10.Size = new Size(21, 17);
            label10.TabIndex = 0;
            label10.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelGecikmeBedeli.Location = new Point(130, 69);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(15, 17);
            labelGecikmeBedeli.TabIndex = 0;
            labelGecikmeBedeli.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 128, 255);
            groupBox2.Controls.Add(buttonKitapSil);
            groupBox2.Controls.Add(buttonAra);
            groupBox2.Controls.Add(buttonTumKitaplarıGoster);
            groupBox2.Location = new Point(290, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 107);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arama";
            // 
            // buttonKitapSil
            // 
            buttonKitapSil.Location = new Point(101, 12);
            buttonKitapSil.Name = "buttonKitapSil";
            buttonKitapSil.Size = new Size(90, 42);
            buttonKitapSil.TabIndex = 5;
            buttonKitapSil.Text = "Kitap Sil";
            buttonKitapSil.UseVisualStyleBackColor = true;
            buttonKitapSil.Click += buttonKitapSil_Click;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(5, 60);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(90, 42);
            buttonAra.TabIndex = 3;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonTumKitaplarıGoster
            // 
            buttonTumKitaplarıGoster.Location = new Point(101, 60);
            buttonTumKitaplarıGoster.Name = "buttonTumKitaplarıGoster";
            buttonTumKitaplarıGoster.Size = new Size(90, 42);
            buttonTumKitaplarıGoster.TabIndex = 4;
            buttonTumKitaplarıGoster.Text = "Tüm Kitapları Göster";
            buttonTumKitaplarıGoster.UseVisualStyleBackColor = true;
            buttonTumKitaplarıGoster.Click += buttonTumKitaplarıGoster_Click;
            // 
            // buttonKitabİadeEt
            // 
            buttonKitabİadeEt.Location = new Point(107, 236);
            buttonKitabİadeEt.Name = "buttonKitabİadeEt";
            buttonKitabİadeEt.Size = new Size(100, 42);
            buttonKitabİadeEt.TabIndex = 2;
            buttonKitabİadeEt.Text = "Kitabı İade Et";
            buttonKitabİadeEt.UseVisualStyleBackColor = true;
            buttonKitabİadeEt.Click += buttonKitabİadeEt_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(18, 34);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 0;
            label9.Text = "Kitap ID :";
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Location = new Point(124, 215);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(100, 23);
            textBoxKitapTurKodu.TabIndex = 1;
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            dateTimePickerOduncAlmaTarihi.Format = DateTimePickerFormat.Short;
            dateTimePickerOduncAlmaTarihi.Location = new Point(112, 102);
            dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            dateTimePickerOduncAlmaTarihi.Size = new Size(100, 23);
            dateTimePickerOduncAlmaTarihi.TabIndex = 2;
            // 
            // buttonKitapOduncVer
            // 
            buttonKitapOduncVer.Location = new Point(112, 168);
            buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            buttonKitapOduncVer.Size = new Size(117, 42);
            buttonKitapOduncVer.TabIndex = 2;
            buttonKitapOduncVer.Text = "Kitabı Ödünç Ver";
            buttonKitapOduncVer.UseVisualStyleBackColor = true;
            buttonKitapOduncVer.Click += buttonKitapOduncVer_Click;
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.Location = new Point(124, 179);
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(100, 23);
            textBoxIsbn.TabIndex = 1;
            // 
            // textBoxYazarSoyadi
            // 
            textBoxYazarSoyadi.Location = new Point(124, 141);
            textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            textBoxYazarSoyadi.Size = new Size(185, 23);
            textBoxYazarSoyadi.TabIndex = 1;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Location = new Point(124, 105);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(185, 23);
            textBoxYazarAdi.TabIndex = 1;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Location = new Point(124, 68);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(185, 23);
            textBoxKitapAdi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(18, 69);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 0;
            label3.Text = "Kitap Adı :";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labelID.Location = new Point(124, 34);
            labelID.Name = "labelID";
            labelID.Size = new Size(13, 17);
            labelID.TabIndex = 0;
            labelID.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(20, 104);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 0;
            label7.Text = "Tarih :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(20, 69);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 0;
            label1.Text = "Ödünç Alan :";
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(112, 68);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(100, 23);
            textBoxOduncAlan.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dateTimePickerOduncAlmaTarihi);
            groupBox4.Controls.Add(buttonKitapOduncVer);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(textBoxOduncAlan);
            groupBox4.Location = new Point(506, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(275, 342);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Ödünç Alma";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 19);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.Size = new Size(1075, 170);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellContentClick += dataGridViewKitaplar_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(18, 216);
            label6.Name = "label6";
            label6.Size = new Size(105, 17);
            label6.TabIndex = 0;
            label6.Text = "Kitap Tür Kodu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(18, 180);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 0;
            label5.Text = "ISBN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(18, 142);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 0;
            label4.Text = "Yazar Soyadı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(18, 106);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 0;
            label2.Text = "Yazar Adı :";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewKitaplar);
            groupBox5.Location = new Point(8, 374);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1081, 192);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kitap Listesi";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(buttonKitabİadeEt);
            groupBox3.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(labelGecikmeBedeli);
            groupBox3.Location = new Point(787, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(302, 342);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxKitapTurKodu);
            groupBox1.Controls.Add(textBoxIsbn);
            groupBox1.Controls.Add(textBoxYazarSoyadi);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 342);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1096, 572);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBooks";
            Text = "Kütüphane Kitap Yönetim Sistemi";
            FormClosed += FormBooks_FormClosed;
            groupBox6.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label8;
        private GroupBox groupBox6;
        private Button buttonTemizle;
        private Button buttonKitapEkle;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonGecikmeBedeliHesapla;
        private Label label10;
        private Label labelGecikmeBedeli;
        private GroupBox groupBox2;
        private Button buttonKitapSil;
        private Button buttonAra;
        private Button buttonTumKitaplarıGoster;
        private Button buttonKitabİadeEt;
        private Label label9;
        private TextBox textBoxKitapTurKodu;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private Button buttonKitapOduncVer;
        private TextBox textBoxIsbn;
        private TextBox textBoxYazarSoyadi;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private Label label3;
        private Label labelID;
        private Label label7;
        private Label label1;
        private TextBox textBoxOduncAlan;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private GroupBox groupBox5;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
    }
}
