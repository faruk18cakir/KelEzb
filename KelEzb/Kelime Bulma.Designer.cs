namespace KelEzb
{
    partial class Kelime_Bulma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kelime_Bulma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_puan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_cevap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_tranlam = new System.Windows.Forms.Label();
            this.label_oyunSayaci = new System.Windows.Forms.Label();
            this.label_anlamı = new System.Windows.Forms.Label();
            this.label_harfKarısık = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.oyunu_kapat = new System.Windows.Forms.Button();
            this.timer_hazırlık = new System.Windows.Forms.Timer(this.components);
            this.timer_baslama = new System.Windows.Forms.Timer(this.components);
            this.label_snybaslama = new System.Windows.Forms.Label();
            this.oyunu_tekrarla = new System.Windows.Forms.Button();
            this.numericvalue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label_puan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label_cevap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_tranlam);
            this.groupBox1.Controls.Add(this.label_oyunSayaci);
            this.groupBox1.Controls.Add(this.label_anlamı);
            this.groupBox1.Controls.Add(this.label_harfKarısık);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label_puan
            // 
            this.label_puan.AutoSize = true;
            this.label_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_puan.Location = new System.Drawing.Point(631, 202);
            this.label_puan.Name = "label_puan";
            this.label_puan.Size = new System.Drawing.Size(21, 24);
            this.label_puan.TabIndex = 8;
            this.label_puan.Text = "_";
            this.label_puan.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(453, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Toplam Puanınız:";
            this.label6.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 35);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_oyuncuKelimesi_KeyDown);
            // 
            // label_cevap
            // 
            this.label_cevap.AutoSize = true;
            this.label_cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_cevap.Location = new System.Drawing.Point(21, 31);
            this.label_cevap.Name = "label_cevap";
            this.label_cevap.Size = new System.Drawing.Size(310, 25);
            this.label_cevap.TabIndex = 5;
            this.label_cevap.Text = "Kelime Yazıp Entera Basınız";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(456, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sürenin Bitimine:";
            // 
            // label_tranlam
            // 
            this.label_tranlam.AutoSize = true;
            this.label_tranlam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tranlam.Location = new System.Drawing.Point(177, 123);
            this.label_tranlam.Name = "label_tranlam";
            this.label_tranlam.Size = new System.Drawing.Size(141, 25);
            this.label_tranlam.TabIndex = 3;
            this.label_tranlam.Text = "label_turkce";
            // 
            // label_oyunSayaci
            // 
            this.label_oyunSayaci.AutoSize = true;
            this.label_oyunSayaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_oyunSayaci.Location = new System.Drawing.Point(631, 163);
            this.label_oyunSayaci.Name = "label_oyunSayaci";
            this.label_oyunSayaci.Size = new System.Drawing.Size(21, 24);
            this.label_oyunSayaci.TabIndex = 4;
            this.label_oyunSayaci.Text = "_";
            // 
            // label_anlamı
            // 
            this.label_anlamı.AutoSize = true;
            this.label_anlamı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_anlamı.Location = new System.Drawing.Point(81, 123);
            this.label_anlamı.Name = "label_anlamı";
            this.label_anlamı.Size = new System.Drawing.Size(90, 25);
            this.label_anlamı.TabIndex = 2;
            this.label_anlamı.Text = "Anlamı:";
            // 
            // label_harfKarısık
            // 
            this.label_harfKarısık.AutoSize = true;
            this.label_harfKarısık.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_harfKarısık.Location = new System.Drawing.Point(123, 212);
            this.label_harfKarısık.Name = "label_harfKarısık";
            this.label_harfKarısık.Size = new System.Drawing.Size(145, 25);
            this.label_harfKarısık.TabIndex = 1;
            this.label_harfKarısık.Text = "label_karısık";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Süre:";
            // 
            // oyunu_kapat
            // 
            this.oyunu_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunu_kapat.Location = new System.Drawing.Point(393, 347);
            this.oyunu_kapat.Name = "oyunu_kapat";
            this.oyunu_kapat.Size = new System.Drawing.Size(120, 45);
            this.oyunu_kapat.TabIndex = 1;
            this.oyunu_kapat.Text = "Oyunu Bitir";
            this.oyunu_kapat.UseVisualStyleBackColor = true;
            this.oyunu_kapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_hazırlık
            // 
            this.timer_hazırlık.Tick += new System.EventHandler(this.timer_hazırlık_Tick);
            // 
            // timer_baslama
            // 
            this.timer_baslama.Tick += new System.EventHandler(this.timer_baslama_Tick);
            // 
            // label_snybaslama
            // 
            this.label_snybaslama.AutoSize = true;
            this.label_snybaslama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_snybaslama.Location = new System.Drawing.Point(34, 9);
            this.label_snybaslama.Name = "label_snybaslama";
            this.label_snybaslama.Size = new System.Drawing.Size(389, 29);
            this.label_snybaslama.TabIndex = 3;
            this.label_snybaslama.Text = "Oyun x saniye sonra başlayacak.";
            // 
            // oyunu_tekrarla
            // 
            this.oyunu_tekrarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunu_tekrarla.Location = new System.Drawing.Point(536, 347);
            this.oyunu_tekrarla.Name = "oyunu_tekrarla";
            this.oyunu_tekrarla.Size = new System.Drawing.Size(120, 45);
            this.oyunu_tekrarla.TabIndex = 5;
            this.oyunu_tekrarla.Text = "Tekrar";
            this.oyunu_tekrarla.UseVisualStyleBackColor = true;
            this.oyunu_tekrarla.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericvalue
            // 
            this.numericvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericvalue.Location = new System.Drawing.Point(100, 354);
            this.numericvalue.Name = "numericvalue";
            this.numericvalue.Size = new System.Drawing.Size(120, 29);
            this.numericvalue.TabIndex = 9;
            this.numericvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericvalue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericvalue.ValueChanged += new System.EventHandler(this.numericvalue_ValueChanged);
            // 
            // Kelime_Bulma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(696, 403);
            this.Controls.Add(this.numericvalue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oyunu_tekrarla);
            this.Controls.Add(this.label_snybaslama);
            this.Controls.Add(this.oyunu_kapat);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kelime_Bulma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime_Bulma";
            this.Load += new System.EventHandler(this.Kelime_Bulma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_harfKarısık;
        private System.Windows.Forms.Button oyunu_kapat;
        private System.Windows.Forms.Timer timer_hazırlık;
        private System.Windows.Forms.Label label_tranlam;
        private System.Windows.Forms.Label label_anlamı;
        private System.Windows.Forms.Timer timer_baslama;
        private System.Windows.Forms.Label label_snybaslama;
        private System.Windows.Forms.Label label_oyunSayaci;
        private System.Windows.Forms.Label label_cevap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button oyunu_tekrarla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_puan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericvalue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}