using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models;
using System.Linq;

namespace Hospital.Controllers
{
    public class EspecMedicController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EspecMedicController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var especMedics = _context.EspecMedics.ToList();
            return View(especMedics);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EspecMedic especMedic)
        {
            if (ModelState.IsValid)
            {
                _context.EspecMedics.Add(especMedic);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(especMedic);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var especMedic = _context.EspecMedics.Find(id);
            if (especMedic == null)
            {
                return NotFound();
            }
            return View(especMedic);
        }

        [HttpPost]
        public IActionResult Edit(EspecMedic especMedic)
        {
            if (ModelState.IsValid)
            {
                _context.EspecMedics.Update(especMedic);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(especMedic);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var especMedic = _context.EspecMedics.Find(id);
            if (especMedic == null)
            {
                return NotFound();
            }
            return View(especMedic);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var especMedic = _context.EspecMedics.Find(id);
            if (especMedic != null)
            {
                _context.EspecMedics.Remove(especMedic);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
