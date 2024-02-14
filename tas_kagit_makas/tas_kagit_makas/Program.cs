using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tas_kagit_makas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skor1 = 0;
            int skor2 = 0;
            int deger;
            string k_deger;
            string[] pc = { "Tas", "Kagit", "Makas" };
            int a;
            Random rand = new Random();

            Console.WriteLine("****Oyun Kurallari****\nTas icin 1'e basiniz\nKagit icin 2'ye basiniz\nMakas icin 3'e basiniz\nCikmak icin 9'a basiniz");
            Console.WriteLine("---Oyun Basliyor---");
            do
            {
                Console.Write("Sayi giriniz:");
                deger = Convert.ToInt32(Console.ReadLine());
                k_deger = deger == 1 ? "Tas" : deger == 2 ? "Kagit" : deger == 3 ? "Makas" : "Yanlis deger girdiniz!!";
                if (deger == 1 || deger == 2 || deger == 3)
                { 
                    a = rand.Next(3);   // 0,1,2 degerlerini alabilir
                    if (k_deger == pc[a])
                    {
                        Console.WriteLine(" Siz\t VS \t Pc");
                        Console.WriteLine(" " + k_deger + "\t VS \t" + pc[a]);
                        Console.WriteLine("Bu el berabere");
                        Console.WriteLine("Skor: siz=" + skor1 + "\tpc=" + skor2);
                        Console.WriteLine("-------------------------");
                    }

                    if (k_deger == "Tas" && pc[a] == "Kagit")
                    {
                        skor2++;
                        Console.WriteLine(" Siz\t VS \t Pc");
                        Console.WriteLine(" " + k_deger + "\t VS \t" + pc[a]);
                        Console.WriteLine("Bu eli bilgisayar kazandi");
                        Console.WriteLine("Skor: siz=" + skor1 + "\tpc=" + skor2);
                        Console.WriteLine("-------------------------");
                    }
                    if (k_deger == "Tas" && pc[a] == "Makas")
                    {
                        skor1++;
                        Console.WriteLine(" Siz\t VS \t Pc");
                        Console.WriteLine(" " + k_deger + "\t VS \t" + pc[a]);
                        Console.WriteLine("Bu eli siz kazandiniz");
                        Console.WriteLine("Skor: siz=" + skor1 + "\tpc=" + skor2);
                        Console.WriteLine("-------------------------");
                    }
                    if (k_deger == "Kagit" && pc[a] == "Tas")
                    {
                        skor1++;
                        Console.WriteLine(" Siz\t VS \t Pc");
                        Console.WriteLine(" " + k_deger + "\t VS \t" + pc[a]);
                        Console.WriteLine("Bu eli siz kazandiniz");
                        Console.WriteLine("Skor: siz=" + skor1 + "\tpc=" + skor2);
                        Console.WriteLine("-------------------------");
                    }
                    if (k_deger == "Kagit" && pc[a] == "Makas")
                    {
                        skor2++;
                        Console.WriteLine(" Siz\t VS \t Pc");
                        Console.WriteLine(" " + k_deger + "\t VS \t" + pc[a]);
                        Console.WriteLine("Bu eli bilgisayar kazandi");
                        Console.WriteLine("Skor: siz=" + skor1 + "\tpc=" + skor2);
                        Console.WriteLine("-------------------------");
                    }
                    if (k_deger == "Makas" && pc[a] == "Tas")
                    {
                        skor2++;
                        Console.WriteLine(" Siz\t VS \t Pc");
                        Console.WriteLine(" " + k_deger + "\t VS \t" + pc[a]);
                        Console.WriteLine("Bu eli bilgisayar kazandi");
                        Console.WriteLine("Skor: siz=" + skor1 + "\tpc=" + skor2);
                        Console.WriteLine("-------------------------");
                    }
                    if (k_deger == "Makas" && pc[a] == "Kagit")
                    {
                        skor1++;
                        Console.WriteLine(" Siz\t VS \t Pc");
                        Console.WriteLine(" " + k_deger + "\t VS \t" + pc[a]);
                        Console.WriteLine("Bu eli siz kazandiniz");
                        Console.WriteLine("Skor: siz=" + skor1 + "\tpc=" + skor2);
                        Console.WriteLine("-------------------------");
                    }
                }
                else if(deger != 9)
                    Console.WriteLine(k_deger);
            } while (deger != 9);

            Console.ReadLine();
        }
    }
}
