using CalculoIndiceAcademico.Data;
using Microsoft.AspNetCore.Mvc;

namespace CalculoIndiceAcademico.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CourseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Models.CourseModel> objControllerList = _db.Courses;
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
        public IActionResult Create(Models.CourseModel obj)
        {
            //TODO Validacion Co requisito y Pre requisito no son iguales
            //TODO Validacion Asignatura no es igual a requisitos
            //TODO Validacion Co requisito existe en tabla Asignaturas
            //TODO Validacion Pre requisito existe en tabla Asignaturas

            IEnumerable<Models.CourseModel> objControllerList = _db.Courses;
            foreach (var objController in objControllerList)
                {
                    if (objController.CourseID == obj.CourseID)
                    {
                    ModelState.AddModelError("CourseID", $"Clave {objController.CourseID} has already been used.");
                    }
                }
            if(ModelState.IsValid)
            {
                
                
                _db.Courses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

        //GET
        public IActionResult Edit(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var courseFromDb = _db.Courses.Find(id);
            if(courseFromDb == null)
            {
                return NotFound();
            }
            return View(courseFromDb);


        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Models.CourseModel obj)
        {
            IEnumerable<Models.CourseModel> objControllerList = _db.Courses;
            Models.CourseModel temporary = obj;

            foreach (var objController in objControllerList)
            {
                if (objController.CourseID == obj.CourseID)
                {
                    temporary = objController;
                    break;
                }
                else if (objController.CourseName == obj.CourseName && objController.Credits == objController.Credits)
                {
                    temporary = objController;
                    break;
                }
                else if (objController.CourseID == obj.CourseID && objController.CourseName == objController.CourseName)
                {
                    temporary = objController;
                    break;
                }
            }
            if(temporary == obj)
            {
                //TODO: Change this to a redirect with temp message
                return NotFound();
            }
            foreach (var objController in objControllerList)
            {
                if (objController.CourseID == obj.CourseID && temporary.CourseID != obj.CourseID)
                {
                    ModelState.AddModelError("CourseID", $"Clave {objController.CourseID} has already been used.");
                }
            }
            if (ModelState.IsValid)
            {
                _db.Courses.Remove(temporary);
                _db.Courses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //GET
        public IActionResult Delete(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var courseFromDb = _db.Courses.Find(id);
            if(courseFromDb == null)
            {
                return NotFound();
            }
            return View(courseFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(Models.CourseModel obj)
        {
            if(obj == null)
            {
                return NotFound();
            }
            _db.Courses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
