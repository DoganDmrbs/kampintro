using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
   // imzanın aynı içeriğinin farklı olduğu durumlarda clası class kredimanager değil interface yapıyoruz.
   // interface şablon görevi görür. şunu anlatır eğer birisi bu interface kullanırsa void hesapla metodu gibi methodları kullanmak zorunda
   // okunurluğu arttırmak için I ile başlatırız. IKrediManager
   // Interface yi genelde operasyonel methodlarda kullanıyoruz.

    // **** interface leri birbirlerinin alternatifi olan ama kod içerikleri farkı olan durumlar için kullanırız.
    interface IKrediManager // tek başına anlam ifade etmez ebebeyn görevi görüyor.(inheritance)
    {
        void Hesapla();

        void BiseyYap();
        
    }
}

