using System;

namespace Genericsintro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Doğan");

            Console.WriteLine("Hello World!");
        }
    }
}
