using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınıfÖrnek
{
    class Personel
    {
        public string TCNo;
        public string ad;
        public string soyad;
        ArrayList liste = new ArrayList();
        public void personelekle(string TC,string ad,string soyad)
        {
            liste.Add(ad);
            liste.Add(soyad);
            liste.Add(TC);
            Console.WriteLine("personel eklendi");

        }
        public void personelsil()
        {

        }
        public void personel()
        { }
    }
}
