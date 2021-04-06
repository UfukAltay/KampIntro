using System;
using System.Collections.Generic;
using System.Text;

namespace j_OOP2
{
    // Coorporat - Tuzel
    class TuzelMusteri : Musteri // Buraya Musteri yazarak TuzelMusteriye, arkadaş sen bir müşterisin diyoruz. Bu olaya da INHERITANCE (Miras) diyoruz. Müşteride olan özellikler artık TuzelMusteri de de vardır demektir. Musteri burada TuzelMusterinin ebeveynidir. Musteri de olan herşey TuzelMusteri de de kabul edilir.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
