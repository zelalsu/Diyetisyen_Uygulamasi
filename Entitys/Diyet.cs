using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenUygulamasi.Entitys
{
    public class Diyet
    {
        public string diyetAdi { get; set; }
        public string diyetAciklamasi { get; set; }
    }
    public abstract class DiyetYontemi
    {
        public Diyet diyet = new Diyet();
        public abstract void diyetSecimi();
        public abstract Diyet diyetOlustur();
    }
    public class AkdenizDiyeti : DiyetYontemi
    {
        public override void diyetSecimi()
        {
            diyet.diyetAdi = "Akdeniz";
            diyet.diyetAciklamasi = "-1.GÜN: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-2.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-3.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-4.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-5.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-6.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-7.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: ";
        }
        public override Diyet diyetOlustur()
        {
            return diyet;
        }
    }
    public class GlutenFreeDiyeti : DiyetYontemi
    {
        public override void diyetSecimi()
        {
            diyet.diyetAdi = "Gluten Free";
            diyet.diyetAciklamasi = "-1.GÜN: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-2.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-3.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-4.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-5.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-6.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-7.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: ";
        }
        public override Diyet diyetOlustur()
        {
            return diyet;
        }
    }
    public class DenizUrunleriDiyeti : DiyetYontemi
    {
        public override void diyetSecimi()
        {
            diyet.diyetAdi = "Deniz Ürünleri";
            diyet.diyetAciklamasi = "-1.GÜN: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-2.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-3.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-4.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-5.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-6.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-7.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: ";
        }
        public override Diyet diyetOlustur()
        {
            return diyet;
        }
    }

    public class YesilliklerDunyasiDiyeti : DiyetYontemi
    {
        public override void diyetSecimi()
        {
            diyet.diyetAdi = "Yeşillik Dünyası";
            diyet.diyetAciklamasi = "-1.GÜN: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-2.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-3.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-4.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-5.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-6.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: \n" +
                "-7.Gün: \n+SABAH: \n+ÖĞLEN: \n+AKŞAM: ";
        }
        public override Diyet diyetOlustur()
        {
            return diyet;
        }

    }
}
