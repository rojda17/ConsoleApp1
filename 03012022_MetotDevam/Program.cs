using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03012022_MetotDevam
{
    class Program
    {


        //1-100 ARASINDA 10 TANE SAYI ÜRETEN BİR METOT
        int[] gelendizi = RandomSayi();
        DiziyiYaz(gelendizi);
        

            static void DiziyiYaz(int[] dizi)
              {
            foreach (int sayi in dizi)
            {
                Console.WriteLine(sayi);
            }
              }
            static int[] RandomSayi()
            {
                int[] dizi = new int[10];
                Random rnd = new Random();

                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = rnd.Next(1, 100);

                }
            return dizi;
            }

        }
    }

