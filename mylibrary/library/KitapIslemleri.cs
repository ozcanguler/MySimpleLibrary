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
    public partial class KitapIslemleri : Form
    {
        Thread th;

        MySqlConnection conn = new MySqlConnection(ConnectionDatabase.getConnectionstring);
        string sql = string.Empty;
        MySqlCommand cmd; //sorgu çalıştıracağımız nesne oluşturduk.
        public KitapIslemleri()
        {
            InitializeComponent();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtGir_TC.Text != "")
            {
                conn.Open();
                cmd = new MySqlCommand("Select KullaniciID,Adi,MaxKitap,Sinif FROM kullanici WHERE KullaniciID=@KullaniciID", conn);
                cmd.Parameters.AddWithValue("@KullaniciID", int.Parse(txtGir_TC.Text));
                MySqlDataReader dataReader = cmd.ExecuteReader();


                if (dataReader.Read())
                {

                    txtAra_TC.Text = dataReader.GetValue(0).ToString();
                    txtAra_Ad.Text = dataReader.GetValue(1).ToString();
                    txtAra_kalan.Text = dataReader.GetValue(2).ToString();
                    txtAra_sinif.Text = dataReader.GetValue(3).ToString();
                    

                }
                else
                {

                    MessageBox.Show("Kayıt Bulunamadı");
                    txtAra_TC.Text = ""; txtAra_Ad.Text = ""; txtAra_kalan.Text = ""; txtAra_sinif.Text = "";

                }



                conn.Close();
                

            }
            
            searchdatagrid(txtAra_TC.Text.ToString());
            

        }
        private void searchdatagrid(string valueToSearch)
        {
            //string sql1 = "SELECT*FROM kullanici WHERE KullaniciID=" + int.Parse(txtAra_TC.Text);
            //string sql1 = "SELECT kullanici.KullaniciID,kullanici.Adi,kullanicialdigi.KitapID,kullanicialdigi.AldigiTarih,kullanicialdigi.VerecegiTarih FROM kullanici INNER JOIN kullanicialdigi ON kullanici.KullaniciID = kullanicialdigi.KullaniciID WHERE kullanici.KullaniciID=" + int.Parse(txtAra_TC.Text);
            string sql1 = "SELECT kullanici.KullaniciID,kullanici.Adi,kullanicialdigi.KitapID,kitaplar.KitapAdi,kullanicialdigi.AldigiTarih,kullanicialdigi.VerecegiTarih FROM ((kullanici INNER JOIN kullanicialdigi ON kullanici.KullaniciID = kullanicialdigi.KullaniciID)INNER JOIN kitaplar ON kitaplar.kitapID=kullanicialdigi.kitapID) WHERE kullanici.KullaniciID=" + int.Parse(txtAra_TC.Text);


            MySqlCommand cmd2 = new MySqlCommand(sql1, conn);
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(cmd2);
            DataTable table = new DataTable();
            dataAdapter1.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void BtnKitap_Ara_Click(object sender, EventArgs e)
        {
            if (txtKitap_ID.Text != "")
            {
                conn.Open();
                cmd = new MySqlCommand("Select KitapID,KitapAdi FROM kitaplar WHERE KitapID=@KitapID", conn);
                cmd.Parameters.AddWithValue("@KitapID", int.Parse(txtKitap_ID.Text));
                MySqlDataReader dataReader = cmd.ExecuteReader();


                if (dataReader.Read())
                {

                    txtKitap_ID.Text = dataReader.GetValue(0).ToString();
                    txtKitap_Ad.Text = dataReader.GetValue(1).ToString();
                    txtKitap_AldT.Text = DateTime.Now.ToShortDateString();
 
                }
                else
                {

                    MessageBox.Show("Kayıt Bulunamadı");
                    txtKitap_ID.Text = ""; txtKitap_Ad.Text = ""; txtKitap_AldT.Text = "";

                }



                conn.Close();
            }
            
        }

        private void BtnKitap_Teslim_Click(object sender, EventArgs e)
        {
            DateTime dateValue = DateTime.Now;
            DateTime dateValue1 = txtKitap_VerT.Value;
            string MySQLFormatDate = dateValue.ToString("yyyy-MM-dd");
            string MySQLFormatDate1 = dateValue1.ToString("yyyy-MM-dd");




            // sql = "INSERT INTO kullanicialdigi(KitapID,KullaniciID,AldigiTarih,VerecegiTarih,kalankitap) VALUES('" + txtKitap_ID.Text + "','" + txtAra_TC.Text + "','" + MySQLFormatDate + "','" + MySQLFormatDate1 + "','" + (Convert.ToInt32(txtAra_kalan.Text)-1) + "')";

            conn.Open();
            // cmd = new MySqlCommand(sql, conn);

            try
            {
                //if (cmd.ExecuteNonQuery() == 1&&(Convert.ToInt32(txtAra_kalan.Text)>0))
                if (Convert.ToInt32(txtAra_kalan.Text) > 0)
                {
                    sql = "INSERT INTO kullanicialdigi(KitapID,KullaniciID,AldigiTarih,VerecegiTarih,kalankitap) VALUES('" + txtKitap_ID.Text + "','" + txtAra_TC.Text + "','" + MySQLFormatDate + "','" + MySQLFormatDate1 + "','" + (Convert.ToInt32(txtAra_kalan.Text) - 1) + "')";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlCommand cmd1 = new MySqlCommand("update kullanici set MaxKitap=MaxKitap-'" + 1 + "' where KullaniciID='" + txtAra_TC.Text + "'", conn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Kitap Teslim Edildi");
                }
                else
                {
                    MessageBox.Show("Kitap Teslim Edilemedi");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void BtnKitap_İade_Click(object sender, EventArgs e)
        {

            DialogResult dialog;
            dialog = MessageBox.Show("Bu kitabı iade etmek istiyor musunuz?", "İade İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand sql2 = new MySqlCommand("DELETE FROM kullanicialdigi WHERE KitapID=@KitapID", conn);
                sql2.Parameters.AddWithValue("@KitapID", dataGridView1.CurrentRow.Cells["KitapID"].Value.ToString());
                sql2.ExecuteNonQuery();
                MessageBox.Show("İade İşlemi Tamamlandı");
            }
            MySqlCommand cmd2 = new MySqlCommand("update kullanici set MaxKitap=MaxKitap+'" + 1 + "' where KullaniciID='" + txtAra_TC.Text + "'", conn);
                cmd2.ExecuteNonQuery();
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
                conn.Close();
                
            }

        private void BtnKitapIs_İptal_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformKitapIslemleri);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewformKitapIslemleri(object obj)
        {
            Application.Run(new Ana_Sayfa());
        }
    }
}