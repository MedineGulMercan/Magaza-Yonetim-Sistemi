using Dal.Concrete;

namespace MagazaSistemi.Models
{
    public class MagazaModel 
    {
        MagazaDal magazaDal;
        public MagazaModel() 
        {
            magazaDal = new MagazaDal();
        }
        public List<MagazaModel> magazaModelList = new List<MagazaModel>();
        public  void Getir()
        {
            var magazaList = magazaDal.GetAllAsync().Result;
            foreach (var item in magazaList)
            {
                MagazaModel magazaModel = new MagazaModel()
                {
                    Id = item.Id,
                    MagazaAd = item.MagazaAd,
                    Aktifmi = item.Aktifmi
                };
                magazaModelList.Add(magazaModel);
            }
        }

        public void GuncelleGetir(int id)
        {
            var musterix = magazaDal.GetAsync(id).Result;
            Id = musterix.Id;
            MagazaAd = musterix.MagazaAd;
            Aktifmi = musterix.Aktifmi;
            

        }


        public int Id { get; set; }
        public string? MagazaAd { get; set; }
        public bool Aktifmi { get; set; }
    }
}
