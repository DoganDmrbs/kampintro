using System;

namespace Genericsintro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();  // <string> verdik ama int de başka bişeyde verebiliriz belirtmemiz lazım. yani arka plandaki T yi string yaprık.
            //bunu newledigimiz an constructer çalışır. 
            isimler.Add("Doğan");

            Console.WriteLine("Hello World!");
        }
    }
}
wewfwefewf