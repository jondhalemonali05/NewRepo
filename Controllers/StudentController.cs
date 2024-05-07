using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using tuesdaycrud.Models;

namespace tuesdaycrud.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentdbContext _studentdb;

        public StudentController(StudentdbContext studentdb)
        {
            _studentdb = studentdb;
        }
        public IActionResult Index()
        {
            var stud_list = _studentdb.stud.ToList();

            return View(stud_list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                _studentdb.stud.Add(st);
                _studentdb.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();
        }
        public IActionResult Edit(int roll_no)

        {
            if (roll_no == 0)
            {
                return NotFound();
            }
            var emp = _studentdb.stud.Find(roll_no);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Student st)
        {
            if (ModelState.IsValid)
            {
                _studentdb.Update(st);
                _studentdb.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }
        
        [HttpPost]
        public IActionResult Delete(int roll_no)
        {
            if (ModelState.IsValid)
            {
                _studentdb.Remove(roll_no);
                _studentdb.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }
    }
}