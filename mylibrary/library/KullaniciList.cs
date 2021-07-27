using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Threading;
namespace library
{
    public partial class KullaniciList : Form
    {

        Thread th;
        MySqlConnection conn = new MySqlConnection(ConnectionDatabase.getConnectionstring);
        string sql = string.Empty;
        MySqlCommand cmd; //sorgu çalıştıracağımız nesne oluşturduk.
        
        public KullaniciList()
        {
            InitializeComponent();
        }

        private void TxtList_TcAra_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void BtnList_Ara_Click(object sender, EventArgs e)
        {
            if (txtList_TcAra.Text != "")
            {
                conn.Open();
                cmd = new MySqlCommand("Select KullaniciID,Adi,Tel,Sinif FROM kullanici WHERE KullaniciID=@KullaniciID", conn);
                cmd.Parameters.AddWithValue("@KullaniciID", int.Parse(txtList_TcAra.Text));
                MySqlDataReader dataReader = cmd.ExecuteReader();
               

                if (dataReader.Read())
                {
                    
                    txtlist_ID.Text = dataReader.GetValue(0).ToString();
                        txtlist_Ad.Text = dataReader.GetValue(1).ToString();
                        txtlist_Tel.Text = dataReader.GetValue(2).ToString();
                        cmblist_sinif.Text = dataReader.GetValue(3).ToString();
                   

                }
                    else 
                    {

                    MessageBox.Show("Kayıt Bulunamadı");
                        txtlist_ID.Text = ""; txtlist_Ad.Text = ""; txtlist_Tel.Text = ""; cmblist_sinif.Text = "";
                        
                    }

                

                conn.Close();
            }
        }
        private void searchdatagrid(string valueToSearch)
        {
           string sql1= "SELECT*FROM kullanici WHERE KullaniciID="+ int.Parse(txtList_TcAra.Text);
            MySqlCommand cmd1 = new MySqlCommand(sql1,conn);
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(cmd1);
            DataTable table = new DataTable();
            dataAdapter1.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Btnlist_Guncel_Click(object sender, EventArgs e)
        {
            int kitapsayisi = 5;
            DateTime dateValue = DateTime.Now;
            string MySQLFormatDate = dateValue.ToString("yyyy-MM-dd");
            if (cmblist_sinif.Text == "Tam") kitapsayisi = 3;
            sql = "UPDATE kullanici SET KullaniciID='" + txtlist_ID.Text + "',Adi='" + txtlist_Ad.Text + "',Tel='" + txtlist_Tel.Text + "',Sinif='" + cmblist_sinif.Text + "',KayitTarih='" + MySQLFormatDate + "',MaxKitap='" + kitapsayisi + "'WHERE KullaniciID="+ int.Parse(txtList_TcAra.Text);
            conn.Open();
            cmd = new MySqlCommand(sql, conn);

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                }
                else
                {
                    MessageBox.Show("Kayıt Güncelleme Başarısız");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void BtnList_Goster_Click(object sender, EventArgs e)
        {
            searchdatagrid(txtList_TcAra.Text.ToString());
        }

        private void Btnlist_ipt_Click(object sender, EventArgs e)
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

        private void Btnlist_Sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand sql2 = new MySqlCommand("DELETE FROM kullanici WHERE KullaniciID=@KullaniciID", conn);
                sql2.Parameters.AddWithValue("@KullaniciID", dataGridView1.CurrentRow.Cells["KullaniciID"].Value.ToString());
                sql2.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi");
            }
            //MySqlCommand cmd2 = new MySqlCommand("update kullanici set MaxKitap=MaxKitap+'" + 1 + "' where KullaniciID='" + txtAra_TC.Text + "'", conn);
            //cmd2.ExecuteNonQuery();
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);
            conn.Close();

        }
    }
    }

