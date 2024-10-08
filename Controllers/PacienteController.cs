using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models;
using System.Linq;

namespace Hospital.Controllers
{
    public class PacienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PacienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pacientes = _context.Pacientes.ToList();
            return View(pacientes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Pacientes.Add(paciente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paciente);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        [HttpPost]
        public IActionResult Edit(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _context.Pacientes.Update(paciente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paciente);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}