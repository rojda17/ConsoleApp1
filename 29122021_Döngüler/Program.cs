using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29122021_Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int toplam=0;
            

            for (int sayac = 0; sayac <= 10; sayac ++)
            {


                toplam = toplam + sayac;





            }
                Console.WriteLine(toplam);
                Console.ReadLine();
            */


            /*
             KULLANICININ GİRDİĞİ 10 SAYININ TOPLAMINI VEREN KOD
            int top = 0;
            int sayi;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0}.sayiyi giriniz", i);
                sayi=int.Parse
                    (Console.ReadLine());
                top = top + sayi;
                

            }
            Console.WriteLine(top);
            Console.ReadLine();

            */
            /*
            GİRİLEN SAYININ FAKTORİYELİNİ VEREN PROGRAM

            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int faktoriyel = 1;//0 OLSAYDI SONUÇ O OLURDU
            for (int i =sayi; i >=1 ; i--)//SAYI MESELA 10 DAN BAŞLIYOR 9*8*7 DİYE AZALARAK İLERLİYOR.
            {
                faktoriyel = faktoriyel * i;//FAKTORİYEL EN SON KAÇ ÇIKTIYSA SIRADAKİ SAYIYI ONLA ÇARPMAK İÇİN 


            }
            Console.WriteLine("sayının faktoriyeli:" + faktoriyel);
            Console.ReadLine();
            */

            /*
            MÜKEMMEL SAYI=ÇARPANLARININ TOPLAMI KENDİSİNE EŞİT OLAN SAYI
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int toplam=0;
            for (int i = 1; i < sayi; i++)
            {
                if(sayi%i==0)
                {
                    toplam = toplam + i;

                }
            }
           if(toplam==sayi)
                {
                    Console.WriteLine("Girilen sayı mükemmel sayıdır");
                }
                    else
                {
                    Console.WriteLine("Girilen sayı mükemmel sayı değildir");
                }
            Console.ReadLine();
            */
            #region
            /*
            Fibonacci sayıları
            int sayi1 = 1;
            int sayi2 = 1;
            int sayi3 = 0;
            Console.WriteLine(sayi1+" "+sayi2);
            for (int i = 1; i <= 10; i++)
            {
                sayi3 = sayi1 + sayi2;
                Console.WriteLine(sayi3);
                sayi1 = sayi2;
                sayi2 = sayi3;


            }
            Console.ReadLine();
            */
            #endregion
            /* 
            for(int i=1; i<=10;i++)
                 {

                 for (int j=1; j <=i; j++)
                 {
                     Console.Write("*");

                 }
                 Console.WriteLine("");

             }
             Console.ReadLine();

             for (int i = 0; i<10; i++)
             {

                 for (int j = 0; j < i; j++)
                 {
                     Console.Write(" ");
                 }
                 for(int j=0;j<10-i;j++)
                     {

                      Console.Write("*");
                    }



                 Console.WriteLine("");

             }
             Console.ReadLine();

             for (int i = 1; i <= 10; i++)
             {
                 for(int j=1;j<=15;j++)
                 {
                     if (i == 1 || i==10)
                         Console.Write("*");
                     else
                     {
                         if (j == 1 || j == 15)
                         {
                             Console.Write("*");
                         }

                         else
                             Console.Write(" ");
                     }
                 }
                 Console.WriteLine("  ");

             }
             Console.ReadLine();

             */
            /*
            çarpım tablosu
            for (int j = 1; j < 10; j++)
            {
                for (int i = 1; i <10; i++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, (i * j));//  \t satırlar arasında boşluk sağlar
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
            */
            /*
            GİRİLEN 3 SAYIDAN EN BÜYÜK VE KÜÇÜĞÜNÜ BULAN PROGRAM
            int sayi = 0;
            int max = 0;
            int min = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz", i);
                sayi = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    min = sayi;//ilk girdiğimiz sayıyı min kabul ettik
                }
                if (sayi <= min)//eğer yeni girdiğimiz sayı daha küçükse onu min kabul et
                {
                    min = sayi;
                }
                if (sayi >= max)
                    max = sayi;
            }
            Console.WriteLine("EN BÜYÜK SAYI:" + max);
            Console.WriteLine("EN KÜÇÜK SAYI:" + min);

            Console.ReadLine();
            */
            /*
            for (; ; )//sonsuz döngüye sokar
            {
                Console.WriteLine("merhabalar");
            }
            Console.ReadLine();
            */
            /*
            string[] isimler = new[] { "elif", "enes", "asu" };
            foreach(string item in isimler
                ){
                if (item == "enes")
                    Console.WriteLine(item);
                else
                Console.WriteLine("deneme");
            }
            Console.ReadLine();
            */
            /*
            int sayac = 0;
            while(sayac<10)//koşul doğru olduğu sürece çalışır
            {
                sayac++;
                Console.WriteLine(sayac);
            }
            Console.Write("bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            while(sayi>=0)//girdiğimiz sayıyı sıfıra kadar eksilterek sıralar
            {
                Console.WriteLine(sayi--);
            }
            Console.ReadLine();
            */
            /*
            int toplam = 0;
            while (true)
            {
                Console.Write("bir sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi < 0)
                    break;
                toplam += sayi;

                
            }
            Console.Write(toplam);
            Console.ReadLine();
            */
            


        }
        
    }
}




            








    




    
    

