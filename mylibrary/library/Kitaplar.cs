using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace library
{
    public partial class Kitaplar : Form
    {
        Thread th;

        MySqlConnection conn = new MySqlConnection(ConnectionDatabase.getConnectionstring);
        string sql = string.Empty;
        MySqlCommand cmd; //sorgu çalıştıracağımız nesne oluşturduk.
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void BtnKitap_Ekle_Click(object sender, EventArgs e)
        {
            
            sql = "INSERT INTO kitaplar(KitapAdi,Tur,Yazar) VALUES('" + txtKitap_Ad.Text + "','" + cmbEkle_Tur.Text + "','" + txtEkle_Yazar.Text + "')";
            conn.Open();
            cmd = new MySqlCommand(sql, conn);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kitap Eklendi" );
                }
                else
                {
                    MessageBox.Show("Kitap Eklenemedi");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        private void searchdatagrid(string valueToSearch)
        {
            string sql1 = "SELECT*FROM kitaplar WHERE KitapAdi LIKE'" + txtKitapAra_Name.Text + "%'";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(cmd1);
            DataTable table = new DataTable();
            dataAdapter1.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void TxtKitapAra_Name_TextChanged(object sender, EventArgs e)
        {

            searchdatagrid(txtKitapAra_Name.Text.ToString());
        }

        private void BtnKitap_cancel_Click(object sender, EventArgs e)
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
