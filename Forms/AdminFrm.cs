using System;
using DiyetisyenUygulamasi.Entitys;
using DiyetisyenUygulamasi.SqlQuerys;
using DiyetisyenUygulamasi.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DiyetisyenUygulamasi.Forms
{
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
        }
        Diyetisyen diyetisyen = new Diyetisyen(); 
        GirisFrmSql grsKytFrmQrys = new GirisFrmSql();
        private void Admin_Load(object sender, EventArgs e)
        {
            dtGrdViewDiyetisyenListele(grsKytFrmQrys.getAllDiyetisyen());//bütün diyetisyenleri veritabanında çekip dtGrdViewDiyetisyenListele fonksiyonuna gönderiyor
        }

        private void btnDiyetisyenEkle_Click(object sender, EventArgs e)
        {
            if (txtBoxDiyetisyenAdi.Text.Trim() == "" || txtBoxDiyetisyenSoyadi.Text.Trim() == "" || txtBoxTcNo.Text.Trim() == "" ||
                txtBoxTelefonNo.Text.Trim() == "" || txtBoxEmail.Text.Trim() == "" ||
                txtBoxKullaniciAdi.Text.Trim() == "" || txtBoxSifre.Text.Trim() == "")//boş kutucuk kontrolü
            {
                MessageBox.Show("Lütfen Boş Kutucuk Bırakmayınız!");
            }
            else//diyetisyen nesnesini dolduruyor ve kayitOl fonksiyonunu çağırıyor.
            {
                diyetisyen.ad = txtBoxDiyetisyenAdi.Text.Trim();
                diyetisyen.soyad = txtBoxDiyetisyenSoyadi.Text.Trim();
                diyetisyen.tcNo = txtBoxTcNo.Text.Trim();
                diyetisyen.telefonNo = txtBoxTelefonNo.Text.Trim();
                diyetisyen.email = txtBoxEmail.Text.Trim();
                diyetisyen.kullaniciAdi = txtBoxKullaniciAdi.Text.Trim();
                diyetisyen.sifre = txtBoxSifre.Text.Trim();
                kayitOl();
            }

        }
        public void kayitOl()
        {
            if (grsKytFrmQrys.kayitKontrol(diyetisyen.kullaniciAdi, diyetisyen.tcNo))//veritabanında aynı kullanıcı adı veya tc ye sahip kullanıcı var mı diye kontrol ediyor. Eğer yoksa if e giriyor.
            {
                grsKytFrmQrys.DiyetisyenKayit(diyetisyen);//diyetisyen nesnesini DiyetisyenKayit fonksiyonuna gönderip diyetisyen kaydını gerçekleştiriyor.
                dtGrdViewDiyetisyenListele(grsKytFrmQrys.getAllDiyetisyen());//data grid view ı yeniden listeliyor.
                MessageBox.Show("Kayıt Oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Aynı kullanıcı adı veya tcNo ya sahip kullanıcı mevcut!");
            }
        }

        public void dtGrdViewDiyetisyenListele(List<Diyetisyen> diyetisyens)//data grid view a parametre olarak gönderilen diyetisyen listesini data grid view a doldurur.
        {
            dtGrdViewDiyetisyenler.Rows.Clear();
            for(int i=0;i<diyetisyens.Count;i++)
            {
                dtGrdViewDiyetisyenler.Rows.Add();
                dtGrdViewDiyetisyenler.Rows[i].Cells[0].Value = diyetisyens[i].diyetisyenID;
                dtGrdViewDiyetisyenler.Rows[i].Cells[1].Value = diyetisyens[i].ad;
                dtGrdViewDiyetisyenler.Rows[i].Cells[2].Value = diyetisyens[i].soyad;
                dtGrdViewDiyetisyenler.Rows[i].Cells[3].Value = diyetisyens[i].kullaniciAdi;
                dtGrdViewDiyetisyenler.Rows[i].Cells[4].Value = diyetisyens[i].sifre;
                dtGrdViewDiyetisyenler.Rows[i].Cells[5].Value = diyetisyens[i].tcNo;
                dtGrdViewDiyetisyenler.Rows[i].Cells[6].Value = diyetisyens[i].telefonNo;
                dtGrdViewDiyetisyenler.Rows[i].Cells[7].Value = diyetisyens[i].email;

            }
        }

    }
}

