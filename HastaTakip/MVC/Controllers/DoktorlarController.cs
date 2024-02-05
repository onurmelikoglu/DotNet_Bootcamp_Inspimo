#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Contexts;
using DataAccess.Entities;

//Generated from Custom Template.
namespace MVC.Controllers
{
    public class DoktorlarController : Controller
    {
        // TODO: Add service injections here
        private readonly IDoktorService _doktorService;

        public DoktorlarController(IDoktorService doktorService)
        {
            _doktorService = doktorService;
        }

        // GET: Doktorlar
        public IActionResult Index()
        {
            List<DoktorModel> doktorList = new List<DoktorModel>(); // TODO: Add get collection service logic here
            return View(doktorList);
        }

        // GET: Doktorlar/Details/5
        public IActionResult Details(int id)
        {
            DoktorModel doktor = null; // TODO: Add get item service logic here
            if (doktor == null)
            {
                return NotFound();
            }
            return View(doktor);
        }

        // GET: Doktorlar/Create
        public IActionResult Create()
        {
            // TODO: Add get related items service logic here to set ViewData if necessary
            ViewData["BransId"] = new SelectList(new List<SelectListItem>(), "Value", "Text");
            ViewData["KlinikId"] = new SelectList(new List<SelectListItem>(), "Value", "Text");
            return View();
        }

        // POST: Doktorlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DoktorModel doktor)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert service logic here
                return RedirectToAction(nameof(Index));
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            ViewData["BransId"] = new SelectList(new List<SelectListItem>(), "Value", "Text");
            ViewData["KlinikId"] = new SelectList(new List<SelectListItem>(), "Value", "Text");
            return View(doktor);
        }

        // GET: Doktorlar/Edit/5
        public IActionResult Edit(int id)
        {
            DoktorModel doktor = null; // TODO: Add get item service logic here
            if (doktor == null)
            {
                return NotFound();
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            ViewData["BransId"] = new SelectList(new List<SelectListItem>(), "Value", "Text");
            ViewData["KlinikId"] = new SelectList(new List<SelectListItem>(), "Value", "Text");
            return View(doktor);
        }

        // POST: Doktorlar/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DoktorModel doktor)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add update service logic here
                return RedirectToAction(nameof(Index));
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            ViewData["BransId"] = new SelectList(new List<SelectListItem>(), "Value", "Text");
            ViewData["KlinikId"] = new SelectList(new List<SelectListItem>(), "Value", "Text");
            return View(doktor);
        }

        // GET: Doktorlar/Delete/5
        public IActionResult Delete(int id)
        {
            DoktorModel doktor = null; // TODO: Add get item service logic here
            if (doktor == null)
            {
                return NotFound();
            }
            return View(doktor);
        }

        // POST: Doktorlar/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // TODO: Add delete service logic here
            return RedirectToAction(nameof(Index));
        }
	}
}
