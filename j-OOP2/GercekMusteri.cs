using System;
using System.Collections.Generic;
using System.Text;

namespace j_OOP2
{
    // Individuals - Gerçek müşteri
    class GercekMusteri : Musteri // Buraya Musteri yazarak GercekMusteriye, arkadaş sen bir müşterisin diyoruz. Bu olaya da INHERITANCE (Miras) diyoruz. Müşteride olan özellikler artık GercekMusteri de de vardır demektir. Musteri burada GercekMusterinin ebeveynidir. Musteri de olan herşey GercekMusteri de de kabul edilir.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
