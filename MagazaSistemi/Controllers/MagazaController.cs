using Dal.Concrete;
using Entities.Concrete;
using MagazaSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagazaSistemi.Controllers
{


    public class MagazaController : Controller
    {
        MagazaModel magazaModel;
        MagazaDal magazaDal;
        public MagazaController()
        {
            magazaModel = new MagazaModel();
            magazaDal = new MagazaDal();
        }



        public IActionResult Index()
        {
            magazaModel.Getir();
            

            return View(magazaModel.magazaModelList.Where(x=>x.Aktifmi != false).ToList());
        }

        [HttpGet]
        public IActionResult MagazaEkle()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MagazaEkle(MagazaModel magazaModel)
        {
            Magaza magaza = new()
            {
                MagazaAd = magazaModel.MagazaAd


            };

            await magazaDal.CreateAsync(magaza);
            return RedirectToAction("Index");

        }



        [HttpGet]
        public IActionResult MagazaGuncelle(int Id)
        {
            magazaModel.GuncelleGetir(Id);

            return View(magazaModel);

        }

        [HttpPost]
        public async Task<IActionResult> MagazaGuncelle(MagazaModel magazaModel)
        {
            Magaza magaza = new()
            {
                Id = magazaModel.Id,
               MagazaAd = magazaModel.MagazaAd

            };

            await magazaDal.UpdateAsync(magaza);

            return RedirectToAction("Index");

        }

        [HttpPost]

        public async Task<IActionResult> MagazaSil(int Id)
        {
            await magazaDal.DeleteAsync(Id);
            return RedirectToAction("Index");
        }

    }
}
