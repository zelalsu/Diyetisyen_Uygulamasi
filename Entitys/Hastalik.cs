using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenUygulamasi.Entitys
{
    public class Hastalik
    {
        public string hastalikAdi { get; set; }
        public Diyet diyet = new Diyet();
    }
    public abstract class HastalikCesiti
    {
        public abstract void hastalikSecimi();
        public abstract Hastalik hastalikOlustur();

    }
    public class Obez : HastalikCesiti
    {
        Hastalik hastalik = new Hastalik();

        public override void hastalikSecimi()
        {
            hastalik.hastalikAdi = "Obez";
        }
        public override Hastalik hastalikOlustur()
        {
            return hastalik;
        }
    }
    public class Çölyak : HastalikCesiti
    {
        Hastalik hastalik = new Hastalik();
        public override void hastalikSecimi()
        {
            hastalik.hastalikAdi = "Çölyak";
        }
        public override Hastalik hastalikOlustur()
        {
            return hastalik;
        }
    }
    public class Şeker : HastalikCesiti
    {
        Hastalik hastalik = new Hastalik();
        public override void hastalikSecimi()
        {
            hastalik.hastalikAdi = "Şeker";
        }
        public override Hastalik hastalikOlustur()
        {
            return hastalik;
        }
    }

}
