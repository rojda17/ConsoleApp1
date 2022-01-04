using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03012022_Metotlar
{
    public class Matematik
    {
        public void menuhazirla()
        {
            Console.Clear();
            Console.WriteLine("**Menü**");
            Console.WriteLine("Toplama İşlemi(+)");
            Console.WriteLine("Çıkarma İşlemi(-)");
            Console.WriteLine("Çarpma İşlemi(*)");
            Console.WriteLine("Bölme İşlemi(/)");
            Console.WriteLine("Faktoriyel Hesapla(!)");
        }

        public decimal topla(decimal sayi1, decimal sayi2)
        {
            decimal topla = sayi1 + sayi2;
            return topla;
        }
        public decimal cikarma(decimal sayi1, decimal sayi2)
        {
            decimal fark = sayi1 - sayi2;
            return fark;

        }
        public decimal carpım(decimal sayi1, decimal sayi2)
        {
            decimal carpim = sayi1 * sayi2;
            return carpim;
        }
        public decimal bölüm(decimal sayi1, decimal sayi2)
        {
            decimal bölüm = sayi1 / sayi2;
            return bölüm;
        }
        public int faktoriyel(int sayi)
        {
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            return faktoriyel;
        }
    }
}
