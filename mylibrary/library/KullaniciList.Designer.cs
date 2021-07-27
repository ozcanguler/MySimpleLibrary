namespace library
{
    partial class KullaniciList
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlist_ID = new System.Windows.Forms.TextBox();
            this.txtlist_Ad = new System.Windows.Forms.TextBox();
            this.txtlist_Tel = new System.Windows.Forms.TextBox();
            this.cmblist_sinif = new System.Windows.Forms.ComboBox();
            this.btnlist_Guncel = new System.Windows.Forms.Button();
            this.btnlist_Sil = new System.Windows.Forms.Button();
            this.btnlist_ipt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtList_TcAra = new System.Windows.Forms.TextBox();
            this.btnList_Ara = new System.Windows.Forms.Button();
            this.btnList_Goster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sınıf";
            // 
            // txtlist_ID
            // 
            this.txtlist_ID.Location = new System.Drawing.Point(94, 201);
            this.txtlist_ID.Name = "txtlist_ID";
            this.txtlist_ID.Size = new System.Drawing.Size(121, 20);
            this.txtlist_ID.TabIndex = 5;
            // 
            // txtlist_Ad
            // 
            this.txtlist_Ad.Location = new System.Drawing.Point(94, 243);
            this.txtlist_Ad.Name = "txtlist_Ad";
            this.txtlist_Ad.Size = new System.Drawing.Size(121, 20);
            this.txtlist_Ad.TabIndex = 6;
            // 
            // txtlist_Tel
            // 
            this.txtlist_Tel.Location = new System.Drawing.Point(94, 284);
            this.txtlist_Tel.Name = "txtlist_Tel";
            this.txtlist_Tel.Size = new System.Drawing.Size(121, 20);
            this.txtlist_Tel.TabIndex = 7;
            // 
            // cmblist_sinif
            // 
            this.cmblist_sinif.FormattingEnabled = true;
            this.cmblist_sinif.Items.AddRange(new object[] {
            "Tam",
            "Öğrenci"});
            this.cmblist_sinif.Location = new System.Drawing.Point(94, 325);
            this.cmblist_sinif.Name = "cmblist_sinif";
            this.cmblist_sinif.Size = new System.Drawing.Size(121, 21);
            this.cmblist_sinif.TabIndex = 8;
            // 
            // btnlist_Guncel
            // 
            this.btnlist_Guncel.Location = new System.Drawing.Point(54, 377);
            this.btnlist_Guncel.Name = "btnlist_Guncel";
            this.btnlist_Guncel.Size = new System.Drawing.Size(75, 23);
            this.btnlist_Guncel.TabIndex = 9;
            this.btnlist_Guncel.Text = "Güncelle";
            this.btnlist_Guncel.UseVisualStyleBackColor = true;
            this.btnlist_Guncel.Click += new System.EventHandler(this.Btnlist_Guncel_Click);
            // 
            // btnlist_Sil
            // 
            this.btnlist_Sil.Location = new System.Drawing.Point(628, 297);
            this.btnlist_Sil.Name = "btnlist_Sil";
            this.btnlist_Sil.Size = new System.Drawing.Size(75, 23);
            this.btnlist_Sil.TabIndex = 10;
            this.btnlist_Sil.Text = "Sil";
            this.btnlist_Sil.UseVisualStyleBackColor = true;
            this.btnlist_Sil.Click += new System.EventHandler(this.Btnlist_Sil_Click);
            // 
            // btnlist_ipt
            // 
            this.btnlist_ipt.Location = new System.Drawing.Point(186, 376);
            this.btnlist_ipt.Name = "btnlist_ipt";
            this.btnlist_ipt.Size = new System.Drawing.Size(75, 23);
            this.btnlist_ipt.TabIndex = 11;
            this.btnlist_ipt.Text = "İptal";
            this.btnlist_ipt.UseVisualStyleBackColor = true;
            this.btnlist_ipt.Click += new System.EventHandler(this.Btnlist_ipt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Arama İçin TC Girin";
            // 
            // txtList_TcAra
            // 
            this.txtList_TcAra.Location = new System.Drawing.Point(107, 38);
            this.txtList_TcAra.Name = "txtList_TcAra";
            this.txtList_TcAra.Size = new System.Drawing.Size(119, 20);
            this.txtList_TcAra.TabIndex = 13;
            this.txtList_TcAra.TextChanged += new System.EventHandler(this.TxtList_TcAra_TextChanged);
            // 
            // btnList_Ara
            // 
            this.btnList_Ara.Location = new System.Drawing.Point(128, 87);
            this.btnList_Ara.Name = "btnList_Ara";
            this.btnList_Ara.Size = new System.Drawing.Size(75, 23);
            this.btnList_Ara.TabIndex = 14;
            this.btnList_Ara.Text = "Ara";
            this.btnList_Ara.UseVisualStyleBackColor = true;
            this.btnList_Ara.Click += new System.EventHandler(this.BtnList_Ara_Click);
            // 
            // btnList_Goster
            // 
            this.btnList_Goster.Location = new System.Drawing.Point(26, 87);
            this.btnList_Goster.Name = "btnList_Goster";
            this.btnList_Goster.Size = new System.Drawing.Size(75, 23);
            this.btnList_Goster.TabIndex = 15;
            this.btnList_Goster.Text = "Listele";
            this.btnList_Goster.UseVisualStyleBackColor = true;
            this.btnList_Goster.Click += new System.EventHandler(this.BtnList_Goster_Click);
            // 
            // KullaniciList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnList_Goster);
            this.Controls.Add(this.btnList_Ara);
            this.Controls.Add(this.txtList_TcAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnlist_ipt);
            this.Controls.Add(this.btnlist_Sil);
            this.Controls.Add(this.btnlist_Guncel);
            this.Controls.Add(this.cmblist_sinif);
            this.Controls.Add(this.txtlist_Tel);
            this.Controls.Add(this.txtlist_Ad);
            this.Controls.Add(this.txtlist_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullaniciList";
            this.Text = "KullaniciList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlist_ID;
        private System.Windows.Forms.TextBox txtlist_Ad;
        private System.Windows.Forms.TextBox txtlist_Tel;
        private System.Windows.Forms.ComboBox cmblist_sinif;
        private System.Windows.Forms.Button btnlist_Guncel;
        private System.Windows.Forms.Button btnlist_Sil;
        private System.Windows.Forms.Button btnlist_ipt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtList_TcAra;
        private System.Windows.Forms.Button btnList_Ara;
        private System.Windows.Forms.Button btnList_Goster;
    }
}