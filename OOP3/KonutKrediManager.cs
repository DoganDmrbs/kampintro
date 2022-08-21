using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager // çünkü hepsi içinde hesapla olsun istiyorum 
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı");
        }
    }
}
