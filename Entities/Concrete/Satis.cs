using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Satis :BaseEntity
    {
        public int MusteriId { get; set; }
        public int PersonelId { get; set; }
        public int UrunId { get; set; }
    }
}
