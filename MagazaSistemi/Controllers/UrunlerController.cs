using Dal.Concrete;
using Entities.Concrete;
using MagazaSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagazaSistemi.Controllers
{
    public class UrunlerController : Controller
    {
        UrunlerModel urunlerModel;
        UrunDal urundal;
        public UrunlerController()
        {
            urunlerModel = new UrunlerModel();
            urundal = new UrunDal();

            }
        public IActionResult Index()
        {
            urunlerModel.Getir();
            return View(urunlerModel.urunModelList);
        }

        [HttpGet]
        public IActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>UrunEkle(UrunlerModel urunlerModel)
        {
            Urunler urunler = new()
            {
                UrunAd = urunlerModel.UrunAd,
                UrunFiyat = urunlerModel.UrunFiyat,
                Aktifmi = urunlerModel.Aktifmi
            };
            await urundal.CreateAsync(urunler);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UrunGuncelle(int Id)
        {
            urunlerModel.GuncelleGetir(Id);

            return View(urunlerModel);
        }

        [HttpPost]
        public async Task<IActionResult> UrunGuncelle(UrunlerModel urunlerModel)
        {
            Urunler urunler = new()
            { 
                UrunAd = urunlerModel.UrunAd,
                UrunFiyat= urunlerModel.UrunFiyat,
                Id = urunlerModel.Id,
                Aktifmi = urunlerModel.Aktifmi
            };

            await urundal.UpdateAsync(urunler);

            return RedirectToAction("Index");
        }
        [HttpPost]

        public async Task<IActionResult> UrunSil(int Id)
        {
            await urundal.DeleteAsync(Id);
            return RedirectToAction("Index");
        }
    }
}
