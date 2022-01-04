using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04012020_Class
{
    public class arac
    {
        public string marka;
        public string model;
        public string km;
        public int modelYil;
        public string YakitTip;
        public string VitesTip;
        public decimal AlisFiyati;
        public decimal SatisFiyati;
        
        

        public void BilgiYaz()
        {
            Console.WriteLine("Marka:{0},Model;{1},Model Yılı:{2}",marka,model,modelYil);
        }
    }
}
