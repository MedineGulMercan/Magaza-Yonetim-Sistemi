using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Magaza : BaseEntity
    {
        public string? MagazaAd { get; set; }
        public bool Aktifmi { get; set; }
    }
}
