namespace library
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegis_ID = new System.Windows.Forms.TextBox();
            this.txtRegis_name = new System.Windows.Forms.TextBox();
            this.txtRegis_phone = new System.Windows.Forms.TextBox();
            this.btnRegister_Add = new System.Windows.Forms.Button();
            this.btnRegister_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbox_Class = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel";
            // 
            // txtRegis_ID
            // 
            this.txtRegis_ID.Location = new System.Drawing.Point(163, 117);
            this.txtRegis_ID.Name = "txtRegis_ID";
            this.txtRegis_ID.Size = new System.Drawing.Size(121, 20);
            this.txtRegis_ID.TabIndex = 3;
            // 
            // txtRegis_name
            // 
            this.txtRegis_name.Location = new System.Drawing.Point(163, 164);
            this.txtRegis_name.Name = "txtRegis_name";
            this.txtRegis_name.Size = new System.Drawing.Size(121, 20);
            this.txtRegis_name.TabIndex = 4;
            // 
            // txtRegis_phone
            // 
            this.txtRegis_phone.Location = new System.Drawing.Point(163, 211);
            this.txtRegis_phone.Name = "txtRegis_phone";
            this.txtRegis_phone.Size = new System.Drawing.Size(121, 20);
            this.txtRegis_phone.TabIndex = 5;
            // 
            // btnRegister_Add
            // 
            this.btnRegister_Add.Location = new System.Drawing.Point(107, 335);
            this.btnRegister_Add.Name = "btnRegister_Add";
            this.btnRegister_Add.Size = new System.Drawing.Size(75, 23);
            this.btnRegister_Add.TabIndex = 6;
            this.btnRegister_Add.Text = "Kayıt Ol";
            this.btnRegister_Add.UseVisualStyleBackColor = true;
            this.btnRegister_Add.Click += new System.EventHandler(this.BtnRegister_Add_Click);
            // 
            // btnRegister_Cancel
            // 
            this.btnRegister_Cancel.Location = new System.Drawing.Point(212, 335);
            this.btnRegister_Cancel.Name = "btnRegister_Cancel";
            this.btnRegister_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btnRegister_Cancel.TabIndex = 7;
            this.btnRegister_Cancel.Text = "İptal";
            this.btnRegister_Cancel.UseVisualStyleBackColor = true;
            this.btnRegister_Cancel.Click += new System.EventHandler(this.BtnRegister_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sınıf";
            // 
            // cmbbox_Class
            // 
            this.cmbbox_Class.FormattingEnabled = true;
            this.cmbbox_Class.Items.AddRange(new object[] {
            "Tam",
            "Öğrenci"});
            this.cmbbox_Class.Location = new System.Drawing.Point(163, 261);
            this.cmbbox_Class.Name = "cmbbox_Class";
            this.cmbbox_Class.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Class.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbbox_Class);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegister_Cancel);
            this.Controls.Add(this.btnRegister_Add);
            this.Controls.Add(this.txtRegis_phone);
            this.Controls.Add(this.txtRegis_name);
            this.Controls.Add(this.txtRegis_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegis_ID;
        private System.Windows.Forms.TextBox txtRegis_name;
        private System.Windows.Forms.TextBox txtRegis_phone;
        private System.Windows.Forms.Button btnRegister_Add;
        private System.Windows.Forms.Button btnRegister_Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbox_Class;
    }
}

