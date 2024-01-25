﻿#nullable disable
using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

//Generated from Custom Template.
namespace MVC.Controllers
{
    public class KliniklerController : Controller
    {
        // TODO: Add service injections here
        private readonly IKlinikService klinikService;

        public KliniklerController(IKlinikService klinikService)
        {
            this.klinikService = klinikService;
        }

        // GET: Klinikler
        public IActionResult Index()
        {
            List<KlinikModel> klinikList = klinikService.Query().ToList(); // TODO: Add get collection service logic here
            return View(klinikList);
        }

        // GET: Klinikler/Details/5
        public IActionResult Details(int id)
        {
            // koşula göre bulduğu ilk kaydı döner, eğer kaydı bulamazsa exception fırlatır
            // KlinikModel klinik = klinikService.Query().First(k => k.Id == id);

            // koşula göre bulduğu ilk kaydı döner, eğer kaydı bulamazsa null döner
            // KlinikModel klinik = klinikService.Query().FirstOrDefault(k => k.Id == id);

            // koşula göre bulduğu son kaydı döner, eğer kaydı bulamazsa exception fırlatır
            // KlinikModel klinik = klinikService.Query().Last(k => k.Id == id);

            // koşula göre bulduğu son kaydı döner, eğer kaydı bulamazsa null döner
            // KlinikModel klinik = klinikService.Query().LastOrDefault(k => k.Id == id);

            // koşula göre bulduğu tek kaydı döner, eğer kaydı bulamazsa exception fırlatır, birden çok kayıt varsa exception fırlatır
            // KlinikModel klinik = klinikService.Query().Single(k => k.Id == id);

            // önce kayıtlar where ile filtrelenir, dönen koleksiyon sonucu üzerinden tek bir kayıt dönülür
            // KlinikModel klinik = klinikService.Query().Where(k => k.Id == id).SingleOrDefault();

            // koşula göre bulduğu tek kaydı döner, eğer kaydı bulamazsa null döner, birden çok kayıt varsa exception fırlatır
            KlinikModel klinik = klinikService.Query().SingleOrDefault(k => k.Id == id); // TODO: Add get item service logic here
            if (klinik == null)
            {
                return NotFound(); // 404 (Not Found) HTTP Status Code
            }
            return View(klinik); // 200 (OK) HTTP Status Code
        }

        // GET: Klinikler/Create
        public IActionResult Create()
        {
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View();
        }

        // POST: Klinikler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(KlinikModel klinik)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert service logic here
                return RedirectToAction(nameof(Index));
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(klinik);
        }

        // GET: Klinikler/Edit/5
        public IActionResult Edit(int id)
        {
            KlinikModel klinik = null; // TODO: Add get item service logic here
            if (klinik == null)
            {
                return NotFound();
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(klinik);
        }

        // POST: Klinikler/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(KlinikModel klinik)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add update service logic here
                return RedirectToAction(nameof(Index));
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(klinik);
        }

        // GET: Klinikler/Delete/5
        public IActionResult Delete(int id)
        {
            KlinikModel klinik = null; // TODO: Add get item service logic here
            if (klinik == null)
            {
                return NotFound();
            }
            return View(klinik);
        }

        // POST: Klinikler/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // TODO: Add delete service logic here
            return RedirectToAction(nameof(Index));
        }
	}
}
