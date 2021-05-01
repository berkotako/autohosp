namespace HastaneOtomasyonu_YM
{
    partial class Form1
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
            this.btnSistKilit = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRecete = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTakvim = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.btnhastalar = new System.Windows.Forms.Button();
            this.btnDoktorlar = new System.Windows.Forms.Button();
            this.btnKlinik = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSistKilit);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSistKilit
            // 
            this.btnSistKilit.Location = new System.Drawing.Point(76, 108);
            this.btnSistKilit.Name = "btnSistKilit";
            this.btnSistKilit.Size = new System.Drawing.Size(98, 27);
            this.btnSistKilit.TabIndex = 8;
            this.btnSistKilit.Text = "Sistemi Kilitle";
            this.btnSistKilit.UseVisualStyleBackColor = true;
            this.btnSistKilit.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(76, 75);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(98, 27);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parola:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(387, 180);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1111, 656);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("https://covid19.saglik.gov.tr/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(387, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 162);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genel Bilgiler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kayıtlı Randevu Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Website:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kayıtlı Hasta Sayısı:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kayıtlı Doktor Sayısı:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 849);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(482, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "AutoHosp | Automation Systems v1.0";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(173, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 56);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnRecete
            // 
            this.btnRecete.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Checklist_Report_Flat_Style_Icon;
            this.btnRecete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecete.ForeColor = System.Drawing.Color.Black;
            this.btnRecete.Location = new System.Drawing.Point(173, 380);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(155, 56);
            this.btnRecete.TabIndex = 18;
            this.btnRecete.Text = "Reçete İşlemleri";
            this.btnRecete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecete.UseVisualStyleBackColor = true;
            this.btnRecete.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Checklist_Report_Flat_Style_Icon;
            this.btnRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.ForeColor = System.Drawing.Color.Black;
            this.btnRapor.Location = new System.Drawing.Point(173, 318);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(155, 56);
            this.btnRapor.TabIndex = 17;
            this.btnRapor.Text = "Rapor İşlemleri";
            this.btnRapor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Digital_Coin_Icon_Flat_Design;
            this.btnOdeme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdeme.ForeColor = System.Drawing.Color.Black;
            this.btnOdeme.Location = new System.Drawing.Point(173, 256);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(155, 56);
            this.btnOdeme.TabIndex = 16;
            this.btnOdeme.Text = "Ödeme İşlemleri";
            this.btnOdeme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneOtomasyonu_YM.Properties.Resources.Black_and_White_Photographer_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnTakvim
            // 
            this.btnTakvim.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Isolated_Calendar_Icon_Flat_Design;
            this.btnTakvim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTakvim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakvim.ForeColor = System.Drawing.Color.Black;
            this.btnTakvim.Location = new System.Drawing.Point(173, 194);
            this.btnTakvim.Name = "btnTakvim";
            this.btnTakvim.Size = new System.Drawing.Size(155, 56);
            this.btnTakvim.TabIndex = 12;
            this.btnTakvim.Text = "Genel Takvim";
            this.btnTakvim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTakvim.UseVisualStyleBackColor = true;
            this.btnTakvim.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Gears_Settings_Machine_Line_Icon;
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.Black;
            this.btnAyarlar.Location = new System.Drawing.Point(12, 442);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(155, 56);
            this.btnAyarlar.TabIndex = 10;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Health_Calendar_Reminder_Free_Form_Style_Icon;
            this.btnRandevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandevu.ForeColor = System.Drawing.Color.Black;
            this.btnRandevu.Location = new System.Drawing.Point(12, 380);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(155, 56);
            this.btnRandevu.TabIndex = 3;
            this.btnRandevu.Text = "Randevu İşlemleri";
            this.btnRandevu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnhastalar
            // 
            this.btnhastalar.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Isolated_Medical_Heart_Icon_Flat_Design;
            this.btnhastalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhastalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhastalar.ForeColor = System.Drawing.Color.Black;
            this.btnhastalar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhastalar.Location = new System.Drawing.Point(12, 318);
            this.btnhastalar.Name = "btnhastalar";
            this.btnhastalar.Size = new System.Drawing.Size(155, 56);
            this.btnhastalar.TabIndex = 2;
            this.btnhastalar.Text = "Hasta  İşlemleri";
            this.btnhastalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhastalar.UseVisualStyleBackColor = true;
            this.btnhastalar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDoktorlar
            // 
            this.btnDoktorlar.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Doctor_Woman_Professional___Person_Flat_Design_Icon;
            this.btnDoktorlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoktorlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoktorlar.ForeColor = System.Drawing.Color.Black;
            this.btnDoktorlar.Location = new System.Drawing.Point(12, 256);
            this.btnDoktorlar.Name = "btnDoktorlar";
            this.btnDoktorlar.Size = new System.Drawing.Size(155, 56);
            this.btnDoktorlar.TabIndex = 1;
            this.btnDoktorlar.Text = "Doktor İşlemleri";
            this.btnDoktorlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoktorlar.UseVisualStyleBackColor = true;
            this.btnDoktorlar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKlinik
            // 
            this.btnKlinik.BackgroundImage = global::HastaneOtomasyonu_YM.Properties.Resources.Canva___Bank_Structure_with_Calendar_Block_Style_Icon;
            this.btnKlinik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKlinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlinik.ForeColor = System.Drawing.Color.Black;
            this.btnKlinik.Location = new System.Drawing.Point(12, 194);
            this.btnKlinik.Name = "btnKlinik";
            this.btnKlinik.Size = new System.Drawing.Size(155, 56);
            this.btnKlinik.TabIndex = 0;
            this.btnKlinik.Text = "Klinik İşlemleri";
            this.btnKlinik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKlinik.UseVisualStyleBackColor = true;
            this.btnKlinik.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1510, 882);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRecete);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTakvim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.btnhastalar);
            this.Controls.Add(this.btnDoktorlar);
            this.Controls.Add(this.btnKlinik);
            this.Name = "Form1";
            this.Text = "Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKlinik;
        private System.Windows.Forms.Button btnDoktorlar;
        private System.Windows.Forms.Button btnhastalar;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTakvim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSistKilit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.Button btnExit;
    }
}

