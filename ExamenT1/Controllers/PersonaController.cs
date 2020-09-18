using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenT1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamenT1.Controllers
{
    public class PersonaController : Controller
    {
        private PersonaContext _context;
        public PersonaController(PersonaContext context)
        {
            _context = context;
        }
        public ViewResult Index()
        {
            ViewBag.personas = _context.personas.ToList();
            return View("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("Create", new Personas());
        }
        [HttpPost]
        public ActionResult Create(Personas personas)
        {
            if (ModelState.IsValid)
            {
                _context.personas.Add(personas);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", personas);
        }
        public ActionResult Edit(int id)
        {
            ViewBag.genero = new List<string> { "Hombre", "Mujer" };
            ViewBag.ciudad = new List<string> { "Guadalupe", "Pacasmayo","Chepen","Trujillo" };
            ViewBag.persona = _context.personas.Where(o => o.Id_persona == id).FirstOrDefault();
            return View("Edit");
        }
        [HttpPost]
        public ActionResult Edit(Personas personas)
        {
            if (ModelState.IsValid)
            {
                _context.personas.Update(personas);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit");
        }
        public ActionResult delate(int id)
        {
            var personas = _context.personas.Where(o => o.Id_persona == id).FirstOrDefault();
            _context.personas.Remove(personas);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}
