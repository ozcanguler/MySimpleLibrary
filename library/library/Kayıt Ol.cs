using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace library
{
    public partial class Form1 : Form
    {
        Thread th;

        MySqlConnection conn = new MySqlConnection(ConnectionDatabase.getConnectionstring);
        string sql = string.Empty;
        MySqlCommand cmd; //sorgu çalıştıracağımız nesne oluşturduk.
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnRegister_Add_Click(object sender, EventArgs e)
        {
            int kitapsayisi = 5;
            DateTime dateValue = DateTime.Now;
            string MySQLFormatDate = dateValue.ToString("yyyy-MM-dd");
            if (cmbbox_Class.Text == "Tam") kitapsayisi = 3; 
            sql = "INSERT INTO kullanici VALUES('" + txtRegis_ID.Text + "','" + txtRegis_name.Text + "','" + txtRegis_phone.Text + "','" + cmbbox_Class.Text + "','" + MySQLFormatDate + "','" + kitapsayisi + "')";
            conn.Open();
            cmd = new MySqlCommand(sql, conn);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Eklendi" + DateTime.Now.ToShortDateString());
                }
                else
                {
                    MessageBox.Show("Kayıt Eklenemedi");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }           
                conn.Close();
        }

        private void BtnRegister_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Ana_Sayfa());
        }
    }
}
