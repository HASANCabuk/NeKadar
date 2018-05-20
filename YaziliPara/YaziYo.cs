using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV
{

    class YaziYo
    {
       
        public void yaz(char[] dz, string cins, int olay)
        {
           
            int syc = dz.Length;//gelen stringin boyutunu  aldım
            if (olay==1&&syc>2)
            {
                syc = 2;
            }
            if (olay == 0) //sayinin virgülsüz olup olmadıgı 
            {

                switch (syc) // gelen stringin basamak degerine göre metotlar ile yazma
                {
                    case 1: Birler(dz[0]); Cins(cins, 0); break;
                    case 2:
                        Onlar(dz[0]);
                        Birler(dz[1]); Cins(cins, 0); break;
                    case 3:
                        Yüzler(dz[0]);
                        Onlar(dz[1]);
                        Birler(dz[2]); Cins(cins, 0); break;
                    case 4:
                        Binler(dz[0]);
                        Yüzler(dz[1]);
                        Onlar(dz[2]);
                        Birler(dz[3]); Cins(cins, 0); break;
                    case 5:
                        Onlar(dz[0]);
                        if (dz[1] == '1')
                        {
                            Birler(dz[1]); Binler(dz[1]); Yüzler(dz[2]); Onlar(dz[3]); Birler(dz[4]); Cins(cins, 0); break;
                        }
                        Binler(dz[1]);
                        Yüzler(dz[2]);
                        Onlar(dz[3]);
                        Birler(dz[4]); Cins(cins, 0); break;
                    case 6:
                        Yüzler(dz[0]); Onlar(dz[1]);
                        if (dz[2] == '1')
                        {
                            Birler(dz[2]); Binler(dz[2]); Yüzler(dz[3]); Onlar(dz[4]); Birler(dz[5]); Cins(cins, 0); break;

                        }
                        Binler(dz[2]);
                        Yüzler(dz[3]);
                        Onlar(dz[4]);
                        Birler(dz[5]); Cins(cins, 0); break;
                    case 7:
                        Milyonlar(dz[0]);
                        Yüzler(dz[1]); Onlar(dz[2]);
                        if (dz[3] == '1')
                        {
                            Birler(dz[3]); Binler(dz[3]); Yüzler(dz[4]); Onlar(dz[5]); Birler(dz[6]); Cins(cins, 0); break;

                        }
                        if (dz[3] == '0')
                        {
                            Yüzler(dz[4]); Onlar(dz[5]); Birler(dz[6]); Cins(cins, 0); break;
                        }
                        Binler(dz[3]);
                        Yüzler(dz[4]);
                        Onlar(dz[5]);
                        Birler(dz[6]); Cins(cins, 0); break;
                }
            }
            else
            {
                switch (syc)
                {
                    case 1: Birler(dz[0]); Cins(cins, 1); break;
                    case 2:
                        Onlar(dz[0]);
                        Birler(dz[1]); Cins(cins, 1); break;                   
                }

            }
        }
        void Birler(char b)//birler bölümü yazdırma
        {

            switch (b)
            {
                case '1': Console.Write(" Bir "); break;
                case '2': Console.Write(" İki "); break;
                case '3': Console.Write(" Üç "); break;
                case '4': Console.Write(" Dört "); break;
                case '5': Console.Write(" Beş "); break;
                case '6': Console.Write(" Altı "); break;
                case '7': Console.Write(" Yedi "); break;
                case '8': Console.Write(" Sekiz "); break;
                case '9': Console.Write(" Dokuz "); break;
            }
        }
        void Onlar(char o)// onlar bölümünü yazdırma
        {
            switch (o)
            {
                case '1': Console.Write(" On"); break;
                case '2': Console.Write(" Yirmi "); break;
                case '3': Console.Write(" Otuz "); break;
                case '4': Console.Write(" Kırk "); break;
                case '5': Console.Write(" Elli "); break;
                case '6': Console.Write(" Altmış "); break;
                case '7': Console.Write(" Yetmiş "); break;
                case '8': Console.Write(" Seksen"); break;
                case '9': Console.Write(" Doksan"); break;
            }
        }
        void Yüzler(char y)// yüzler bölümünü yazdırma
        {

            if (y != '0' && y != '1') //gelen basamak degerin 1 ve sıfır degilse  degeri ve yüz yazmasını saglar
            {
                Birler(y);
                Console.Write("Yüz");
            }
            else
            {
                if (y == '1')
                    Console.Write(" Yüz");// deger 1 ise yüz yazmasını saglar 

            }
        }
        void Binler(char b)//binler bölümünü yazdsırma
        {
            if (b != '1' && b != '0')//gelen basamak degerin 1 ve sıfır degilse  degeri ve bin yazmasını saglar
            {
                Birler(b);
                Console.Write(" Bin");
            }
            else
            {
                if (b == '1' || b == '0')// deger 1veya 0  ise bin yazmasını saglar
                {
                    Console.Write(" Bin");
                }           
            }
        }
        void Milyonlar(char m)
        {
            if (m != '0') //deger 0 degil ise   ise deger ve milyon yazar yazmasını saglar
            {
                Birler(m);
                Console.Write("Milyon");
            }
        }
        void Cins(string c, int o)// paranın cinsine göre  ve virgülden sonrasına karşılık ifade yazar
        {
            if (c == "D" || c == "d")
            {
                if (o == 0)
                {
                    c = "Dolar";
                }
                else
                    c = "Cent";
            }
            else
            {
                if (c == "E" || c == "e")
                {
                    if (o == 0)
                    {
                        c = "Euro";
                    }
                    else
                        c = "Cent";

                }
                else
                    if (c == "T" || c == "t")
                {
                    if (o == 0)
                    {
                        c = "TL";
                    }
                    else
                        c = "Kuruş";

                }               
            }
              Console.WriteLine(" {0}", c);
        }
    }
}
