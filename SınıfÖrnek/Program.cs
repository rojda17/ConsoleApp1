using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfÖrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.ad = "elif";
            p.soyad = "cengiz";
            p.TCNo = "123456789";

            p.personelekle(p.TCNo,p.ad,p.soyad);
        }
    }
}
