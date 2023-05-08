namespace Kitaplik
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapid = new System.Windows.Forms.TextBox();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.rbKullanilmis = new System.Windows.Forms.RadioButton();
            this.rbSifir = new System.Windows.Forms.RadioButton();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap id:";
            // 
            // txtKitapid
            // 
            this.txtKitapid.Enabled = false;
            this.txtKitapid.Location = new System.Drawing.Point(157, 28);
            this.txtKitapid.Name = "txtKitapid";
            this.txtKitapid.Size = new System.Drawing.Size(240, 34);
            this.txtKitapid.TabIndex = 1;
            // 
            // cbTur
            // 
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.cbTur.Location = new System.Drawing.Point(157, 234);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(240, 35);
            this.cbTur.TabIndex = 5;
            // 
            // rbKullanilmis
            // 
            this.rbKullanilmis.AutoSize = true;
            this.rbKullanilmis.Location = new System.Drawing.Point(157, 287);
            this.rbKullanilmis.Name = "rbKullanilmis";
            this.rbKullanilmis.Size = new System.Drawing.Size(153, 31);
            this.rbKullanilmis.TabIndex = 4;
            this.rbKullanilmis.TabStop = true;
            this.rbKullanilmis.Text = "Kullanılmış";
            this.rbKullanilmis.UseVisualStyleBackColor = true;
            // 
            // rbSifir
            // 
            this.rbSifir.AutoSize = true;
            this.rbSifir.Location = new System.Drawing.Point(321, 287);
            this.rbSifir.Name = "rbSifir";
            this.rbSifir.Size = new System.Drawing.Size(76, 31);
            this.rbSifir.TabIndex = 7;
            this.rbSifir.TabStop = true;
            this.rbSifir.Text = "Sıfır";
            this.rbSifir.UseVisualStyleBackColor = true;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(157, 79);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(240, 34);
            this.txtKitapAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Ad:";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(157, 132);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(240, 34);
            this.txtYazarAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yazar:";
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(157, 181);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(240, 34);
            this.txtSayfa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sayfa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tür:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Durum:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(467, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 47);
            this.button4.TabIndex = 11;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(498, 282);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(158, 34);
            this.txtBul.TabIndex = 15;
            this.txtBul.TextChanged += new System.EventHandler(this.txtBul_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(414, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kitap Ad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(690, 615);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSifir);
            this.Controls.Add(this.rbKullanilmis);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.txtKitapid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapid;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.RadioButton rbKullanilmis;
        private System.Windows.Forms.RadioButton rbSifir;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Label label7;
    }
}

