using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30122021_Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            do//en az bir kere çalışır
            {
                Console.WriteLine("merhaba dünya");



            } while (1 == 2);//do while döngüsü kod doğruysa sonsuz çalışır ama yanlışsa bile en az bir kere çalışır


            int toplam = 0;
            int sayi;

            do
            {
                Console.Write("sayi: ");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;


            } while (sayi != 0);
            Console.WriteLine("toplam:" + toplam);
            Console.ReadLine();
            */
            /*
            Dışarıdan girilen kullanıcı adı ve şifre demo olunca giriş başarılı yazar.Olmadığı taktırde tekrar tekrar kulanıcı adı ve şifre sorar.
            string kullanıcıadı, sifre;
            do
            {
                Console.WriteLine("kullanıcıadı:" );
                kullanıcıadı = Console.ReadLine();
                Console.WriteLine("şifre:");
                sifre = Console.ReadLine();
            }
            while (kullanıcıadı != "demo" || sifre != "demo");

            Console.WriteLine("Giriş başarılı");
            Console.ReadLine();
             */

            /*
            1 ile 10 arasında rastgele seçilen sayıyı tahmin etmemizi sağlar
            Random rnd = new Random();
            int sayi = rnd.Next(1, 10), girilendeger,sayac=0;
            do
            {
                sayac ++;
                Console.WriteLine(sayac + ".Sayı giriniz: ");
                girilendeger = Convert.ToInt32(Console.ReadLine());

            } while (girilendeger != sayi);//tahmin edilen sayıya eşit olmadığı sürece döngüyü devam ettir.

            Console.WriteLine("tebrikler");
            Console.ReadLine();
            */

              
            //döngü içerisinde sürekli dört işlem yaptırma

            char devam;
            int sayi1, sayi2;

            do
            {
                Console.Clear();
                Console.WriteLine("1.sayıyı giriniz: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İşlemi giriniz: ");
                char islem = Convert.ToChar(Console.ReadLine());
                switch (islem)
                {
                    case '+':
                        break;
                        Console.WriteLine("Toplam:{0}", sayi1 + sayi2);
                    case '-':
                        break;
                        Console.WriteLine("Fark:{0}", sayi1 - sayi2);
                    case '*':
                        break;
                        Console.WriteLine("Çarpım:{0}", sayi1 * sayi2);
                    case '/':
                        break;
                        Console.WriteLine("Bölüm:{0}", sayi1 / sayi2);
                    default:
                        Console.WriteLine("hatalı işlem:");
                        break;

                }
                Console.WriteLine("Devam etmek için?(E/e)");
                devam = Convert.ToChar(Console.ReadLine());


            } while (devam == 'E' || devam == 'e');
            


            
            
            }






      

        
    }
}
