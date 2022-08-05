using Dal.Concrete;
using Entities.Concrete;
using MagazaSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagazaSistemi.Controllers
{
    public class PersonelController : Controller
    {
        PersonelDal personelDal;
        MagazaModel mModel;
        PersonellerModel personellerModel;

        public PersonelController()
        {
            mModel = new();
            personelDal = new PersonelDal();
            personellerModel = new PersonellerModel();
        }
        public IActionResult Index()
        {
            personellerModel.Getir();

            return View(personellerModel.personellerDtoList);
        }

        [HttpGet]
        public IActionResult PersonelEKle()
        {
            mModel.Getir();
            return View(mModel.magazaModelList.Where(x=>x.Aktifmi!=false).ToList());
        }

        [HttpPost]
        public async Task<IActionResult> PersonelEkle(PersonellerModel personellerModel)
        {
            Personeller personel = new()
            {
                MagazaId = personellerModel.MagazaId,
                PersonelAd = personellerModel.PersonelAd,
                PersonelSoyad  = personellerModel.PersonelSoyad
            };
            await personelDal.CreateAsync(personel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PersonelGuncelle(int Id)
        {
            personellerModel.GetirMagaza();
            personellerModel.GuncelleGetir(Id);
            return View(personellerModel);
        }

        [HttpPost]
        public async Task<IActionResult> PersonelGuncelle(PersonellerModel personellerModel)
        {
            Personeller personel = new()
            {
                Id = personellerModel.Id,
                PersonelAd = personellerModel.PersonelAd,
                PersonelSoyad = personellerModel.PersonelSoyad,
                MagazaId=personellerModel.MagazaId
                
            };
            await personelDal.UpdateAsync(personel);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> PersonelSil(int Id)
        {
            await personelDal.DeleteAsync(Id);

            return RedirectToAction("Index");
        }

    }
}
