using DiyetisyenUygulamasi.Forms;
using DiyetisyenUygulamasi.SqlQuerys;
using DiyetisyenUygulamasi.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiyetisyenUygulamasi.Functions;

namespace DiyetisyenUygulamasi.Forms
{
    public partial class HastalarFrm : Form
    {
        public HastalarFrm()
        {
            InitializeComponent();
        }
        HastalarQuerys hastalarQuerys = new HastalarQuerys();
        Hasta hasta = new Hasta();

        private void HastalarFrm_Load(object sender, EventArgs e)
        {
            dataGridViewHastaListele(hastalarQuerys.getAllHasta());//form açıldığı an dataGridViewHastaListele fonksiyonuna bütün hastaları parametre olarak gönderiyor.
        }

        private void txtBxHastaHastalik_SelectedIndexChanged(object sender, EventArgs e)
        {
            HastalikCesiti hastalikCesiti;//hastalık çeşidi nesnesi oluşturuldu.
            lblHastalikAdi.Visible = false;//hastalık adı label ının görünürlüğünü kapattı.
            txtBoxHastalikAdi.Visible = false;//hastalık adı txtBox ının görünürlüğünü kapattı.
            if (cmbBoxHastalik.Text == "Obez")//cmbBoxHastalik dan Obez seçildiyse
            {
                hastalikCesiti = new Obez();//obez türünde nesne oluşturuyoruz
            }
            else if (cmbBoxHastalik.Text == "Çölyak")//cmbBoxHastalik dan Çölyak seçildiyse
            {
                hastalikCesiti = new Çölyak();//Çölyak türünde nesne oluşturuyoruz
            }
            else if (cmbBoxHastalik.Text == "Şeker")//cmbBoxHastalik dan Şeker seçildiyse
            {
                hastalikCesiti = new Şeker();//Şeker türünde nesne oluşturuyoruz
            }
            else
            {
                lblHastalikAdi.Visible = true;//hastalık adı label ının görünürlüğünü açtı.
                txtBoxHastalikAdi.Visible = true;//hastalık adı txtBox ının görünürlüğünü açtı.
                txtBoxHastalikAdi.Text = "";//hastalık adı txtBox ını boşaltıyor.
                return;//fonksiyondan bitiriyor.
            }
            hastalikCesiti.hastalikSecimi();// hastalikCesitidine göre hastalık adını dolduruyoruz
            hasta.hastalik = hastalikCesiti.hastalikOlustur();//hastalıkCesiti nesnesindeki hastalik nesnesini hastalarFrm da global olarak oluşturduğumuz hastanın hastalığına eşitliyoruz.
            txtBoxHastalikAdi.Text = hasta.hastalik.hastalikAdi;//hastanın hastalıkAdını txtBox a yazdırıyoruz.
        }

        private void txtBxHastaDiyetYntm_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiyetYontemi diyetYontemi;
            if (cmbBoxDiyetYontemi.Text == "Akdeniz")//cmbBoxHastalik dan Akdeniz seçildiyse
            {
                diyetYontemi = new AkdenizDiyeti();//AkdenizDiyeti türünde nesne oluşturuyoruz
            }
            else if (cmbBoxDiyetYontemi.Text == "Gluten Free")//cmbBoxHastalik dan Gluten Free seçildiyse
            {
                diyetYontemi = new GlutenFreeDiyeti();//GlutenFreeDiyeti türünde nesne oluşturuyoruz
            }
            else if (cmbBoxDiyetYontemi.Text == "Deniz Ürünleri")//cmbBoxHastalik dan Deniz Ürünleri seçildiyse
            {
                diyetYontemi = new DenizUrunleriDiyeti();//DenizUrunleriDiyeti türünde nesne oluşturuyoruz
            }
            else if (cmbBoxDiyetYontemi.Text == "Yeşillikler Dünyası")//cmbBoxHastalik dan Yeşillikler Dünyası seçildiyse
            {
                diyetYontemi = new YesilliklerDunyasiDiyeti();//YesilliklerDunyasiDiyeti türünde nesne oluşturuyoruz
            }
            else
            {
                txtBoxDiyetAdi.Text = "";//txtBoxDiyetAdi ni boşaltıyoruz.
                rchTxtBoxDiyetAciklamasi.Text = "-1.GÜN: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-2.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-3.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-4.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-5.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-6.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-7.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: ";//diyet açıklamasına default diyet programını yazdırıyoruz.
                return;//fonksiyonu bitiriyor.
            }
            diyetYontemi.diyetSecimi();//diyetYontemi sınıfındaki diyet nesnesine diyet secimine göre diyetAdı ve aciklamasi dolduruluyor.
            hasta.hastalik.diyet = diyetYontemi.diyetOlustur();//diyetYontemi sınıfındaki diyet nesnesini global olarak tanımladığımız hastanın hastalığının diyetine eşitliyoruz.
            txtBoxDiyetAdi.Text = hasta.hastalik.diyet.diyetAdi;//txtBoxDiyetAdi na diyetin adını yazdırıyoruz.
            rchTxtBoxDiyetAciklamasi.Text = hasta.hastalik.diyet.diyetAciklamasi;//rchTxtBoxDiyetAciklamasi na diyetin açıklamasını yazdırıyoruz.
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            if (txtBxHastaAd.Text.Trim() != "" && txtBxHastaSoyad.Text.Trim() != "" && txtBxHastaTc.Text.Trim() != "" && txtBxHastaTel.Text.Trim() != "" &&
                txtBxHastaMail.Text.Trim() != "" && txtBoxHastalikAdi.Text.Trim() != "" && txtBoxDiyetAdi.Text.Trim() != "" && rchTxtBoxDiyetAciklamasi.Text.Trim() != "")//boş kutucuk bırakmadıysa if e giriyor.
            {
                hastaDoldur();//textbox dan verileri aldık ve değerlere atadık.
                hastalarQuerys.hastaEkle(hasta);//veritabanına hastayı ekliyor. 
                MessageBox.Show("HASTA EKLENDİ!" +
                    "\nhasta adi: " + hasta.ad +
                    "\nhasta soyadı: " + hasta.soyad +
                    "\nhasta tcNo: " + hasta.tcNo +
                    "\nhasta telefonNo: " + hasta.telefonNo +
                    "\nhasta email: " + hasta.email +
                    "\nhastalık adı: " + hasta.hastalik.hastalikAdi +
                    "\ndiyet adı: " + hasta.hastalik.diyet.diyetAdi +
                    "\ndiyet aciklamasi: " + hasta.hastalik.diyet.diyetAciklamasi);
                dataGridViewHastaListele(hastalarQuerys.getAllHasta());//hasta listesini yeniliyor.
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            hastaDoldur();//ekrandaki verileri global olarak tanımladığımız hastaya dolduruyoruz.
            hastalarQuerys.hastaGuncelle(hasta);//bilgilerini güncelleyeceğimiz hastayı hastaGuncelle fonksiyonuna parametre olarak gönderiyoruz.
            MessageBox.Show("HASTA GÜNCELLENDİ!" +
                    "\nhasta adi: " + hasta.ad +
                    "\nhasta soyadı: " + hasta.soyad +
                    "\nhasta tcNo: " + hasta.tcNo +
                    "\nhasta telefonNo: " + hasta.telefonNo +
                    "\nhasta email: " + hasta.email +
                    "\nhastalık adı: " + hasta.hastalik.hastalikAdi +
                    "\ndiyet adı: " + hasta.hastalik.diyet.diyetAdi +
                    "\ndiyet aciklamasi: " + hasta.hastalik.diyet.diyetAciklamasi);
            dataGridViewHastaListele(hastalarQuerys.getAllHasta());//hasta listesini yeniliyor.
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            dataGridViewHastaListele(hastalarQuerys.getAllHasta());//hasta listesini yeniliyor.
        }
        private void btnRaporCikar_Click(object sender, EventArgs e)
        {
            hastaDoldur();////ekrandaki verileri global olarak tanımladığımız hastaya dolduruyoruz.
            RaporSecimFrm rs = new RaporSecimFrm();
            rs.hasta = hasta;//RaporSecimFrm daki hastaya seçtiğimiz hastayı eşitliyoruz.
            rs.Show();//RaporSecimFrm u açıyor.
        }

        public void hastaDoldur()//ekrandaki hasta bilgilerini global olarak tanımladığımız hastaya aktarıyor.
        {
            hasta.ad = txtBxHastaAd.Text;
            hasta.soyad = txtBxHastaSoyad.Text;
            hasta.tcNo = txtBxHastaTc.Text;
            hasta.telefonNo = txtBxHastaTel.Text;
            hasta.email = txtBxHastaMail.Text;
            hasta.hastalik.hastalikAdi = txtBoxHastalikAdi.Text;
            hasta.hastalik.diyet.diyetAdi = txtBoxDiyetAdi.Text;
            hasta.hastalik.diyet.diyetAciklamasi = rchTxtBoxDiyetAciklamasi.Text;
        }
        public void hastaEkraniDoldur(Hasta hasta)//parametre olarak gönderilen hastayı ekrandaki kutucuklara dolduruyor.
        {
            txtBxHastaAd.Text = hasta.ad;
            txtBxHastaSoyad.Text = hasta.soyad;
            txtBxHastaTc.Text = hasta.tcNo;
            txtBxHastaTel.Text = hasta.telefonNo;
            txtBxHastaMail.Text = hasta.email;
            cmbBoxHastalik.Text = hasta.hastalik.hastalikAdi;
            cmbBoxDiyetYontemi.Text = hasta.hastalik.diyet.diyetAdi;
            txtBoxHastalikAdi.Text = hasta.hastalik.hastalikAdi;
            txtBoxDiyetAdi.Text = hasta.hastalik.diyet.diyetAdi;
            rchTxtBoxDiyetAciklamasi.Text = hasta.hastalik.diyet.diyetAciklamasi;
            this.hasta = hasta;
        }
        public void dataGridViewHastaListele(List<Hasta> hastalar)//dataGridView a parametre olarak gönderilen hastalar ı listeliyor.
        {
            dtGrdViewHastalar.Rows.Clear();
            for (int i = 0; i < hastalar.Count; i++)
            {
                dtGrdViewHastalar.Rows.Add();
                dtGrdViewHastalar.Rows[i].Cells[0].Value = hastalar[i].hastaID;
                dtGrdViewHastalar.Rows[i].Cells[1].Value = hastalar[i].ad;
                dtGrdViewHastalar.Rows[i].Cells[2].Value = hastalar[i].soyad;
                dtGrdViewHastalar.Rows[i].Cells[3].Value = hastalar[i].tcNo;
                dtGrdViewHastalar.Rows[i].Cells[4].Value = hastalar[i].telefonNo;
                dtGrdViewHastalar.Rows[i].Cells[5].Value = hastalar[i].email;
                dtGrdViewHastalar.Rows[i].Cells[6].Value = hastalar[i].hastalik.hastalikAdi;
                dtGrdViewHastalar.Rows[i].Cells[7].Value = hastalar[i].hastalik.diyet.diyetAdi;
                dtGrdViewHastalar.Rows[i].Cells[8].Value = hastalar[i].hastalik.diyet.diyetAciklamasi;
                dtGrdViewHastalar.Rows[i].Cells[9].Value = (hastalar[i].diyetisyenAdi + " " + hastalar[i].diyetisyenSoyadi);
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            List<Hasta> hastalar = new List<Hasta>();
            if (txtBoxTcAra.Text.Trim() != "")//txtBoxTcAra boş değilse if e girer
            {
                hastalar = hastalarQuerys.getHastaByHastaTc(txtBoxTcAra.Text.Trim());//txtBoxTcAra daki tc nosuna göre veritabanında sorgu yapıp benzer tcli hastaları hastalar listesine aktarıyor.
            }
            else
            {
                hastalar = hastalarQuerys.getAllHasta();//txtBox boş bırakıldıysa bütün hastaları hastalar listesine atıyor.
            }
            dataGridViewHastaListele(hastalar);//data grid view da listelenmek üzere hastalar listesi gönderiliyor.
        }
        private void txtBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            TxtBoxKisitlama tbk = new TxtBoxKisitlama();
            tbk.onlyIntValue(e);//textboxa sadece int değer girilebilmesini sağlayan fonksiyon
        }
        private void dtGrdViewHastalar_DoubleClick(object sender, EventArgs e)//dataGridView a çift tıklanırsa.
        {
            if (dtGrdViewHastalar.SelectedRows.Count == 1)//datagridview dan sadece bir satır seçerse
            {//yeni oluşturduğumuz hastaya datagridViewdan seçtiğimiz hastanın bilgilerini aktarıyoruz.
                Hasta hasta = new Hasta();
                hasta.hastaID = Convert.ToInt32(dtGrdViewHastalar.SelectedRows[0].Cells[0].Value);
                hasta.ad = dtGrdViewHastalar.SelectedRows[0].Cells[1].Value.ToString();
                hasta.soyad = dtGrdViewHastalar.SelectedRows[0].Cells[2].Value.ToString();
                hasta.tcNo = dtGrdViewHastalar.SelectedRows[0].Cells[3].Value.ToString();
                hasta.telefonNo = dtGrdViewHastalar.SelectedRows[0].Cells[4].Value.ToString();
                hasta.email = dtGrdViewHastalar.SelectedRows[0].Cells[5].Value.ToString();
                hasta.hastalik.hastalikAdi = dtGrdViewHastalar.SelectedRows[0].Cells[6].Value.ToString();
                hasta.hastalik.diyet.diyetAdi = dtGrdViewHastalar.SelectedRows[0].Cells[7].Value.ToString();
                hasta.hastalik.diyet.diyetAciklamasi = dtGrdViewHastalar.SelectedRows[0].Cells[8].Value.ToString();
                hastaEkraniDoldur(hasta);//bilgilerini doldurduğumuz hastayı ekrandaki txtBoxlara doldurmak üzere hastaEkraniDoldur fonksiyonuna parametre olarak gönderiyoruz.
            }
        }

     
    }
}
