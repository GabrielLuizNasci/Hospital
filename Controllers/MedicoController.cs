using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models;
using System.Linq;

namespace Hospital.Controllers
{
    public class MedicoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var medicos = _context.Medicos.ToList();
            return View(medicos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                _context.Medicos.Add(medico);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var medico = _context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        [HttpPost]
        public IActionResult Edit(Medico medico)
        {
            if (ModelState.IsValid)
            {
                _context.Medicos.Update(medico);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var medico = _context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var medico = _context.Medicos.Find(id);
            if (medico != null)
            {
                _context.Medicos.Remove(medico);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}