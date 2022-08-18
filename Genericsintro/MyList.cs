using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsintro
{
    class MyList<T> // ben MyList imte T ile çalışıcam demek, yani kullanıcı new leredn T ye ne derse o ile çalışıcak demek.
    {
        //clası new lediğimizde oluşturmamız laızm. yoksa referans hatası alırız.
        T[] items; // metodun dışında yazdık clasın içinde . add yada başka metotdanda ulaşabilmek için.
      
        // constructor deniyor = bir class new lendiğinde çalışan bloğa deniyor. Alttaki. ctor tab tab
        // constructor oldugunu aynı isim olmasından anlarız.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) // T yerine string diyebilirdik ancak T dedik ve kullanıcı ne verirse int string vb onu kullan demek.
        {
            //ekliyor tamam ama hafızada nasıl tutucaz onu görücez
            // arkasında bir array tutsam ve yönetsem
            // temparray = geçiçiarray
            T[] tempArray = items;
            items = new T[items.Length+1]; // dizinin eleman sayısını arttırıyor.
            // newldiğimiz için her seferinde referans numaraları silincek o yüzden referans numarasını tutturmamız lazım.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            // for sonraki boş kısmı atmamız lazım
            items[items.Length - 1] = item;
        }
    } 
}
