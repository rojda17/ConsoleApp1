using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04012022_MetotDevam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("büyük olan değer:" + buyuk(30, 40));
            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (asalsayi(sayi))
            //{
            //    Console.WriteLine("Sayı asaldır");                              
            //}
            //else
            //    Console.WriteLine("Sayı asal değildir.");
            //int[] sayilar = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            //teksayilar(sayilar);
            //Console.WriteLine("Tek Sayılar:");
            //DiziyiEKranaYaz(teksayilar(sayilar));
            topla(10, 15);
            toplam(1, 2, 3, 5, 5, 6, 4, 7, 8, 9);
            Console.ReadLine();
        }
        //static int buyuk(int s1,int s2)
        //{
        //    if (s1 > s2)
        //        return s1;//sadece büyük sayıyı elde etmek istediğimiz için s1 i döndürdük
        //    else
        //        return s2;           
        //}
        /*
        static bool asalsayi(int sayi)
        {
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                    return false;                
            }
            return true;
        }
        */

        //static int[] teksayilar(int[] gelendizi)
        //{
        //    int[] tekdizi = new int[20];
        //    for (int i = 0; i < gelendizi.Length; i++)
        //    {
        //        if (gelendizi[i] % 2 == 1)
        //        {
        //            tekdizi[i] = gelendizi[i];
        //        }
        //    }
        //    return(tekdizi);


        //}
        //static void  DiziyiEKranaYaz(int[]dizi)
        //{
        //    foreach(int sayi in dizi)
        //    {
        //        if (sayi != 0)
        //            Console.WriteLine(sayi + " ");
        //    }
        //}
        static void topla(int s1, int s2, int s3 = 45)
        {
            int toplam = s1 + s2 + s3;
        }

        static void toplam(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];

            }
        }

        int sayi = 0;
        Degerata(ref sayi);
        
            }
            static void DegerAta(ref int gelendeger)
    {

    }
        
    }
}
