using Dal.Concrete;
using Entities.Concrete;
using MagazaSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagazaSistemi.Controllers
{
    public class SatisController : Controller
    {
        SatisModel satisModel;
        SatisDal satisDal;
        PersonelDal personelDal;
        public SatisController()
        {
            satisModel = new SatisModel();
            satisDal = new SatisDal();
            personelDal = new PersonelDal();
        }

        public IActionResult Index()
        {
            satisModel.GetirSatis();
            
            return View(satisModel.satisModelList);
        }

        [HttpGet]
        public IActionResult SatisEkle()
        {
            satisModel.GetirMusteri();
            satisModel.GetirPersonel();
            satisModel.GetirUrunler();
            return View(satisModel);
        }

        [HttpPost]
        public async Task<IActionResult> SatisEkle(SatisModel satismodel1)
        {
            Satis satis = new()
            {
                PersonelId = satismodel1.PersonelId,
                UrunId = satismodel1.UrunId,
                MusteriId = satismodel1.MusteriId

            };
            await satisDal.CreateAsync(satis);
            return RedirectToAction("Index");

        }
       
    }
}
