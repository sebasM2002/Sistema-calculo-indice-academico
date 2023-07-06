using CalculoIndiceAcademico.Data;
using Microsoft.AspNetCore.Mvc;

namespace CalculoIndiceAcademico.Controllers
{
    public class CareerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CareerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Models.CareerModel> objControllerList = _db.Careers;
            return View(objControllerList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Models.CareerModel obj)
        {
            IEnumerable<Models.CareerModel> objControllerList = _db.Careers;
            foreach (var objController in objControllerList)
            {
                if (objController.ID_Career == obj.ID_Career)
                {
                    ModelState.AddModelError("ID_Career", $"Clave {objController.ID_Career} has already been used.");
                }
            }
            if (ModelState.IsValid)
            {
                _db.Careers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET
        public IActionResult Edit(string id)
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Models.CareerModel obj)
        {
         
            if (ModelState.IsValid)
            {
                _db.Careers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


    }
}
