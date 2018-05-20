using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV
{
    class DegerAl
    {
        Hesapla hsp = new Hesapla();
        YaziYo yazdır = new YaziYo();
       
        string sayi; //kullanıcıdan istenilen deger
        public void İsteme()
        {
           
            string DGR;//paranın türü
            do
            {
                Console.WriteLine("Döviz tipi giriniz (D: DOLAR / E: EURO)");
                DGR = Console.ReadLine();
                if (DGR != "D" && DGR != "d" && DGR != "E"&& DGR != "e")
                {
                    Console.WriteLine("Yanlış döviz tipi girdiniz");// girilen tür istenilen türlerden birimi kontrolü
                }
            } while (DGR != "D" && DGR != "d" && DGR != "E" && DGR != "e"); //girilen DGR bu degerlerden farklıysa deger tekrar istenir
            if (DGR == "D"|| DGR == "d")
            {
                DgrOku("D");
            }
            else
            {
                DgrOku("E");
            }
        }
        private void DgrOku(string dgr)
        {
           
            string X = dgr; //girilen türü unutmamak için X ddegişkenine atadım
            if (dgr == "D"||dgr=="d")
            {
                dgr = "Dolar";
            }
            else
            {
                dgr = "Euro";
            }
            Console.WriteLine("\n{0} miktarı giriniz", dgr);
            sayi = Convert.ToString(Console.ReadLine());
            char[] s = sayi.ToCharArray();//gelen  sitringi char dizisine atar
            if (s[0] == ',' || s[0] == '0')
            {
                Console.Write("Lütfen sayisal deger girin"); DgrOku(X);
            }
            else
            {
                foreach (char k in s) //char dizisinde karekter olup olmadıgını arar
                {
                    switch (k)
                    {
                        case '0': break;
                        case '1': break;
                        case '2': break;
                        case '3': break;
                        case '4': break;
                        case '5': break;
                        case '6': break;
                        case '7': break;
                        case '8': break;
                        case '9': break;
                        case ',': break;
                        default: Console.Write("Lütfen sayisal deger girin"); DgrOku(X); break;
                    }
                }
            }
            double sayi1 = Convert.ToDouble(sayi.Replace(",", ",")); //gelen string degerini double cevirdim ki istenilen  aralık konturolünü yapıyım                   
                if (sayi1 < 1 || sayi1 > 1000000)
                {
                    Console.WriteLine("Lütfen  1 ile 1 milyon arası girin");
                    DgrOku(X);
                }     
            AlKontrol(sayi, X);
            hsp.Hesap(sayi1, X);   
           AlKontrol(hsp.gozde, hsp.sen);
        }
       public void AlKontrol(string para,string tur)
        {
            int gg = para.IndexOf(",");//gelen strin icerisinnde , karekterini arar ve buldugunda index sini döndürür aksi taktir de -1 döndürür
            if (gg == -1) //eger gelen stringte , yoksa çalışır
            {
                char[] para1 = para.ToCharArray(); // gelen  sitringi char dizisine atar
                Console.WriteLine("\n-----Yazı ile------");
                yazdır.yaz(para1, tur, 0);// yaziyo clasındaki yaz metoduyla rakamları harf ile yazar "0 virgül  oncesini 1 virgülden sonrasını temsil eder"
            }
            else
            {
                
                string ko = para.Substring(0, gg);//gelen string , içerdiginden bastan vir güle kadar olan bölümü  farklı bir diziye attım

                string ko1 = para.Substring(gg + 1, para.Length-1 - gg );//, den sonrasını ayrı bir diziye attım 
                if (ko1.Length==1)
                {
                    ko1 += "0";
                }
              
                char[] para2 = ko.ToCharArray();// oluşan stringleri ayri iki char dizisine atttım
                char[] para3 = ko1.ToCharArray();
                Console.WriteLine("\n-----Yazı ile------");
                yazdır.yaz(para2, tur, 0);
                yazdır.yaz(para3, tur, 1); // ve yaz metotlarıyla yazdırdım

            }
        }
     }
}
