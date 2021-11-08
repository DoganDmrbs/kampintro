using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs(); // yukardaki gibi string (1 TANE ELEMAN TUTAN DEĞİL), kurs clasını tutuyor.
            // kurs clasımın bir sürü değeri var nasıl yazıcam. Alanları aşağıdaki gibi veriyoruz
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 36;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Dogan Demirbaş";
            kurs2.IzlenmeOrani = 27;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Berkay Varış";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            // içinde kurs clasını tanımlayan bir array tanımladık
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};
            foreach (var kurs in kurslar) // kurs takma isim her döndüğünde ilgili sıraya kurs diyor
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs // Kursumuzun 3 tane özelliği ( değişkeni ) var demek...
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
