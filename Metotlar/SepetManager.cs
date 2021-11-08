using System;
using System.Collections.Generic;
using System.Text;
// manager gibi kelimeler görürsek bu bir operasyon tutuyor demektir.
namespace Metotlar
{
    class SepetManager
    {
        //neyi eklemek istediğini metoda vermen lazım buna parametre denir.
        public void Ekle(Urun urun) //sepete ürün ekleme
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adı );
            Console.WriteLine("Sepete eklendi : " + urun.Aciklama);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
