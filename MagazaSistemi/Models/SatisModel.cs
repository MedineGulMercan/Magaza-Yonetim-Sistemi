using Dal.Concrete;

namespace MagazaSistemi.Models
{
    public class SatisModel
    {
        PersonelDal personelDal;
        MusteriDal musteriDal;
        UrunDal urunDal;
        SatisDal satisDal;
        MagazaDal magazaDal;

        public SatisModel()
        {
            personelDal = new PersonelDal();
            musteriDal = new MusteriDal();
             urunDal = new UrunDal();
            satisDal = new SatisDal();  
            magazaDal = new MagazaDal();
        }

        public List<PersonellerModel> personellerModelList = new List<PersonellerModel>();
        
        public void GetirPersonel()
        {
            var personelList = personelDal.GetAllAsync().Result.Where(x=>x.Aktifmi!=false);
            foreach (var item in personelList)
            {
                PersonellerModel personelModel = new PersonellerModel()
                {
                    Id = item.Id,
                    PersonelAd = item.PersonelAd
                };
                personellerModelList.Add(personelModel);
            }
        }

        public List<SatisDto> satisModelList = new List<SatisDto>();

        public void GetirSatis()
        {
            var personelList = personelDal.GetAllAsync().Result;
            var urunList = urunDal.GetAllAsync().Result;
            var musteriList = musteriDal.GetAllAsync().Result;
            var satisList = satisDal.GetAllAsync().Result;
            var magazaList = magazaDal.GetAllAsync().Result;

            foreach (var item in satisList)
            {
                string belesmi = "";
                if (urunList.FirstOrDefault(x=>x.Id==item.UrunId).UrunFiyat==0)
                {
                    belesmi = "ÜCRETSİZ";
                }
                else
                {
                    belesmi = "ÜCRETLİ";
                }
                SatisDto satisDto = new SatisDto()
                {
                    Id = item.Id,
                    PersonelId = item.PersonelId,   
                    PersonelSoyad=personelList.FirstOrDefault(x=> x.Id == item.PersonelId).PersonelSoyad,
                    PersonelAd = personelList.FirstOrDefault(x=> x.Id == item.PersonelId).PersonelAd,

                    MagazaId=personelList.FirstOrDefault(y=>y.Id== item.PersonelId).MagazaId,
                    MagazaAd = magazaList.FirstOrDefault(x => x.Id == personelList.FirstOrDefault(x=>x.Id == item.PersonelId).MagazaId).MagazaAd,


                    UrunId= item.UrunId,
                    UrunAd = urunList.FirstOrDefault(x=>x.Id== item.UrunId).UrunAd, // şurada sıkıntı var
                    UrunFiyat = Math.Round( urunList.FirstOrDefault(x=>x.Id== item.UrunId).UrunFiyat,2),
                    Belesmi = belesmi,


                    MusteriId = item.MusteriId,
                    MusteriAd =musteriList.FirstOrDefault(x=> x.Id == item.MusteriId).MusteriAd,
                    MusteriSoyad =musteriList.FirstOrDefault(x=> x.Id == item.MusteriId).MusteriSoyad,
                     
                };
                satisModelList.Add(satisDto);
            }
        }

        public List<UrunlerModel> urunlerModelList = new List<UrunlerModel>();

        public void GetirUrunler()
        {
            var urunlerList = urunDal.GetAllAsync().Result.Where(x => x.Aktifmi != false);
            foreach (var item in urunlerList)
            {
                UrunlerModel urunlerModel = new UrunlerModel()
                {
                    Id = item.Id,
                    UrunAd = item.UrunAd,
                    
                };
                urunlerModelList.Add(urunlerModel);
            }
        }
        public List<MusteriModel> musteriModelList = new List<MusteriModel>();

        public void GetirMusteri()
        {
            var musteriList = musteriDal.GetAllAsync().Result.Where(x => x.Aktifmi != false);
            foreach (var item in musteriList)
            {
                MusteriModel musteriModel = new MusteriModel()
                {
                    Id = item.Id,
                    MusteriAd = item.MusteriAd,
                    
                };
                musteriModelList.Add(musteriModel);
            }
        }

        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int PersonelId { get; set; }
        public int UrunId { get; set; }
    }
}
