using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV
{
   
    class Hesapla
    {       
         double d= 3.7; 
         double e = 3.92;
        double sonuc;
       public string gozde;
       public string sen;
       public void Hesap(double enpara ,string tur)// hesaplanmaya gelen ifade vetütü
        {
            Console.Write("\n--Türk Lirası karşılıgı--\n");
          if(tur=="D"|| tur == "d")
            {
                Dolar(enpara);
            }
            else
            {
                Euro(enpara);
            }
            Console.Write(" {0}", sonuc);
            gozde = sonuc.ToString();
            sen = "T";      
        }
        void Dolar(double bolpara) // dolar cinsinden hesaplama
        {
           sonuc  = bolpara * d;
        }
        void Euro(double bolpara)// Euro cinsinden hesaplama
        {
            sonuc = bolpara * e;
        } 
      
    }
}
