using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30122021_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] isimler = new string[5];
            string[] ogrno = { "11", "12", "13" };
            isimler[0] = "rojda";
            int[] sayilar = new int[5];

            sayilar[0] = 45;
            sayilar[1] = 32;
            sayilar[3] = 24;

            foreach(int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
            */
            /*
            //kullanıcının girdiği 10 adet sayıyı dizi haline getirip ekrana yazdırır.
            int[] dizi1 = new int[10];
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz: ",i+1);
                int sayi = int.Parse(Console.ReadLine());
                dizi1[i] = sayi;
                toplam += dizi1[i];
            }
            int toplam2 = 0;
            foreach (int sayi in dizi1)
            {
                toplam2 += sayi;
                Console.WriteLine(sayi);
            }
            Console.WriteLine(toplam);//for içindeki toplam
            Console.WriteLine(toplam2);//foreach içindeki toplam
            Console.ReadLine();
        }
            */

            //20 elemanlı bir dizi oluşturup her bir elemana random(1,10) arasında sayı at.Dizi içinde kaç tane 4 olduğunu bul.
            /*
            int[] rastgelesayilar = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                rastgelesayilar[i] = rnd.Next(1, 10);
            }
            int kactane = 0;
            foreach (int sayi in rastgelesayilar)
            {
                if (sayi == 4)
                {
                    kactane++;
                }
               
            }
            Console.WriteLine("Girmiş olduğunuz dizi içersinde {0} tane 4 vardır.", kactane);
            Console.ReadLine();
            */

            /*
            //Dizideki tek sayıları bulur.
            int[] rastgelesayilar = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                rastgelesayilar[i] = rnd.Next(1, 10);
            }
            int kactane = 0;
            Console.WriteLine("Dizi içindeki tek sayılar");
            foreach (int sayi in rastgelesayilar)
            {
                if (sayi % 2 != 0)
                    Console.WriteLine(sayi + " ");
                if (sayi == 4)
                {
                    kactane++;
                }

            }
            Console.WriteLine("Girmiş olduğunuz dizi içersinde {0} tane 4 vardır.", kactane);
            Console.ReadLine();
            */
            /*
            int[] rastgelesayilar = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                rastgelesayilar[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Dizi içindeki negatif sayılar");
            foreach (int sayi in rastgelesayilar)
            {
                if (sayi < 0)
                {
                    Console.WriteLine(sayi + " ");
                }
            }
            Console.WriteLine("Dizi içindeki pozitif sayılar");
            foreach(int sayi in rastgelesayilar)
            {
                if (sayi > 0)
                {
                    Console.WriteLine(sayi + " ");
                }
            }
            Console.ReadLine();
            */
            /*
            //aşağıdaki sesli harfler girdiğimiz metinde var mı yok mu kontrol eder.
            char[] harfler = { 'a', 'e', 'ı', 'o', 'ö', 'u', 'ü' };
            int sayac = 0;
            Console.WriteLine("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            foreach (char harf in metin.ToLower()) 
            {
                for (int i = 0; i < harfler.Length; i++)
                {
                    if (harf==harfler[i])
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine(sayac);
            Console.ReadLine();
            */
            /*
            string karakter = "0123456789abcçdefghıijklmnoöuüprsştuüvyz";
            
            Console.WriteLine("Bir metin giriniz: ");
            string metin = Console.ReadLine();
            metin = metin.ToLower();
          
            for (int i = 0; i < karakter.Length; i++)
            {
            int sayac = 0;

                for (int j = 0; j < metin.Length; j++)
                {
                   if(karakter[i]==metin[j])
                    {
                        sayac++;
                    }
                }

                if (sayac > 0)
                    Console.WriteLine(karakter[i] + "harfi" + sayac + "adet var");

            }
            Console.ReadLine();
            */

            //10 elemanlı dizi içine şehir ekle.Baş harfe göre listele.
            string[] sehirler = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}. sehir:", i+1);
                sehirler[i] = Console.ReadLine();
             }
            //Array.Sort(sehirler);//sehirler dizisini harf sırasına göre dizer
            //Array.Reverse(sehirler);//girdiğimiz diziyi ters çevirerek yazar
            int Index=Array.IndexOf(sehirler,"istanbul");//"istanbul" yazdığımız dizide varsa kaçıncı indexte ona bakar
            int Index2 = Array.LastIndexOf(sehirler, "istanbul");//"istanbul"u dizi içinde tersten arar ve index numarasını verir.
            Console.WriteLine(Index);
            Console.WriteLine(Index2);
            /*
            foreach ( string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            */
            
            
            string[] ilceler = new string[10];
            Array.Copy(sehirler, ilceler, 5);//sehirler dizisinin içinden 5 tane elemanı ilçeler dizisine kopyalar.
            sehirler.CopyTo(ilceler, 5);//ilçelerin 5.indexinden itibaren şehirler dizisinden ilçeler dizisine kopyalar.
            Array.Copy(sehirler, 3, ilceler, 4, 5);//Sehirler klasörünün 3. indexinden 5 elemanı al,ilçelerin 4.indexinden itibaren yapıştır
            Array.Clear(sehirler, 3, 5);//Sehirler dizisinin 3. ındexinden itibaren 5 tane elemanı siler. 
            Console.WriteLine(Index);
            Console.ReadLine();
        }
        
    }
}


