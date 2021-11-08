using System;
// Metotlar tekrar tekrar kullanılabilirliği sağlayan bir kod bloklarıdır.
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); // bir class tanımlamak için bunu yazmamız lazım buna clasın örneği deniyor.
            urun1.Adı = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun(); 
            urun2.Adı = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            // array bir veri tipinde istediğin kadar datayı tutmasıydı.
            Urun[] urunler = new Urun[] {urun1,urun2 }; // ürün arrayı oluşturduk.
            
            //Neyle çalışıcağını bilmek istiyor o yüzden 1. Urun kelimesini yazıyoruz bunada type-safe deniyor
            //Var da yazabiliriz ama bişey değişmicek arka planda onu Urun yapıcak gene
            foreach (Urun urun in urunler) // 2. urun kelimesi takma ismimiz x diyebiliriz her döngüde takma isim alcak
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("---------Metotlar-------");

            //instance class örneği oluşturduk
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12,5);
            sepetManager.Ekle2("Elma", "Yeşil elma", 32,6);
            sepetManager.Ekle2("Karpuz", "Dİyarbakır karpuzu", 15,10);

        }
    }
}