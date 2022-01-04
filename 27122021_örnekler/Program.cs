using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27122021_örnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //İKİ SAYININ TOPLAMINI YAZDIRAN KOD
            /*
            Console.Write("1.sayıyı giriniz:");
            int sayi1;
            sayi1 =Convert.ToInt32(Console.ReadLine());//aldığımız string i int değere çevirmek için convert kullandık
            Console.Write("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int toplam;
            toplam = sayi1 + sayi2;
            Console.WriteLine("TOPLAM="+toplam);
            Console.WriteLine($"toplam : {toplam}");//ÜSTTE GÖSTERDİĞİMİZ TOPLAMIN BAŞKA BİR VERSİYONU
            Console.ReadLine();
            */

            //KENARLARI VERİLEN DİKDÖRTGENİN ALANINI HESAPLAYALIM

            /*
                Console.Write("1.kenarın uzunluğunu giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.kenarın uzunluğunu giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            int alan;
            alan = sayi1 * sayi2;
            Console.WriteLine("alan=" + alan);
            Console.ReadLine();
            */
           
            #region kenar ve yüksekliği girilen üçgenin alanını hesaplayınız

            Console.Write("üçgenin kenar bilgisi: ");
            int kenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("üçgenin yükseklik bilgisi: ");
            int yükseklik = Convert.ToInt32(Console.ReadLine());
            double alan = (kenar * yükseklik) / 2 ;
            Console.Write($"üçgenin alanı:{alan}");
            Console.ReadLine();




            #endregion


        }
    }
}
