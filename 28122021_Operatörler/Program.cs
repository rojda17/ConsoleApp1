using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28122021_Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {    /*
            int sayi1 = 15;
            int sayi2 = 25;
            int toplam = sayi1 + sayi2;//byte yazarsak olmayabilir hata verir çünkü karşılayıp karşılamayacağından emin olamaz

            string ad = "rojda";
            string soyad = "gök";
            int yıl = 2021;
            Console.WriteLine(ad +"  "+ soyad+yıl);//burada artının görevi string i birleştirmek
            Console.ReadLine();
            */

            /*ÖRNEK
            Console.WriteLine("merhaba");
            Console.WriteLine("isim:");
            string isim = Console.ReadLine();
            Console.WriteLine("soyisim");
            string soyisim = Console.ReadLine();

            Console.WriteLine("doğumtarihi");
            int yil = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int tarih = DateTime.Now.Year;//bugünün tarihinin yılını veren kod
            int yas = tarih - yil;
            Console.WriteLine("merhaba" + isim + soyisim + yas + "yaşındasınız");

            Console.ReadLine();

            */

            /*
            ÇARPIMLA İLGİLİ ÖRNEK
            double s1 = 10.2;
            double s2 = 5.8;
            double carpim = s1 * s2;
            int carpim2 = Convert.ToInt32(s1 * s2);//double i int e çevirmek için convert yaptık.

            Console.WriteLine(carpim);
            Console.WriteLine(carpim2);
            Console.ReadLine();
            */


            /*
            BÖLME İŞLEMİ
            int r1 = 15;
            int r2 = 5;
            int bölüm = r1 / r2;
            Console.WriteLine(bölüm);
            Console.ReadLine();
            */


            /*
            Mod ALMA ÖRNEĞİ
            int r1 = 20;
            int r2 = 5;
            int modalma = r1 % r2;
            Console.WriteLine(modalma);
            Console.ReadLine();
            */


            /*
            ++ operatörü(BUNUN EKSİLİSİ DE VAR)
            int r3= 5;
            int sonuc = r3++;
            int sonuc2 = ++r3;
            int sonuc3 = (r3++);//parantez içi işlemi değiştirmiyor
            sonuc = sonuc + 1;
            sonuc+=1//sonuc=sonuc+1 ile aynı
            sonuc++;//sonuc=sonuc+1
            sonuc += 5;//sonuc=sonuc+5 
            */


            /*
            KARŞILAŞTIRMA OPERATÖRLERİ
            int r3 = 8;
            int r4 = 8;
            bool donusdeğeried = r3 != r4;//eşit değil
            bool donusdegeri = r3 == r4; //sonucu her zaman true ya da false dir.
            bool donusdeğeribe = r3 >= r4;//büyük eşit
            bool donusdeğerike = r3 <= r4;//küçük eşit
            Console.WriteLine(donusdeğerike);
            Console.ReadLine();
            */
            /*
            is operatörü
            int r3 = 8;
            int X = 50;
            object o1 = X;//kontrol yapabilmek için object olarak tanımladık
            r3 = (int)o1;
            //byte y;
            //y = (byte)o1;

            //bool deger=degisken is degiskentipi

            bool kontrol = o1 is int;//o1 değişkeni int mi?
            bool kontrol2 = o1 is byte;//o1 değişkeni byte mı?
            Console.WriteLine(kontrol);
            Console.WriteLine(kontrol2);
            Console.ReadLine();
            */

            /*
            as operatörü
            object o2 = "istanbul";
            string st = o2 as string;//unboxing(st değişkenine o2 içeriğini atadık)
            Console.WriteLine(st);
            Console.ReadLine();

            */

            /*
            3 SINAV NOTUNUN ORTALAMASI
            Console.WriteLine("1.not:  ");
            string not1 =Console.ReadLine();
            Console.WriteLine("2.not:  ");
            string not2 = Console.ReadLine();
            Console.WriteLine("3.not:  ");
            string not3 = Console.ReadLine();

            decimal dnot1 = Convert.ToDecimal(not1);
            decimal dnot2 = Convert.ToDecimal(not2);
            decimal dnot3 = Convert.ToDecimal(not3);
            
            decimal ort=(dnot1  +dnot2 + dnot3) / 3;

            bool ortalamakontrol = ort >= 50;
            Console.WriteLine("ortalamam 50 den büyük ya da eşit mi?"+ortalamakontrol);
            Console.ReadLine();
            Console.ReadLine();
            */


            string kulad = "admin";
            string kulsifre = "123";
            bool deger = kulad == "admin" && kulsifre == "123";//ve operatörü
            bool deger2 = kulad == "elif" && kulsifre == "123";
            Console.WriteLine(deger);
            Console.WriteLine(deger2);
            Console.ReadLine();


            string no = "403";
            string sifre = "12345";
            bool deger = no == "403" || sifre == "12345";//veya operatörü



















        }
    }
}
