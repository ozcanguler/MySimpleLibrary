namespace library
{
    partial class Kitaplar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAra_Name = new System.Windows.Forms.TextBox();
            this.txtKitap_Ad = new System.Windows.Forms.TextBox();
            this.btnKitap_Ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEkle_Tur = new System.Windows.Forms.ComboBox();
            this.txtEkle_Yazar = new System.Windows.Forms.TextBox();
            this.btnKitap_cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KitapAdı";
            // 
            // txtKitapAra_Name
            // 
            this.txtKitapAra_Name.Location = new System.Drawing.Point(110, 51);
            this.txtKitapAra_Name.Name = "txtKitapAra_Name";
            this.txtKitapAra_Name.Size = new System.Drawing.Size(121, 20);
            this.txtKitapAra_Name.TabIndex = 2;
            this.txtKitapAra_Name.TextChanged += new System.EventHandler(this.TxtKitapAra_Name_TextChanged);
            // 
            // txtKitap_Ad
            // 
            this.txtKitap_Ad.Location = new System.Drawing.Point(110, 215);
            this.txtKitap_Ad.Name = "txtKitap_Ad";
            this.txtKitap_Ad.Size = new System.Drawing.Size(121, 20);
            this.txtKitap_Ad.TabIndex = 3;
            // 
            // btnKitap_Ekle
            // 
            this.btnKitap_Ekle.Location = new System.Drawing.Point(53, 393);
            this.btnKitap_Ekle.Name = "btnKitap_Ekle";
            this.btnKitap_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btnKitap_Ekle.TabIndex = 4;
            this.btnKitap_Ekle.Text = "Ekle";
            this.btnKitap_Ekle.UseVisualStyleBackColor = true;
            this.btnKitap_Ekle.Click += new System.EventHandler(this.BtnKitap_Ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yazarı";
            // 
            // cmbEkle_Tur
            // 
            this.cmbEkle_Tur.FormattingEnabled = true;
            this.cmbEkle_Tur.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Şiir",
            "Anı"});
            this.cmbEkle_Tur.Location = new System.Drawing.Point(110, 259);
            this.cmbEkle_Tur.Name = "cmbEkle_Tur";
            this.cmbEkle_Tur.Size = new System.Drawing.Size(121, 21);
            this.cmbEkle_Tur.TabIndex = 7;
            // 
            // txtEkle_Yazar
            // 
            this.txtEkle_Yazar.Location = new System.Drawing.Point(110, 301);
            this.txtEkle_Yazar.Name = "txtEkle_Yazar";
            this.txtEkle_Yazar.Size = new System.Drawing.Size(121, 20);
            this.txtEkle_Yazar.TabIndex = 8;
            // 
            // btnKitap_cancel
            // 
            this.btnKitap_cancel.Location = new System.Drawing.Point(182, 393);
            this.btnKitap_cancel.Name = "btnKitap_cancel";
            this.btnKitap_cancel.Size = new System.Drawing.Size(75, 23);
            this.btnKitap_cancel.TabIndex = 9;
            this.btnKitap_cancel.Text = "İptal";
            this.btnKitap_cancel.UseVisualStyleBackColor = true;
            this.btnKitap_cancel.Click += new System.EventHandler(this.BtnKitap_cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(517, 252);
            this.dataGridView1.TabIndex = 10;
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKitap_cancel);
            this.Controls.Add(this.txtEkle_Yazar);
            this.Controls.Add(this.cmbEkle_Tur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKitap_Ekle);
            this.Controls.Add(this.txtKitap_Ad);
            this.Controls.Add(this.txtKitapAra_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapAra_Name;
        private System.Windows.Forms.TextBox txtKitap_Ad;
        private System.Windows.Forms.Button btnKitap_Ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEkle_Tur;
        private System.Windows.Forms.TextBox txtEkle_Yazar;
        private System.Windows.Forms.Button btnKitap_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}