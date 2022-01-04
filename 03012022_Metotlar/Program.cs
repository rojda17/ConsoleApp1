using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03012022_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("merhaba dünya");
            EkrandaGöster();
            string isim="Elif";
            string adres = "kadıköy";
            
            Selamla(adres);
            Selamla(isim);//selamla değişkenini iki kere yazdırabiliriz.



            //int sonuc = 0;
            //sonuc=Cikarmaİslemi(sayi1, sayi2);
            //Console.WriteLine("İKİ SAYININ FARKI: " + sonuc);
            /*[Erişim Belirleyicisi]<Geri dönüş tipi>Metotadı(parametreler)
            {
                Metodun İçi
            }
            Erişim Belirleyicileri
            *Public//Public olan metoda her yerden erişilebilir.
            *Private//Private olan metoda her yerden erişilemez.Sadece oluşturulduğu Class içerisinde erişilebilir.
            *Protected
            *İnternal
            *İnternal Protected

            */
            //Class1 o1 = new Class1();//o1 nesnesi oluşturdum.Class içindeki değişkenlere ve metotlara bu nesne üzerinden ulaşabilirim.
            //o1.OgrenciMetot1();
            //Console.WriteLine("ögrenci adı:");
            //string ad = Console.ReadLine();
            //Console.Write("ÖĞRENCİNİN SOYADI:");
            //string soyad = Console.ReadLine();
            //Console.Write("1.not");
            //int not1=int.Parse(Console.ReadLine());
            //Console.Write("2.not");
            //int not2=int.Parse(Console.ReadLine());
            //Class1 ogr = new Class1();
            //ogr.OgrenciOrtHesapla(ad, soyad, not1, not2);
            Matematik m = new Matematik();
            
            Console.WriteLine("1.sayı:");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("2.sayı");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());
            Yenidensecim://eğer işlemi seçerken +,-,*,/ ifadelerinden farklı seçim yaparsak yeniden seçim yaptırır.
            m.menuhazirla();
            Console.WriteLine("İşlemi giriniz:");
            char islem = Convert.ToChar(Console.ReadLine());

            
            decimal sonuc=0;
            switch(islem)
            {
                case '+':sonuc= m.topla(sayi1, sayi2);
                    Console.WriteLine("sonuc: " + sonuc);
                    break;
                
                case '-':
                    sonuc=m.cikarma(sayi1, sayi2);
                    Console.WriteLine("sonuc: " + sonuc);
                    break;
                
                case '*': sonuc=m.carpım(sayi1, sayi2);
                    Console.WriteLine("sonuc: " + sonuc);
                    break;
                
                case '/':sonuc= m.bölüm(sayi1, sayi2);
                    Console.WriteLine("sonuc: " + sonuc);
                    break;
                
                case '!':Console.WriteLine("Faktoriyel hesabı için bir sayi giriniz:");
                    int sayi = int.Parse(Console.ReadLine());
                    int faktoriyel = m.faktoriyel(sayi);
                    Console.WriteLine("Faktoriyel: " + faktoriyel);
                    break;


               default:Console.WriteLine("yanlış seçim");
                    goto Yenidensecim;
                    
            }
            
            Console.ReadLine();
        } 

        static void EkrandaGöster()
        {
            Console.WriteLine("Merhaba Dünya");


        }
        static void Selamla(string ad)//değişken ismi (isim) de olabilir ama farklı olsa da sorun olmuyor.
        {
            Console.WriteLine("MERHABA " + ad);
        }
        static void Toplamaİslemi(int sayi1,int sayi2)
        {
            int toplam = 0;
            toplam = sayi1 + sayi2;
            Console.WriteLine("TOPLAM:" + toplam);
        }
        static int Cikarmaİslemi(int sayi1,int sayi2)//metot int tipinde bi şey döndürdüğü için void yerine int yazılır.
        {
            int fark = 0;
            fark = sayi1 - sayi2;
            return fark;//işlem sonucunu geri döndürmek için kullanılır.Başka işlemlerde kullanabilmek için return edilir.
        }
    }
}
