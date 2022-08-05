using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Musteri : BaseEntity
    {
        public string? MusteriAd { get; set; }
        public string? MusteriSoyad { get; set; }
        public bool Aktifmi { get; set; }
    }
}
