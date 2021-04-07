using System;
using System.Collections.Generic;
using System.Text;

namespace k_OOP3
{
    interface IKrediManager // Interface ler I harfi ile başlar bu sayede bunun interface olduğunu anlarız. Interface kurallar içerir ve onu kullananlar bu kuralları kullanmak zorundadır.

    // ** (Önemli ) Interface leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. Bu örnekte kredi türlerinin hepsinde Hesaplama vardır. Ama mesela her kredinin faiz oranı farklıdır vb. 
    {
        void Hesapla();
        void BiseyYap();
    }
}
