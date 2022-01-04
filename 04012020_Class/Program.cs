using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04012020_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.tcno = "254524685";
            m1.isim = "rojda";
            m1.soyisim = "gök";
            m1.cinsiyet = 012;

            Musteri m2 = new Musteri();
            m2 = m1;

            m1.musterikontrol(m1.tcno);

            arac araba = new arac();
            araba.marka="opel";
            araba.model="corse";
            araba.km="15000";
            araba.modelYil = 2018;
            araba.VitesTip = "otomatik";
            araba.YakitTip = "dizel";
            araba.AlisFiyati = 150000;
            araba.SatisFiyati = 200000;

            araba.BilgiYaz();
            Console.ReadLine();

            SanalDatabase sb = new SanalDatabase();
            sb.YeniKayit(12);
            sb.YeniKayit(24);




        }
     }
}

