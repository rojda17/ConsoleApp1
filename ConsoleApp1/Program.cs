using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class  Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deneme");
            Console.Write("rojda");
            Console.ReadLine();

            //yorum
        



            Console.Clear();

            bool mantiksal = true;
            string sehir = "istanbul";
            Console.WriteLine(sehir.ToUpper());
            Console.WriteLine(sehir.ToLower());
            Console.WriteLine(sehir.Substring(4));
            Console.ReadLine();

            string yas = "50";
            int yas2;
            yas2 = int.Parse(yas);//string bir değerin int çevirir

            int yas3 = Convert.ToInt32(yas);//string bir değeri int a çevirir.projelerde daha çok karşımıza çıkar.

            string metin = null;

            var ad = "rojda";//değeri string olarak tanımlar

            const double pi = 3.14;//programda asla değişmeyecek bir şeyi tanımlamak için kullanılır.

            //bilinçli tür dönüşümü

            byte rakam;
            int rakam2 = 100;
            rakam = (byte)rakam2;

            //büyük veri tipini küçük veri tipine dönüştürür.dönüşümü yapması için parantez ininde byte olduğunu belirtmemeiz gerekir.

            //bilinçsiz tür dönüşümü

            byte rakam3 = 200;
            int rakam4 = rakam3;
            //int zaten byte ı da içine alacağı için program hata vermiyor.


            checked //hata var mı diye kontrol eder.
            {
                byte rakam5= 200;
                int rakam6= rakam3;

            }

            //unchecked hatayı görmezden gelir.

            string s = Console.Read().ToString();//GİRİLEN KARAKTERİN ASCII KARŞILIĞINI VERİR.
            Console.WriteLine(s);
            Console.ReadLine();
            Console.ReadLine();


            object obj;//object her türlü veriyi içine alır
            obj = "bilgisayar";
            obj = 1;//boxing

            int j = (int)obj;//unboxing 



      

          






          

         

        }
    }
}
