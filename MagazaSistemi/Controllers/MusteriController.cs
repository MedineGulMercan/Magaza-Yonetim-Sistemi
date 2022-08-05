using Dal.Concrete;
using Entities.Concrete;
using MagazaSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagazaSistemi.Controllers
{
    public class MusteriController : Controller
    {
        MusteriModel musteriModel;
        MusteriDal musteriDal;
        public MusteriController()
        {
            musteriModel = new MusteriModel();
            musteriDal = new MusteriDal();
        }

        [HttpGet]
        public IActionResult Index()
        {
            musteriModel.Getir();
            return View(musteriModel.musteriListesi.Where(x=>x.Aktifmi != false).ToList());
        }

        [HttpGet]
        public IActionResult MusteriEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MusteriEkle(MusteriModel musteriModel)
        {
            Musteri musteri = new()
            {
                MusteriAd = musteriModel.MusteriAd,
                MusteriSoyad = musteriModel.MusteriSoyad
            };

            await musteriDal.CreateAsync(musteri);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MusteriGuncelle(int Id)
        {

            musteriModel.GuncelleGetir(Id);
            return View(musteriModel);
        }
        [HttpPost]
        public async Task<IActionResult> MusteriGuncelle(MusteriModel musteriModel)
        {
            Musteri musteri = new()
            {
                Id = musteriModel.Id, 
                MusteriAd = musteriModel.MusteriAd,
                MusteriSoyad = musteriModel.MusteriSoyad
            };
            await musteriDal.UpdateAsync(musteri);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> MusteriSil(int Id)
        {
            await musteriDal.DeleteAsync(Id);

            return RedirectToAction("Index");
        }


    }
}
