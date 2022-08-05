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
    public class MusteriDal : GenericRepository<Musteri> , IMusteriDal

    {
        public MusteriDal(string tabloadi = "Musteri") : base(tabloadi)
        {

        }
    }
}
