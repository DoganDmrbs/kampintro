using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği (veri türünü önüne yazdık) 
            // Do not repeat yourself - Kendini tekrarlama
            // KategoriEtiketi demek bir değer tutucu yani kategori etiketi için bir takma isim 
            string kategoriEtiketi = "kategori"; // Değişken tanımlama

            int ogrencisayısı = 32000; // int veri tipi sınırları olan veri tipidir

            double faizOranı = 1.45; // ondalıklı sayılar

            bool sistemeGirisYapisMi = true; // true yada false bi sistemden gelir function yazabiliriz

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");

            }


            if (sistemeGirisYapisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(ogrencisayısı);

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
