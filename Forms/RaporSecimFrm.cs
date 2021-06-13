using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiyetisyenUygulamasi.SqlQuerys;
using DiyetisyenUygulamasi.Entitys;
using System.IO;

namespace DiyetisyenUygulamasi.Forms
{
    public partial class RaporSecimFrm : Form
    {
        public RaporSecimFrm()
        {
            InitializeComponent();
        }

        HastalarQuerys hastalarQuerys = new HastalarQuerys();
        public Hasta hasta = new Hasta();

        private void hd_btn_Click(object sender, EventArgs e)//1-hasta 2-diyet butonu
        {
            this.Hide();
            StreamWriter page = new StreamWriter(@"rapor.html");//çıktı dosyası oluşturuyor.
            page.WriteLine("<!DOCTYPE html><html>");
            page.WriteLine("<head><title> Hasta Bilgi Raporu </title></head>");
            page.WriteLine("<body><h1> Hasta Bilgi Raporu </h1></body>");

            page.WriteLine("<body><h2> 1) Hasta Bilgileri: </h2></body>");
            hastaBilgiYazdir(hasta, page);//hasta bilgilerinin yazdırıldığı fonksiyona hasta bilgilerini ve sayfayı parametre olarak yolluyoruz.

            page.WriteLine("<body><h2> 2) Diyet Bilgileri: </h2></body>");
            diyetBilgiYazdir(hasta, page);//diyet bilgilerinin yazdırıldığı fonksiyona diyet bilgilerini ve sayfayı parametre olarak yolluyoruz.

            page.WriteLine("</html>");
            page.Close();//rapor dosyasını kapatır.
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "/rapor.html");//raporu açar.

        }

        private void dh_btn_Click(object sender, EventArgs e)//1-diyet 2-hasta butonu
        {
            this.Hide();
            StreamWriter page = new StreamWriter(@"rapor.html");//çıktı dosyası oluşturuyor.
            page.WriteLine("<!DOCTYPE html><html>");
            page.WriteLine("<head><title> Hasta Bilgi Raporu </title></head>");
            page.WriteLine("<body><h1 style='text-align:center;'> Hasta Bilgi Raporu </h1></body>");

            page.WriteLine("<div class='diyet'>");
            page.WriteLine("<body><h2> 1) Diyet Bilgileri: </h2></body>");
            diyetBilgiYazdir(hasta, page);//hasta bilgilerinin yazdırıldığı fonksiyona hasta bilgilerini ve sayfayı parametre olarak yolluyoruz.
            page.WriteLine("</div>");

            page.WriteLine("<body><h2> 2) Hasta Bilgileri: </h2></body>");
            hastaBilgiYazdir(hasta, page);//diyet bilgilerinin yazdırıldığı fonksiyona diyet bilgilerini ve sayfayı parametre olarak yolluyoruz.

            page.WriteLine("</html>");
            page.Close();//rapor dosyasını kapatır.
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "/rapor.html");//raporu açar.
        }


        private void hastaBilgiYazdir(Hasta hasta, StreamWriter page)//hasta satırlarının yazdırıldığı fonksiyon
        {
            page.WriteLine("<style>.a{padding: 25px;  background-color:lightblue;} </style>");
            page.WriteLine("<div class='a'>");
            page.WriteLine("<body><p><b> AD: </b>" + hasta.ad.ToUpper() + "</p>");
            page.WriteLine("<p><b> SOYAD: </b>" + hasta.soyad.ToUpper() + "</p>");
            page.WriteLine("<p><b> TC: </b>" + hasta.tcNo + "</p>");
            page.WriteLine("<p><b> TEL NO: </b>" + hasta.telefonNo + "</p>");
            page.WriteLine("<p><b> E-MAİL: </b> " + hasta.email + "</p></body>");
            page.WriteLine("</div>");

        }
        private void diyetBilgiYazdir(Hasta hasta, StreamWriter page)//diyet satırlarının yazdırıldığı fonksiyon
        {
            page.WriteLine("<style>.a{padding: 25px;  background-color:lightblue;} </style>");
            page.WriteLine("<div class='a'>");
            page.WriteLine("<body><p><b> HASTALIK: </b>" + hasta.hastalik.hastalikAdi.ToUpper() + "</p>");
            page.WriteLine("<p><b> DİYET TÜRÜ: </b>" + hasta.hastalik.diyet.diyetAdi.ToUpper() + "</p>");
            page.WriteLine("<p><b> DİYET AÇIKLAMASI: </b></p></body>");
            diyetAciklamaYazdir(page, hasta.hastalik.diyet.diyetAciklamasi);//diyet açıklamasının yazdırıldığı fonksiyon
            page.WriteLine("</div>");
        }

        private void diyetAciklamaYazdir(StreamWriter page, string aciklama)//diyet açıklamasının yazdırıldığı fonksiyon
        {
            string[] gun;
            string[] ogun;

            gun = aciklama.Split('-');
            foreach (string kelime in gun)//günleri dönen foreach
            {
                ogun = kelime.Split('+');
                foreach (string kelime1 in ogun)//öğünleri dönen foreach
                    if (kelime1 == ogun[0])
                        page.WriteLine("<body><h4> " + kelime1 + "</h4></body>");
                    else
                        page.WriteLine("<body><p> " + kelime1 + "</p></body>");
            }

        }

   
    }
}
