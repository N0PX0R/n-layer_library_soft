using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarysoft
{
   public class uyeler
    {
        public Guid uyeID { get; set; }
        public string uyeAd { get; set; }
        public string uyeSoyad { get; set; }
        public string uyeTel { get; set; }
        public string uyeAdres { get; set; }
        public override string ToString()
        {
            return $"{uyeAd} {uyeSoyad}";
        }
    }

    public class kitaplar
    {
        public Guid kitapID { get; set; }
        public string kitapAd { get; set; }
        public string kitapTur { get; set; }
        public string kitapBasim { get; set; }
        public string kitapYayin { get; set; }
        public int kitapSayfa { get; set; }
    }

    public class odunc
    {
        public Guid oduncID { get; set; }
        public Guid uyeID { get; set; }
        public Guid kitapID { get; set; }
        public DateTime aldigiTarih { get; set; }
        public DateTime verdigiTarih { get; set; }

    }
}
