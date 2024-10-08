using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models;
using System.Linq;

namespace Hospital.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConsultaController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var consultas = _context.Consultas.ToList();
            return View(consultas);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Consultas.Add(consulta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consulta);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var consulta = _context.Consultas.Find(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }


        [HttpPost]
        public IActionResult Edit(Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Consultas.Update(consulta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consulta);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var consulta = _context.Consultas.Find(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var consulta = _context.Consultas.Find(id);
            if (consulta != null)
            {
                _context.Consultas.Remove(consulta);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
