using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28122021_KararYapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int ort = 150;
            //bool kontrol = ort >= 50;
            if(ort<60)//eğer parantez içi doğruysa süslü parantez içindekileri çalıştırır.
            {
                Console.WriteLine("Sınıf tekrarı");
                Console.ReadLine();

            }
            else if(ort>=60 && ort<70)//if doğru değilse bunu çalıştırır.
            {
                Console.WriteLine("Şartlı geçtiniz");
                Console.ReadLine();
             }
            else if(ort>=70 && ort<85)
                {

                Console.WriteLine("iyi derecede geçtiniz");
            }
            else if(ort>=85 && ort<=100)
            {
                Console.WriteLine("başarılı");

            }
            else
            {
                Console.WriteLine("yanlış değer girdiniz");
            }
            
            */
            Console.WriteLine("1.sayı:  ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.sayı: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İşlemi giriniz: ");
            string işlem = Console.ReadLine();//işlemle ilgili bir şey yapmayacağımız için string tanımladık.
            if (işlem == "+")
            {
                double toplam = sayi1 + sayi2;

                Console.WriteLine("toplam:" + toplam);
                Console.ReadLine();
            }
            else if (işlem == "-")
            {
                double çıkarma = sayi1 - sayi2;
                Console.WriteLine("çıkarma:" + çıkarma);
                Console.ReadLine();


            }
            else if (işlem == "/")
            {
                if (sayi1 == 0 || sayi2 == 0)
                {
                    Console.WriteLine("hatalı giriş yaptınız");
                    Console.ReadLine();
                }
                else//eğer yukarıdaki durum geçerli değilse bölme işlemini yap
                {
                    double bölme = sayi1 / sayi2;
                    Console.WriteLine("bölme:" + bölme);
                    Console.ReadLine();
                }
            }
            else if(işlem== "*")
            {
                double çarpma = sayi1 * sayi2;
                Console.WriteLine("çarpma:" + çarpma);
                Console.ReadLine();
            }







        }
    }
            
}
