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
    public partial class Ana_Sayfa : Form
    {
        Thread th;
        public Ana_Sayfa()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            //Form1 Myform1 = new Form1();
            //   Myform1.Show();
            
            
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form1());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformKitaplar);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewformKitaplar(object obj)
        {
            Application.Run(new Kitaplar());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformKullaniciList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }       
         private void opennewformKullaniciList(object obj)
        {
            Application.Run(new KullaniciList());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewformKitapAlVer);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewformKitapAlVer(object obj)
        {
            Application.Run(new KitapIslemleri());
        }

    }
}
