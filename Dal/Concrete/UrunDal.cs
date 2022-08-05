using Core.Concrete;
using Dal.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Concrete
{
    public class UrunDal : GenericRepository<Urunler>,IUrunDal
    {
        public UrunDal(string tabloadi = "Urunler") : base(tabloadi)
        {

        }
    }
}
