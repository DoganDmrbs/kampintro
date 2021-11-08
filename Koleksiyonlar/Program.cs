using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // bunlar gerçekte bir veri kaynağından gelir.
            //4 elemanlı dizi 5 elemanlı yapılmaz arttırılamaz.
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };//isimler 4 elemandan oluşuyo
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //  elemanlı yeni dizi oluşturduk
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); // 0. eleman geldi ama boş geldi çünkü dizi boş yeni dizi oluştu
            //yukardakinler yanlış kullanım dinamik değil.
            //genellikle array değil koleksiyon kullanırız.
            // Bu şimdiki zamanda kullanılmaz ekleme çıkarma yapılırken vs sıkıntı. koleksiyon kullanılır aşağıdaki gibi
            // 4 elemanı 5 yaparsak eskileri kaybederiz dinamik değil

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            // bir clasa böyle bir yapı nasıl ekleriz Genericsintro da

            // list aslında arka planda bir array yönetiyor.


        }
    }
}
