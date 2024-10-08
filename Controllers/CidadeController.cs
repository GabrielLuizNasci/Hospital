using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models;
using System.Linq;

namespace Hospital.Controllers
{
    public class CidadeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CidadeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cidades = _context.Cidades.ToList();
            return View(cidades);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _context.Cidades.Add(cidade);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cidade);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cidade = _context.Cidades.Find(id);
            if (cidade == null)
            {
                return NotFound();
            }
            return View(cidade);
        }

        [HttpPost]
        public IActionResult Edit(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _context.Cidades.Update(cidade);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cidade);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var cidade = _context.Cidades.Find(id);
            if (cidade == null)
            {
                return NotFound();
            }
            return View(cidade);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var cidade = _context.Cidades.Find(id);
            if (cidade != null)
            {
                _context.Cidades.Remove(cidade);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
