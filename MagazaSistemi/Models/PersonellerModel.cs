using Dal.Concrete;

namespace MagazaSistemi.Models
{
    public class PersonellerModel
    {
        PersonelDal personelDal;
        MagazaDal magazaDal;
        public PersonellerModel()
        {
            personelDal = new PersonelDal();
            magazaDal = new MagazaDal();
        }

        public List<PersonellerDto> personellerDtoList = new List<PersonellerDto>();

        public void Getir()
        {
            var personel = personelDal.GetAllAsync().Result.Where(x=>x.Aktifmi != false);
            var magaza = magazaDal.GetAllAsync().Result.Where(x=>x.Aktifmi!= false);
            foreach (var item in personel)
            {
                PersonellerDto personellerDto = new PersonellerDto()
                {
                    Id = item.Id,
                    PersonelAd=item.PersonelAd,
                    PersonelSoyad=item.PersonelSoyad,
                    MagazaId=item.MagazaId,
                    MagazaAd = magaza.FirstOrDefault(x=> x.Id==item.MagazaId).MagazaAd
                };
                personellerDtoList.Add(personellerDto);
            }
        }
        public List<MagazaModel> magazaModelList = new List<MagazaModel>();
        public void GetirMagaza()
        {
            var magazaList = magazaDal.GetAllAsync().Result.Where(x=>x.Aktifmi!=false);
            foreach (var item in magazaList)
            {
                MagazaModel magazaModel = new MagazaModel()
                {
                    Id = item.Id,
                    MagazaAd = item.MagazaAd
                };
                magazaModelList.Add(magazaModel);
            }
        }

        public void GuncelleGetir(int id)
        {
            var personel = personelDal.GetAsync(id).Result;
            Id = personel.Id;
            PersonelAd = personel.PersonelAd;
            PersonelSoyad = personel.PersonelSoyad;
            MagazaId = personel.MagazaId;
        }

        public int Id { get; set; }
        public string? PersonelAd { get; set; }
        public string? PersonelSoyad { get; set; }
        public int MagazaId { get; set; }
        public bool Aktifmi { get; set; }
    }
}
