using DiyetisyenUygulamasi.Forms;
using DiyetisyenUygulamasi.SqlQuerys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiyetisyenUygulamasi
{
    public partial class GirisFrm : Form
    {
        public GirisFrm()
        {
            InitializeComponent();
        }
        GirisFrmSql girisQrys= new GirisFrmSql();
    
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtBoxGirisKullaniciAdi.Text == "admin" && txtBoxGirisSifre.Text == "admin")//admin olarak giriş yaparsa admin formuna yönlendiriyor
            {
                this.Hide();
                AdminFrm adminFrm = new AdminFrm();
                adminFrm.Closed += (s, args) => this.Close();
                adminFrm.Show();
            }
            else
            {
                if(girisQrys.girisKontrol(txtBoxGirisKullaniciAdi.Text.Trim(), txtBoxGirisSifre.Text.Trim()))//veritabanında böyle bir kullanıcı adı ve şifre var ise true dönüyor ve hastalar formuna yönlendiriyor.
                {
                    this.Hide();
                    HastalarFrm hastalarFrm = new HastalarFrm();
                    hastalarFrm.Closed += (s, args) => this.Close();
                    hastalarFrm.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Giris Yaptınız");
                }
               
            }
        }

    }
}
