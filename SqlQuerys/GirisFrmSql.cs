using DiyetisyenUygulamasi.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetisyenUygulamasi.SqlQuerys
{
    public class GirisFrmSql
    {
        public static string connectionSource = Properties.Settings.Default.SqlString;//properties bölümünden veritabanı bağlantı stringini alıyor
        SqlConnection baglanti = new SqlConnection(connectionSource);//sql bağlantısını tanımlıyoruz
        public bool girisKontrol(string kullaniciAdi, string sifre)
        {
            bool izin = false; //eğer izin false ise giriş izni verilmez. 
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("Select * from tblDiyetisyen where kullaniciAdi = @KullaniciAdi and sifre = @Sifre", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);//parametreler
                komut.Parameters.AddWithValue("@Sifre", sifre);
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                while (read.Read())//eğer gönderdiğimiz kullanıcı adı ve sifresine sahip birisi var ise while içine girer.
                {
                    izin = true;
                    Properties.Settings.Default.diyetisyenID = Convert.ToInt32(read["diyetisyenID"]);//diyetisyenID yi diğer ekranlarda kullanmak için properties kısmına kaydettim                  
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor
                return izin;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        public bool kayitKontrol(string kullaniciAdi, string tcNo)
        {
            bool izin = true;
            try
            {
                //kullanıcıadi ve şifrenin kontrolü eğer öyle bir kullanıcı varsa izini false yapıyor. yani oluşturmuyor. Eğer böyle bir kullanıcı yoksa izini true yapıyor. yani izin veriyor.
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblDiyetisyen where kullaniciAdi=@KullaniciAdi or tcNo=@tcNo", baglanti);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@tcNo", tcNo);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    izin = false;
                }
                baglanti.Close();
                return izin;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata:" + ex.ToString());
                throw;
            }

        }
        public void DiyetisyenKayit(Diyetisyen diyetisyen)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO tblDiyetisyen (ad,soyad,kullaniciAdi,sifre,tcNo,telefonNo,email) VALUES " +
                    "(@ad,@soyad,@kullaniciAdi,@sifre,@tcNo,@telefonNo,@email)", baglanti);
                //sql sorgusuna parametre degerlerini yolluyoruz

                komut.Parameters.AddWithValue("@ad", diyetisyen.ad);
                komut.Parameters.AddWithValue("@soyad", diyetisyen.soyad);
                komut.Parameters.AddWithValue("@kullaniciAdi", diyetisyen.kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", diyetisyen.sifre);
                komut.Parameters.AddWithValue("@tcNo", diyetisyen.tcNo);
                komut.Parameters.AddWithValue("@telefonNo", diyetisyen.telefonNo);
                komut.Parameters.AddWithValue("@email", diyetisyen.email);
                komut.ExecuteNonQuery();//sogruyu execute ediyoruz
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Oluşturulmuştur.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public  List<Diyetisyen> getAllDiyetisyen()
        {
            List<Diyetisyen> diyetisyenler = new List<Diyetisyen>();
           
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("Select * from tblDiyetisyen", baglanti);//bütün hastalari çeken sorgu.
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                while (read.Read())//veritabanından gelen bütün hasta verilerini okur.
                {
                    Diyetisyen diyet = new Diyetisyen();
                    diyet.diyetisyenID = Convert.ToInt32(read["diyetisyenID"]);
                    diyet.ad = read["ad"].ToString();//veritabanındaki hastanın ad sütunundaki değeri okur.
                    diyet.soyad = read["soyad"].ToString();
                    diyet.kullaniciAdi= read["kullaniciAdi"].ToString();
                    diyet.sifre = read["sifre"].ToString();
                    diyet.tcNo = read["tcNo"].ToString();
                    diyet.telefonNo = read["telefonNo"].ToString();
                    diyet.email = read["email"].ToString();


                    diyetisyenler.Add(diyet);//hastalar listesine hastayı ekliyoruz.
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor
                return diyetisyenler;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
    }
    



}
