using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiyetisyenUygulamasi.Entitys;

namespace DiyetisyenUygulamasi.SqlQuerys
{
    public class HastalarQuerys
    {
        public static string connectionSource = Properties.Settings.Default.SqlString;//properties bölümünden veritabanı bağlantı stringini alıyor
        SqlConnection baglanti = new SqlConnection(connectionSource);//sql bağlantısını tanımlıyoruz
        public List<Hasta> getHastaByHastaTc(string hastaTc)
        {
            List<Hasta> hastalar = new List<Hasta>();
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("Select H.*, D.ad as diyetisyenAdi, D.soyad as diyetisyenSoyadi from tblHasta H LEFT JOIN tblDiyetisyen D on H.diyetisyenID = D.diyetisyenID where H.tcNo LIKE @source", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("@source", ("%" + hastaTc + "%"));
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                while (read.Read())//eğer gönderdiğimiz kullanıcı adı ve sifresine sahip birisi var ise yetki değişkenini dolduruyor. yoksa yetki null kalıyor
                {
                    Hasta hasta = new Hasta();
                    hasta.hastaID = Convert.ToInt32(read["hastaID"]);
                    hasta.ad = read["ad"].ToString();
                    hasta.soyad = read["soyad"].ToString();
                    hasta.tcNo = read["tcNo"].ToString();
                    hasta.telefonNo = read["telefonNo"].ToString();
                    hasta.email = read["email"].ToString();
                    hasta.hastalik.hastalikAdi = read["hastalik"].ToString();
                    hasta.hastalik.diyet.diyetAdi = read["diyetYontemi"].ToString();
                    hasta.hastalik.diyet.diyetAciklamasi = read["diyetAciklamasi"].ToString();
                    hasta.diyetisyenAdi = read["diyetisyenAdi"].ToString();
                    hasta.diyetisyenSoyadi = read["diyetisyenSoyadi"].ToString();
                    hastalar.Add(hasta);
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor
                return hastalar;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        public List<Hasta> getAllHasta()
        {
            List<Hasta> hastalar = new List<Hasta>();
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("Select H.*, D.ad as diyetisyenAdi, D.soyad as diyetisyenSoyadi from tblHasta H LEFT JOIN tblDiyetisyen D on H.diyetisyenID = D.diyetisyenID", baglanti);//bütün hastalari çeken sorgu.
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                while (read.Read())//veritabanından gelen bütün hasta verilerini okur.
                {
                    Hasta hasta = new Hasta();
                    hasta.hastaID = Convert.ToInt32(read["hastaID"]);
                    hasta.ad = read["ad"].ToString();//veritabanındaki hastanın ad sütunundaki değeri okur.
                    hasta.soyad = read["soyad"].ToString();
                    hasta.tcNo = read["tcNo"].ToString();
                    hasta.telefonNo = read["telefonNo"].ToString();
                    hasta.email = read["email"].ToString();
                    hasta.hastalik.hastalikAdi = read["hastalik"].ToString();
                    hasta.hastalik.diyet.diyetAdi = read["diyetYontemi"].ToString();
                    hasta.hastalik.diyet.diyetAciklamasi = read["diyetAciklamasi"].ToString();
                    hasta.diyetisyenAdi = read["diyetisyenAdi"].ToString();
                    hasta.diyetisyenSoyadi = read["diyetisyenSoyadi"].ToString();
                    hastalar.Add(hasta);//hastalar listesine hastayı ekliyoruz.
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor
                return hastalar;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        public void hastaEkle(Hasta hasta)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO tblHasta (ad,soyad,tcNo,telefonNo,email,hastalik,diyetYontemi,diyetAciklamasi,diyetisyenID) VALUES " +
                    "(@ad,@soyad,@tcNo,@telefonNo,@email,@hastalik,@diyetYontemi,@diyetAciklamasi,@diyetisyenID)", baglanti);
                komut.Parameters.AddWithValue("@ad", hasta.ad);
                komut.Parameters.AddWithValue("@soyad", hasta.soyad);
                komut.Parameters.AddWithValue("@tcNo", hasta.tcNo);
                komut.Parameters.AddWithValue("@telefonNo", hasta.telefonNo);
                komut.Parameters.AddWithValue("@email", hasta.email);
                komut.Parameters.AddWithValue("@hastalik", hasta.hastalik.hastalikAdi);
                komut.Parameters.AddWithValue("@diyetYontemi", hasta.hastalik.diyet.diyetAdi);
                komut.Parameters.AddWithValue("@diyetAciklamasi", hasta.hastalik.diyet.diyetAciklamasi);
                komut.Parameters.AddWithValue("@diyetisyenID", Properties.Settings.Default.diyetisyenID);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        public void hastaGuncelle(Hasta hasta)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE tblHasta SET ad = @ad, soyad = @soyad, tcNo = @tcNo, telefonNo = @telefonNo, " +
                    "email = @email, hastalik = @hastalik, diyetYontemi = @diyetYontemi, diyetAciklamasi = @diyetAciklamasi, diyetisyenID = @diyetisyenID " +
                    "where hastaID = @hastaID", baglanti);
                komut.Parameters.AddWithValue("@ad", hasta.ad);
                komut.Parameters.AddWithValue("@soyad", hasta.soyad);
                komut.Parameters.AddWithValue("@tcNo", hasta.tcNo);
                komut.Parameters.AddWithValue("@telefonNo", hasta.telefonNo);
                komut.Parameters.AddWithValue("@email", hasta.email);
                komut.Parameters.AddWithValue("@hastalik", hasta.hastalik.hastalikAdi);
                komut.Parameters.AddWithValue("@diyetYontemi", hasta.hastalik.diyet.diyetAdi);
                komut.Parameters.AddWithValue("@diyetAciklamasi", hasta.hastalik.diyet.diyetAciklamasi);
                komut.Parameters.AddWithValue("@diyetisyenID", Properties.Settings.Default.diyetisyenID);
                komut.Parameters.AddWithValue("@hastaID", hasta.hastaID);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
