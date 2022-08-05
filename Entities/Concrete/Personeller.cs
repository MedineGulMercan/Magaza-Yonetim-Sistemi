using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personeller : BaseEntity
    {
        public string? PersonelAd { get; set; }
        public string? PersonelSoyad { get; set; }
        public int MagazaId { get; set; }
        public bool Aktifmi { get; set; }
    }
}
