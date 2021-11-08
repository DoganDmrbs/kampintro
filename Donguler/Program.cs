using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
            string kurs2 = "Programaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // Bu tip verileri arraylerde tutarız.
            // ileri seviylerde normalde olması gereken "string[] kurslar = urunleri getir"  olcak
            string[] kurslar = new string[] {"Yazılım Geliştirici Yerleştirme Kampı", 
                "Programaya başlangıç için temel kurs", "java", "python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                
            }
            Console.WriteLine("For bitti");

            // foreach for dan daha kolay çalışır . dizileri tek tek dolaşmaya yarıyor. her dönüşte elemanlar için kurs diyoruz abc de diyebilirdik.
            // diziler genellikle foreach kullanılır kolay dolaşır. for geneldir ama kullanmanda sorun yok.
            foreach (string kurs in kurslar) // burdaki kırsa allians diyoruz
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}