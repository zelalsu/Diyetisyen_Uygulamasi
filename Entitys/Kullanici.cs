using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenUygulamasi.Entitys
{
    public class Kullanici
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tcNo { get; set; }
        public string telefonNo { get; set; }
        public string email { get; set; }
    }
    public class Diyetisyen : Kullanici
    {
        public int diyetisyenID { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

    }
    public class Hasta : Kullanici
    {
        public Hastalik hastalik = new Hastalik();
        public int hastaID { get; set; }
        public int diyetisyenID { get; set; }
        public string diyetisyenAdi { get; set; }
        public string diyetisyenSoyadi { get; set; }

    }


}
