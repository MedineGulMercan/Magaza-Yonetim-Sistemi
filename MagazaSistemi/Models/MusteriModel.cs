using Dal.Concrete;
using Entities.Concrete;

namespace MagazaSistemi.Models
{
    public class MusteriModel
    {
        MusteriDal musteriDal;

        public MusteriModel()
        {
            musteriDal = new MusteriDal();
        }

        public List<MusteriModel> musteriListesi = new List<MusteriModel>();
        
        public void Getir()
        {
            var musteriler = musteriDal.GetAllAsync().Result;

            foreach (var item in musteriler)
            {
                MusteriModel musteriModel = new MusteriModel()
                {
                   Id = item.Id,
                   MusteriAd=item.MusteriAd,
                   MusteriSoyad=item.MusteriSoyad,
                   Aktifmi = item.Aktifmi
                };
                musteriListesi.Add(musteriModel);
            }
        }
        public void GuncelleGetir(int id)
        {        
            var musterii = musteriDal.GetAsync(id).Result;
            Id = musterii.Id;
            MusteriAd = musterii.MusteriAd;
            MusteriSoyad = musterii.MusteriSoyad;
            Aktifmi =musterii.Aktifmi;
        }

        public int Id { get; set; }
        public string? MusteriAd { get; set; }
        public string? MusteriSoyad { get; set; }
        public bool Aktifmi { get; set; }
    }
}
