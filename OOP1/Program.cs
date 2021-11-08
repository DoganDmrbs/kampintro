using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // Alttaki gibi tanımlayabiliyoruz.
            Product product2 = new Product {Id = 2, CategoryId=5,
                 UnitsInStock=5, ProductName="Kalem", UnitPrice=35};

            // ProductManager productManager; demek string isim; demek gibi düşün
            //steak                         heap  // referans tiplerini heapde oluşması için new lememiz gerekir.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);//  e-ticaret sitesindeki buton olarak düşün
            //product1 dedik yukarıdaki tanımladığımız productları istedi çünkü.
            //Console.WriteLine(product1.ProductName); // sonuç kamera

            //örnek
            int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi); // sonuç 100

            // int,double,bool.... değer tip
            //diziler,class,abstract class, interface ... referans tip


            productManager.Topla2(3, 6); // void emir kipidir yap et ve biter sonra kullanılmaz.

            int toplamaSonucu = productManager.Topla(3, 6);
            // void de bunları yapamayız.
            // sonra başka yerlerde kullanmak için return lazım.
            Console.WriteLine(toplamaSonucu*2); //cw(productManager.Topla(3, 6)*2)'de yazılabilir.


        }
    }
}