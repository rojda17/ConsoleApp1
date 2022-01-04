using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30122021_ödev
{
    class Program
    {
        static void Main(string[] args)
        {

            int yaş;
            int ikramiye;
            Console.WriteLine("cinsiyeti giriniz:");
            Console.WriteLine("Maaşı giriniz: ");
            Console.WriteLine("Yaşı giriniz: ");
            string yaş = Console.ReadLine();
            string maaş = Console.ReadLine();
            string cinsiyet = Console.ReadLine();
            switch (cinsiyet)
            {
                case "erkek":
                    if (yaş >= 60)
                    {
                        ikramiye = maaş * 10;
                        Console.WriteLine("Emekli oldunuz");
                    }
                    else if (yaş < 60)
                    {










                    }
    }
}
