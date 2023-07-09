using CalculoIndiceAcademico.Data;
using Microsoft.AspNetCore.Mvc;

namespace CalculoIndiceAcademico.Controllers
{
    public class InqueriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public InqueriesController(ApplicationDbContext db)
        {
            _db = db;
        }


        //GET
        public IActionResult Index()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Models.InqueriesModel obj)
        {
            if(ModelState.IsValid)
            {
                _db.Inqueries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

    }
}
