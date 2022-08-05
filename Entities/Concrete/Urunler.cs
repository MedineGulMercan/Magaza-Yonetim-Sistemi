using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Urunler : BaseEntity
    {
        public decimal UrunFiyat { get; set; }
        public string? UrunAd { get; set; }
        public bool Aktifmi { get; set; }
    }
}
