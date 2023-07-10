using CalculoIndiceAcademico.Data;
using Microsoft.AspNetCore.Mvc;

namespace CalculoIndiceAcademico.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserController(ApplicationDbContext db)
        {
            _db = db;
        }


        //GET
        public IActionResult Register()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Models.APUser obj)
        {
            var user = new Models.ApplicationUserModel();
            user.AddressLine = obj.AddressLine;
            user.Gender = obj.Gender;
            user.Identification = obj.Identification;
            user.AcademicArea = obj.AcademicArea;
            user.UserID = obj.UserID;
            user.BirthDate = obj.BirthDate;
            user.EMail = obj.EMail;
            user.age = obj.age;
            user.GPA = null;
            user.Image = null;
            user.NumTrimesters = null;
            
            var name = new Models.NamesModel();
            name.Name = obj.Name;
            name.LastName = obj.LastName;
            name.UserID = obj.UserID;

            var role = new Models.RolModel();
            role.UserID = obj.UserID;
            role.Role = obj.Role;
            _db.Peoples.Add(obj);
            _db.SaveChanges();
            _db.Names.Add(name);
            _db.SaveChanges();
            _db.Rol.Add(role);
            _db.SaveChanges();
            return RedirectToAction("Index","Home");

        }

    }
}
