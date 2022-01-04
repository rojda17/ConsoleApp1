using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28122021_KararYapıları_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("hangi aydasın?");
             string ay = Console.ReadLine();
             switch(ay)
             {
                 case "ocak":Console.WriteLine("1.ay");
                     break;

                case "şubat":Console.WriteLine("2.ay");
                     break;
                 case "mart":Console.WriteLine("3.ay");
                     break;
                 default:Console.WriteLine("BİLİNMEYEN");
                     break;






                }
            */

            /*
            Console.WriteLine("1.sayı:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("işlem");
            string işlem = Console.ReadLine();
            int toplam;
            switch(işlem)
            {
                case "+":
                    toplam = sayi1 + sayi2;
                    Console.WriteLine("toplam:" + toplam);//("toplam:{0}",toplam) aynı işlem
                    break;
                case "-":
                    int fark= sayi1 - sayi2;
                    Console.WriteLine("çıkarma:" + fark);
                    break;
                case "*":
                    int carpma = sayi1 * sayi2;
                    Console.WriteLine("çarpım: " + carpma);
                    break;
            */

            Console.WriteLine("kullanıcı kodu:");
            string kod = Console.ReadLine();
            switch(kod)
            {
                case "admin":
                    Console.WriteLine("tam yetki");
                    break;
                case "AA":
                case "BB":
                    Console.WriteLine("sınırlı yetki");
                    break;
                case "CC":Console.WriteLine("YAZMA YETKİSİ VAR:");
                    break;
                case "DD":Console.WriteLine("OKUMA YETKİSİ VAR");
                    break;
                default:Console.WriteLine("yetki yok");
                    break;

                    switch (DateTime.Now.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            break;
                        case DayOfWeek.Monday:
                            break;
                        case DayOfWeek.Tuesday:
                            break;
                        case DayOfWeek.Wednesday:
                            break;
                        case DayOfWeek.Thursday:
                            break;
                        case DayOfWeek.Friday:
                            break;
                        case DayOfWeek.Saturday:
                            break;
                        default:
                            break;
                    }




            }
            Console.ReadLine();
          

            }
            


        }
    }
