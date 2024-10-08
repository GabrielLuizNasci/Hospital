using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models;
using System.Linq;

namespace Hospital.Controllers
{
    public class MedicamentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicamentoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var medicamentos = _context.Medicamentos.ToList();
            return View(medicamentos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medicamento medicamento)
        {
            if (ModelState.IsValid)
            {
                _context.Medicamentos.Add(medicamento);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicamento);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var medicamento = _context.Medicamentos.Find(id);
            if (medicamento == null)
            {
                return NotFound();
            }
            return View(medicamento);
        }

        [HttpPost]
        public IActionResult Edit(Medicamento medicamento)
        {
            if (ModelState.IsValid)
            {
                _context.Medicamentos.Update(medicamento);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medicamento);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var medicamento = _context.Medicamentos.Find(id);
            if (medicamento == null)
            {
                return NotFound();
            }
            return View(medicamento);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var medicamento = _context.Medicamentos.Find(id);
            if (medicamento != null)
            {
                _context.Medicamentos.Remove(medicamento);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
