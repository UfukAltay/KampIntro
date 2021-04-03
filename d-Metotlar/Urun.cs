using System;
using System.Collections.Generic;
using System.Text;

namespace d_Metotlar
{
    class Urun
    {
        // Aşağıdakilerin herbiri Property dir - Property = Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
