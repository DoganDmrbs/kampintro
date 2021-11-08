using System;
using System.Collections.Generic;
using System.Text;
// bu şekil isimlendirme görürsen ürünle ilgili operasyonlar var demektir.
//CRUD(created,read,update,delete) operasyonları
namespace OOP1
{
    class ProductManager
    {
        //ürün eklicek isek bu operasyone neyi ekliyeceğimizi söylemememiz gerekir.
        public void Add(Product product) //Product product demek string ad demek gibi düşün.
        // product parametre demek product türünde(string gibi) bişey ver demek.
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        public void BiseyYap(int sayi)//örnek
        {
            sayi = 99;
        }
    }
}
