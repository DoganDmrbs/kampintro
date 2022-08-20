using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporte
    //:musteri yazınca sen bir müşterisin dedik yani miras yaptık . İNHERİTANCE
    
    class TuzelMusteri:Musteri 
    {

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
//Müşteride olan herşey tüzeldede var kabul edilir.
//musteri,personel,empolye gibi birşey görüyorsan onlar varlıktır entity dir,içiresinde operasyon olmaz.