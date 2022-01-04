using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31122021_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //  1000
            //  0100
            //  0010
            //  0001
            int[,] sayilar = new int[4,4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(i==j)
                        sayilar[i, j] = 1;//sayılari ilk tanımladığımızda zaten tüm değerler 0 olduğu için böyle tanımladık 
                }
            }
            for (int i=0;i<4;i++)
            {
                for (int j = 0; j <4; j++)
                {
                    Console.Write(sayilar[i,j]);
                }
                Console.WriteLine();
             }
            Console.ReadLine();
            */
            /*
            //örnek
            int[,] sayilar = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || i+j==4 )//0,4 veya 3,1 toplamları 4 ediyor.
                        sayilar[j, i] = 1; 
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(sayilar[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            /*
            //bu örnek yanlış yapmadım derste
            int[,] sayilar = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i % 2 == 0 && j == 0 || j == 4)
                        sayilar[i, j] = 1;
                        Console.Write("1");
                    else if (i % 2 != 0 && j == 0 || j == 4)
                        Console.Write("2");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(sayilar[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */
            /*
            //dışarıdam girilen matris elemanlarını her satırda toplayıp son sütuna yazdıran program

            int[,] matris2 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)//son sutün boş kalsın diye j=3 dedik
                {
                    Console.WriteLine("sayı giriniz: ");
                    string sayi = Console.ReadLine();
                    matris2[i, j] = Convert.ToInt32(sayi);//dışarıdan girdiğimiz sayıyı matrise attık
                }
            }
            for (int i = 0; i < 3; i++)
            {
                int toplam = 0;
                for (int j = 0; j < 3; j++)
                {
                    toplam += matris2[i, j];
                }
                matris2[i, 3] = toplam;
            }
            Console.WriteLine();
            //bu kısım sadece diziyi ekrana yazdırır.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(matris2[i, j]);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            */
            int[,,] matris3D = new int[2, 3, 3];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        matris3D[i, j, k] = rnd.Next(0,9);
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(matris3D[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ReadLine();
            }


        }           
       
    }
}
