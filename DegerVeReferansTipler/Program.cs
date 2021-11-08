using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999;
            // sayilar 1 i 2 ye eşitlediğimizde referansları eşitledik sayilar ikinin değerleri 
            // sayilar 1 e geçti 2 silinmedi. yani 1 2 nin değerlerini tanıdı. 2. nin 0. eleman ekleyince cevap 999 oldu
            // c dilinde buna pointer denir
        }
    }
}