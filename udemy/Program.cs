using System;
using System.Linq;

namespace udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply1(2, 4, 5));
            Console.WriteLine(Add(1,2,3,4,5,6));

        



        static int Multiply(int number1, int number2) // intten sonra ki kısma metodun imzası denir
        {
            return number1 * number2;
        }
        static int Multiply1(int number1, int number2, int number3) // aynı isim farklı parametreler kullanırsak metotların overload olur.
        {
            return number1 * number2 * number3;
        }

        //static int Add(int number1, int number2) // params keybeardı fazla sayılar için ovearload olmasını engeller o yüzden kullanırız.
        static int Add(params int[] numbers) // İstediğimiz kadar parametre gönderebiliriz.
                                             // Add(int number, params int [] numbers) yaparsak int numbere 1 yerleşir ve onu kullanmadığımız için hiç bi yerde sonuç 20 olur.
        {
            return numbers.Sum();
        }

        // -DİZİLER

        // hem bölge hem şehirleri tutucaz
        string[,] regions = new string[5, 3]
        {
            {"istanbul","izmit","balıkesir"},
            {"ankara","konya","kırıkkale"},
            {"antalya","adana","mersin"},
            {"rize","trabzon","samsun"},
            {"izmir","muğla","manisa"},
 
        };

        for (int i = 0; i<= regions.GetUpperBound(0); i++) // satırlar 0. dimension sütünlar 1. dimension gibi yani 0. dimensionun en üst değeri anlamına geliyor
			{
            for(int j=0; j <= regions.GetUpperBound(1) ; j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }
        }
    }
}
