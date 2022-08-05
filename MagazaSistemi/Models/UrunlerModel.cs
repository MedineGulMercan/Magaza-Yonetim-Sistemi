using Dal.Concrete;

namespace MagazaSistemi.Models
{


    public class UrunlerModel
    {

        UrunDal urunlerDal;
        public UrunlerModel()
        {
            urunlerDal = new UrunDal();
        }
        public List<UrunlerModel> urunModelList = new List<UrunlerModel>();
        public void Getir()
        {
            var urunList = urunlerDal.GetAllAsync().Result.Where(x => x.Aktifmi != false);
            foreach (var item in urunList)
            {
                UrunlerModel urunlerModel = new UrunlerModel()
                {
                    Id = item.Id,
                    UrunAd = item.UrunAd,
                    UrunFiyat = Math.Round(item.UrunFiyat, 2),
                    Aktifmi = item.Aktifmi
                };
                urunModelList.Add(urunlerModel);
            }
        }

        public void GuncelleGetir(int id)
        {
            var Urunx = urunlerDal.GetAsync(id).Result;
            Id = Urunx.Id;
            UrunAd = Urunx.UrunAd;
            UrunFiyat = Math.Round(Urunx.UrunFiyat, 2);
            Aktifmi = Urunx.Aktifmi;
        }
        public int Id { get; set; }
        public decimal UrunFiyat { get; set; }
        public string? UrunAd { get; set; }
        public bool Aktifmi { get; set; }
    }
}
