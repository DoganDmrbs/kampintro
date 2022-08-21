using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        // başvuruyu hangi krediye göre hesaplamamı istedigini bana söyle desem bunun için
        // hepsinin referansını elinde tutan IKrediManager kullanırız.
        // başvuru kredi bağımsız hale geldi. ne gönderirsek o çalışır.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        { //method injection yapıyoruz yani hangi kredi kullancagını ve log yapacagını seçiyoruz.

            // Başvuran bilgilerini değerlendirme
            // 

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); 
            // yaparsak bütün krediler konutkredi üzerinden hesaplanır. konut kredisine bağlı olurlar yanlış olur.

            krediManager.Hesapla();
            loggerService.Log(); // sistemde hangi loglayıcı seçilmiş ise onu logla dedik.
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
            // bana bir liste ver listeler hakkında bilgi edinim sayı belli değil çünkü
        {
            // listedeki her bir kredinin hesabını yapar. hangisi çağırırsak.
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }


        }
    }
}
