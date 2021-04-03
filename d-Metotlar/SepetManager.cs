using System;
using System.Collections.Generic;
using System.Text;

namespace d_Metotlar
{
    class SepetManager // Bir classın sonunda manager ibaresini görürseniz bu class bir opersyon yönetiyor demektir.
    {
        // Naming convention = İsimlendirme kuralı
        public void Ekle(Urun urun) // Bir yerde normal bir parantez görürseniz bir metot kullanıyorsunuz demektir.
        {
            Console.WriteLine("Tebrikler, " + urun.Adi + " sepete eklendi.");
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, " + urunAdi + " sepete eklendi.");
        }
    }
}
