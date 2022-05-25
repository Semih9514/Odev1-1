using System;

namespace Odev1_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Kaç adet pozitif Sayı Gireceksiniz:");
            int deger = Int32.Parse(Console.ReadLine());

            int[] dizi = new int[deger];

            for(int i=0;i<deger;i++)
            {
                Console.Write("{0}. Sayı Giriniz:",i+1);
                dizi[i]=Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girdiğiniz Sayılardan Çift Olanları");
            Console.WriteLine("-------------------");
            foreach (var item in dizi)
            {
                if (item%2==0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
