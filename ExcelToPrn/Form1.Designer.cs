namespace ExcelToPrn
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.txtTablo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDosya = new System.Windows.Forms.DataGridView();
            this.btnDosyaYolu = new System.Windows.Forms.Button();
            this.cmbMagaza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDosyaOku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.radioTL = new System.Windows.Forms.RadioButton();
            this.radioEuro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDosya)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Yolu :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnGoruntule);
            this.groupBox1.Controls.Add(this.btnAktar);
            this.groupBox1.Controls.Add(this.txtTablo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataDosya);
            this.groupBox1.Controls.Add(this.btnDosyaYolu);
            this.groupBox1.Controls.Add(this.cmbMagaza);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDosyaOku);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excell To Prn";
            // 
            // btnAktar
            // 
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.Location = new System.Drawing.Point(280, 273);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(592, 59);
            this.btnAktar.TabIndex = 7;
            this.btnAktar.Text = "Prn Dosyasına Yazdır";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // txtTablo
            // 
            this.txtTablo.Location = new System.Drawing.Point(547, 26);
            this.txtTablo.Name = "txtTablo";
            this.txtTablo.Size = new System.Drawing.Size(166, 20);
            this.txtTablo.TabIndex = 6;
            this.txtTablo.Text = "Sayfa1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tablo Adı :";
            // 
            // dataDosya
            // 
            this.dataDosya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDosya.Location = new System.Drawing.Point(6, 60);
            this.dataDosya.Name = "dataDosya";
            this.dataDosya.Size = new System.Drawing.Size(866, 159);
            this.dataDosya.TabIndex = 2;
            // 
            // btnDosyaYolu
            // 
            this.btnDosyaYolu.Location = new System.Drawing.Point(96, 23);
            this.btnDosyaYolu.Name = "btnDosyaYolu";
            this.btnDosyaYolu.Size = new System.Drawing.Size(365, 25);
            this.btnDosyaYolu.TabIndex = 4;
            this.btnDosyaYolu.Text = "...";
            this.btnDosyaYolu.UseVisualStyleBackColor = true;
            this.btnDosyaYolu.Click += new System.EventHandler(this.btnDosyaYolu_Click);
            // 
            // cmbMagaza
            // 
            this.cmbMagaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMagaza.FormattingEnabled = true;
            this.cmbMagaza.Location = new System.Drawing.Point(96, 234);
            this.cmbMagaza.Name = "cmbMagaza";
            this.cmbMagaza.Size = new System.Drawing.Size(365, 21);
            this.cmbMagaza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mağaza Yeri :";
            // 
            // btnDosyaOku
            // 
            this.btnDosyaOku.Location = new System.Drawing.Point(732, 17);
            this.btnDosyaOku.Name = "btnDosyaOku";
            this.btnDosyaOku.Size = new System.Drawing.Size(140, 37);
            this.btnDosyaOku.TabIndex = 1;
            this.btnDosyaOku.Text = "Dosyayı Oku";
            this.btnDosyaOku.UseVisualStyleBackColor = true;
            this.btnDosyaOku.Click += new System.EventHandler(this.btnDosyaOku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(507, 231);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(365, 25);
            this.btnGoruntule.TabIndex = 8;
            this.btnGoruntule.Text = "Kaydedilecek Dosya Seç";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // radioTL
            // 
            this.radioTL.AutoSize = true;
            this.radioTL.Checked = true;
            this.radioTL.Location = new System.Drawing.Point(12, 19);
            this.radioTL.Name = "radioTL";
            this.radioTL.Size = new System.Drawing.Size(38, 17);
            this.radioTL.TabIndex = 9;
            this.radioTL.TabStop = true;
            this.radioTL.Text = "TL";
            this.radioTL.UseVisualStyleBackColor = true;
            // 
            // radioEuro
            // 
            this.radioEuro.AutoSize = true;
            this.radioEuro.Location = new System.Drawing.Point(99, 19);
            this.radioEuro.Name = "radioEuro";
            this.radioEuro.Size = new System.Drawing.Size(47, 17);
            this.radioEuro.TabIndex = 10;
            this.radioEuro.Text = "Euro";
            this.radioEuro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioTL);
            this.groupBox2.Controls.Add(this.radioEuro);
            this.groupBox2.Location = new System.Drawing.Point(96, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 45);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Birimi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 391);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDosya)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDosyaYolu;
        private System.Windows.Forms.ComboBox cmbMagaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDosyaOku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataDosya;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.TextBox txtTablo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioTL;
        private System.Windows.Forms.RadioButton radioEuro;
    }
}

