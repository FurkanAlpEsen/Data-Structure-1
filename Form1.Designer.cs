namespace Ödev1Beta
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.aracListe = new System.Windows.Forms.ListBox();
            this.btnSureOrt = new System.Windows.Forms.Button();
            this.listOncelik = new System.Windows.Forms.ListBox();
            this.btnOncelikSirala = new System.Windows.Forms.Button();
            this.btnOCikar = new System.Windows.Forms.Button();
            this.btnOSureOtr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otopark İşlemleri";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 45);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(99, 49);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Araç Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(119, 45);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(99, 49);
            this.btnCikar.TabIndex = 3;
            this.btnCikar.Text = "Araç Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // aracListe
            // 
            this.aracListe.FormattingEnabled = true;
            this.aracListe.Location = new System.Drawing.Point(12, 112);
            this.aracListe.Name = "aracListe";
            this.aracListe.Size = new System.Drawing.Size(335, 173);
            this.aracListe.TabIndex = 4;
            // 
            // btnSureOrt
            // 
            this.btnSureOrt.Location = new System.Drawing.Point(224, 45);
            this.btnSureOrt.Name = "btnSureOrt";
            this.btnSureOrt.Size = new System.Drawing.Size(99, 49);
            this.btnSureOrt.TabIndex = 5;
            this.btnSureOrt.Text = "İşlem Süre Ortalamaları";
            this.btnSureOrt.UseVisualStyleBackColor = true;
            this.btnSureOrt.Click += new System.EventHandler(this.btnSureOrt_Click);
            // 
            // listOncelik
            // 
            this.listOncelik.FormattingEnabled = true;
            this.listOncelik.Location = new System.Drawing.Point(383, 112);
            this.listOncelik.Name = "listOncelik";
            this.listOncelik.Size = new System.Drawing.Size(317, 173);
            this.listOncelik.TabIndex = 6;
            // 
            // btnOncelikSirala
            // 
            this.btnOncelikSirala.Location = new System.Drawing.Point(383, 46);
            this.btnOncelikSirala.Name = "btnOncelikSirala";
            this.btnOncelikSirala.Size = new System.Drawing.Size(99, 49);
            this.btnOncelikSirala.TabIndex = 7;
            this.btnOncelikSirala.Text = "Öncelikli Sıralama";
            this.btnOncelikSirala.UseVisualStyleBackColor = true;
            this.btnOncelikSirala.Click += new System.EventHandler(this.btnOncelikSirala_Click);
            // 
            // btnOCikar
            // 
            this.btnOCikar.Location = new System.Drawing.Point(502, 48);
            this.btnOCikar.Name = "btnOCikar";
            this.btnOCikar.Size = new System.Drawing.Size(99, 47);
            this.btnOCikar.TabIndex = 8;
            this.btnOCikar.Text = "Araç Çıkar";
            this.btnOCikar.UseVisualStyleBackColor = true;
            this.btnOCikar.Click += new System.EventHandler(this.btnOCikar_Click);
            // 
            // btnOSureOtr
            // 
            this.btnOSureOtr.Location = new System.Drawing.Point(607, 48);
            this.btnOSureOtr.Name = "btnOSureOtr";
            this.btnOSureOtr.Size = new System.Drawing.Size(99, 47);
            this.btnOSureOtr.TabIndex = 9;
            this.btnOSureOtr.Text = "Öncelikli İşlem Ortalama";
            this.btnOSureOtr.UseVisualStyleBackColor = true;
            this.btnOSureOtr.Click += new System.EventHandler(this.btnOSureOtr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 290);
            this.Controls.Add(this.btnOSureOtr);
            this.Controls.Add(this.btnOCikar);
            this.Controls.Add(this.btnOncelikSirala);
            this.Controls.Add(this.listOncelik);
            this.Controls.Add(this.btnSureOrt);
            this.Controls.Add(this.aracListe);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.ListBox aracListe;
        private System.Windows.Forms.Button btnSureOrt;
        private System.Windows.Forms.ListBox listOncelik;
        private System.Windows.Forms.Button btnOncelikSirala;
        private System.Windows.Forms.Button btnOCikar;
        private System.Windows.Forms.Button btnOSureOtr;
    }
}

