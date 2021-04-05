using System;
using System.Collections.Generic;
using System.Text;

namespace h_GenericsIntro
{
    class MyList<T> // Buraya T yazmamızın sebebi, ileride bu genericle ilgili tanımlama yaparken hangi türü belirlersek o türde generic oluşması içindir. Yani T yerine string yazmış olsaydık, tanımlama yaparken sadece string türünde tanımlama yapabilecektik. Ancak T yazdığımızda, kullanıcı tür tanımlarken o anda T için hangi türü belirlerse generic o türde olacak
    {
        T[] items;
        // ctor = constructor -> New lediğimiz anda çalışan bloğa Constructor denir. Constructor class ismi ile aynıdır.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) // Burada item yerine istediğimiz bir ismi de verebiliriz ancak genelde item kullanılır.
        {
            T[] tempArray = items; //Dizinin referansını geçici olarak bir yerde tutuyoruz ki bir alt satırda dizinin eleman sayısını bir artırdığımızda new leyince referans değişmesin ve veriler kaybolmasın.
            items = new T[items.Length + 1]; // Dizinin eleman sayısını bir artırdık.
            for (int i = 0; i < tempArray.Length; i++) //Burada da for ile geçici dizide (tempArray) tutulan veriyi items dizisine ekledik ve verilerimiz kaybolmamış oldu. 
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // Burada da Add ile ekleyeceğimiz item i dizinin son elemanı olarak eklemiş olacağız. Dizi indeksi sıfırdan başladığı için son elemana eklemek adına -1 yapıyoruz.
        }
    }
}
