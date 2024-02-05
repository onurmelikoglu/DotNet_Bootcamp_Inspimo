﻿#nullable disable
using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

//Generated from Custom Template.
namespace MVC.Controllers
{
    public class DoktorlarController : Controller
    {
        // TODO: Add service injections here
        private readonly IDoktorService _doktorService;
        private readonly IBransService _bransService;
        private readonly IKlinikService _klinikService;
        private readonly IHastaService _hastaService;

        public DoktorlarController(IDoktorService doktorService, IBransService bransService, IKlinikService klinikService, IHastaService hastaService)
        {
            _doktorService = doktorService;
            _bransService = bransService;
            _klinikService = klinikService;
            _hastaService = hastaService;
        }

        // GET: Doktorlar
        public IActionResult Index()
        {
            List<DoktorModel> doktorList = _doktorService.Query().ToList(); // TODO: Add get collection service logic here
            return View(doktorList);
        }

        // GET: Doktorlar/Details/5
        public IActionResult Details(int id)
        {
            DoktorModel doktor = _doktorService.Query().SingleOrDefault(d => d.Id == id); // TODO: Add get item service logic here
            if (doktor == null)
            {
                //return NotFound();
                return View("_Error", "Doktor bulunamadı!");
            }
            return View(doktor);
        }

        // GET: Doktorlar/Create
        public IActionResult Create()
        {
            // TODO: Add get related items service logic here to set ViewData if necessary
            ViewData["BransId"] = new SelectList(_bransService.Query().ToList(), "Id", "Adi");
            ViewData["KlinikId"] = new SelectList(_klinikService.GetList(), "Id", "Adi");

            ViewBag.Hastalar = new MultiSelectList(_hastaService.Query().ToList(), "Id", "AdiSoyadiOutput");

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
                var result = _doktorService.Add(doktor);
                if (result.IsSuccessful)
                    return RedirectToAction(nameof(Details), new { id = doktor.Id });
                ModelState.AddModelError("", result.Message);
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            ViewData["BransId"] = new SelectList(_bransService.Query().ToList(), "Id", "Adi");
            ViewData["KlinikId"] = new SelectList(_klinikService.GetList(), "Id", "Adi");
            ViewBag.Hastalar = new MultiSelectList(_hastaService.Query().ToList(), "Id", "AdiSoyadiOutput");
            return View(doktor);
        }

        // GET: Doktorlar/Edit/5
        public IActionResult Edit(int id)
        {
            DoktorModel doktor = _doktorService.Query().SingleOrDefault(d => d.Id == id); // TODO: Add get item service logic here
            if (doktor == null)
            {
                //return NotFound();
                return View("_Error", "Doktor bulunamadı!");
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            ViewData["BransId"] = new SelectList(_bransService.Query().ToList(), "Id", "Adi");
            ViewData["KlinikId"] = new SelectList(_klinikService.GetList(), "Id", "Adi");
            ViewBag.Hastalar = new MultiSelectList(_hastaService.Query().ToList(), "Id", "AdiSoyadiOutput");
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
                var result = _doktorService.Update(doktor);
                if (result.IsSuccessful)
                    return RedirectToAction(nameof(Details), new { id = doktor.Id });
                ModelState.AddModelError("", result.Message);
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            ViewData["BransId"] = new SelectList(_bransService.Query().ToList(), "Id", "Adi");
            ViewData["KlinikId"] = new SelectList(_klinikService.GetList(), "Id", "Adi");
            ViewBag.Hastalar = new MultiSelectList(_hastaService.Query().ToList(), "Id", "AdiSoyadiOutput");
            return View(doktor);
        }

        // GET: Doktorlar/Delete/5
        public IActionResult Delete(int id)
        {
            DoktorModel doktor = _doktorService.Query().SingleOrDefault(d => d.Id == id); // TODO: Add get item service logic here
            if (doktor == null)
            {
                //return NotFound();
                return View("_Error", "Doktor bulunamadı!");
            }
            return View(doktor);
        }

        // POST: Doktorlar/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // TODO: Add delete service logic here
            var result = _doktorService.Delete(id);
            TempData["Mesaj"] = result.Message;
            return RedirectToAction(nameof(Index));
        }
    }
}