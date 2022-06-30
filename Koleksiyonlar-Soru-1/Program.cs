using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("20 tane sayi girin.");
                ArrayList asal = new ArrayList();
                ArrayList asalOlmayan = new ArrayList();
                bool asalMi = true;
                int asalToplam = 0;
                int asalOlmayanToplam = 0;
                for (int i = 0; i < 20; i++)
                {
                    asalMi = true;
                    int k = Convert.ToInt32(Console.ReadLine());
                    if (k < 0)
                    {
                        Console.WriteLine("Girdiginiz sayi negatif tekrar girin");
                        --i;
                        continue;
                    }
                    for (int j = 2; j <= k / 2; j++)
                    {
                        if (k % j == 0)
                        {
                            asalMi = false;
                        }
                    }
                    if (k == 2 || k == 3 || asalMi && k != 1)
                    {
                        asal.Add(k);
                        asalToplam += k;
                    }
                    else if (k == 1 || !asalMi)
                    {
                        asalOlmayan.Add(k);
                        asalOlmayanToplam += k;
                    }
                }
                asal.Sort();
                asalOlmayan.Sort();
                asal.Reverse();
                asalOlmayan.Reverse();
                Console.WriteLine("Asal sayilarin sayisi " + asal.Count
                    + " ortalamasi " + (double)asalToplam / asal.Count);
                Console.WriteLine("Asal Sayilar Listesi");
                foreach (int item in asal)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Asal Olmayan sayilarin sayisi " + asalOlmayan.Count
                    + " ortalamasi " + (double)asalOlmayanToplam / asalOlmayan.Count);
                Console.WriteLine("Asal Olmayan Sayilar Listesi");
                foreach (int item in asalOlmayan)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
