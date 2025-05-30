namespace BANKAOTO
{
    partial class Musteriislem
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
            this.btnHesapH = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSifre = new System.Windows.Forms.Button();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHesapH);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnSifre);
            this.groupBox1.Controls.Add(this.btnHavale);
            this.groupBox1.Controls.Add(this.btnParaYatir);
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Location = new System.Drawing.Point(150, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 483);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // btnHesapH
            // 
            this.btnHesapH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHesapH.Location = new System.Drawing.Point(176, 285);
            this.btnHesapH.Name = "btnHesapH";
            this.btnHesapH.Size = new System.Drawing.Size(207, 34);
            this.btnHesapH.TabIndex = 7;
            this.btnHesapH.Text = "Hesap Hareketleri";
            this.btnHesapH.UseVisualStyleBackColor = true;
            this.btnHesapH.Click += new System.EventHandler(this.btnHesapH_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Red;
            this.btnCikis.Location = new System.Drawing.Point(176, 370);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(207, 34);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSifre
            // 
            this.btnSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSifre.Location = new System.Drawing.Point(176, 226);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(207, 34);
            this.btnSifre.TabIndex = 5;
            this.btnSifre.Text = "Şifre Değiştir";
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // btnHavale
            // 
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHavale.Location = new System.Drawing.Point(176, 162);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(207, 34);
            this.btnHavale.TabIndex = 4;
            this.btnHavale.Text = "Havale / Eft";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParaYatir.Location = new System.Drawing.Point(176, 100);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(207, 39);
            this.btnParaYatir.TabIndex = 2;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParaCek.Location = new System.Drawing.Point(176, 36);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(207, 41);
            this.btnParaCek.TabIndex = 1;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(147, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblAdSoyad.Location = new System.Drawing.Point(279, 19);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(18, 25);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = ".";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNo.ForeColor = System.Drawing.Color.Red;
            this.lblHesapNo.Location = new System.Drawing.Point(279, 45);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(18, 25);
            this.lblHesapNo.TabIndex = 6;
            this.lblHesapNo.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(147, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hesap No:";
            // 
            // Musteriislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 568);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Musteriislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.Musteriislem_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnHesapH;
    }
}