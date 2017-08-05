using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SergenSiyliPiSayisi
{
  
    class Program
    {
     
        static void Main()
        {

            //string[] sayilar = new string[] { PiSayisiHesapla(10) };


            int sifir = 0, bir = 0, iki = 0, uc = 0, dort = 0, bes = 0, alti = 0, yedi = 0, sekiz = 0, dokuz = 0;
            for (int i = 0; i <1000000; i++)//<--BURADAN DÖNGÜNÜN KAÇ KERE DÖNECEĞİ BELİRLENİR.Pİ SAYISININ ÜÇ VİRGÜLDEN
                                            //SONRAKİ SAYININ KAÇ BASAMAKLI OLACAĞI
            {
                string sayi = PiSayisiHesapla(1000000).ToString().Substring(i,1);//-< BURADAN DA Pİ HESAPLANIRKEN KAÇ BASAMAK
                                                                                 //HESAPLANACAĞI AYARLANABİLİR.1.000.000 ŞU AN İÇİN
                switch (sayi)
                {
                    case "0":
                        sifir++;
                        
                        break;
                    case "1":
                        bir++;
                       
                        break;
                    case "2":
                        iki++;
                        
                        break;
                    case "3":
                        uc++;
                       
                        break;
                    case "4":
                        dort++;
                        break;
                    case "5":
                        bes++;
                        break;
                    case "6":
                        alti++;
                        break;
                    case "7":
                        yedi++;
                        break;
                    case "8":
                        sekiz++;
                        break;
                    case "9":
                        dokuz++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("ÜÇ VİRGÜLDEN SONRA (3,.........);");
            Console.WriteLine("{0} tane Sıfır var", sifir);
            Console.WriteLine("{0} tane Bir var", bir);
            Console.WriteLine("{0} tane İki var", iki);
            Console.WriteLine("{0} tane Üc var", uc);
            Console.WriteLine("{0} tane Dört var", dort);
            Console.WriteLine("{0} tane Bes var", bes);
            Console.WriteLine("{0} tane Altı var", alti);
            Console.WriteLine("{0} tane Yedi var", yedi);
            Console.WriteLine("{0} tane Sekiz var", sekiz);
            Console.WriteLine("{0} tane Dokuz var", dokuz);
            //Console.WriteLine("{0}", sayilar); <--//istenirse burada pi sayısının tam hali gösterilebilir,ancak 1 milyon rakam,
            //konsolda gösterilemiyor.
            Console.WriteLine("* ÇIKMAK İÇİN BİR TUŞA BASINIZ *");
            Console.ReadKey();
        }

        public static string PiSayisiHesapla(int sayilar)
        {
            sayilar++;

            uint[] x = new uint[sayilar * 10 / 3 + 2];
            uint[] r = new uint[sayilar * 10 / 3 + 2];

            uint[] pi = new uint[sayilar];

            for (int j = 0; j < x.Length; j++)
                x[j] = 20;

            for (int i = 0; i < sayilar; i++)
            {
                uint elde = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    uint num = (uint)(x.Length - j - 1);
                    uint dem = num * 2 + 1;

                    x[j] += elde;

                    uint q = x[j] / dem;
                    r[j] = x[j] % dem;

                    elde = q * num;
                }


                pi[i] = (x[x.Length - 1] / 10);


                r[x.Length - 1] = x[x.Length - 1] % 10; ;

                for (int j = 0; j < x.Length; j++)
                    x[j] = r[j] * 10;
            }

            var sonuc = "";

            uint c = 0;

            for (int i = pi.Length - 1; i >= 0; i--)
            {
                pi[i] += c;
                c = pi[i] / 10;

                sonuc = (pi[i] % 10).ToString() + sonuc;
            }

            return sonuc;
        }


    }
}