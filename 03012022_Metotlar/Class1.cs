using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03012022_Metotlar
{
    public class Class1
    {
        public void OgrenciOrtHesapla(string ad,string soyad,int not1,int not2)
        {
            int ort = (not1 + not2) / 2;
            if (ort < 50)
            {
                Console.WriteLine("{0}{1} Kaldınız", ad, soyad);
            }
            else
            {
                Console.WriteLine("{0}{1} Geçtiniz", ad, soyad);
            }
        }
             
        public void OgrenciMetot1()
        {
            Console.WriteLine("Ben public ögrenci metodu");
        }
        private void OgrenciMetot2()
        {
            Console.WriteLine("Ben private ögrenci metodu");
         }
           
    }
}
