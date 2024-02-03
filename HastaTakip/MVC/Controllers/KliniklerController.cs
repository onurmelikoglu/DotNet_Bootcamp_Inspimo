#nullable disable
using Business.Models;
using Business.Services;
using DataAccess.Results.Bases;
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
            // 1.yöntem
            // List<KlinikModel> klinikList = klinikService.Query().ToList();
            // 2. yöntem
            List<KlinikModel> klinikList = klinikService.GetList();

            return View(klinikList);
        }

        // GET: Klinikler/GetJson

        public JsonResult GetItemJson(int id)
        {
            // var klinikler = klinikService.Query().ToList();
            var klinikler = klinikService.Query().SingleOrDefault(k => k.Id == id);
            return Json(klinikler);
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

            // 1. yöntem: 
            // koşula göre bulduğu tek kaydı döner, eğer kaydı bulamazsa null döner, birden çok kayıt varsa exception fırlatır
            // KlinikModel klinik = klinikService.Query().SingleOrDefault(k => k.Id == id); // TODO: Add get item service logic here

            // 2. yöntem:
            KlinikModel klinik = klinikService.GetItem(id);

            
            if (klinik == null)
            {
                return NotFound(); // 404 (Not Found) HTTP Status Code
            }
            return View(klinik); // 200 (OK) HTTP Status Code
        }

        // GET: Klinikler/Create
        // [HttpGet] // default: GET
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
                Result result = klinikService.Add(klinik);
                if (result.IsSuccessful)
                {
                    TempData["Mesaj"] = result.Message;
                    // 1. yöntem
                    // return RedirectToAction("Index");
                    // 2. yöntem 
                    // return RedirectToAction(nameof(Index));
                    // 3. yöntem
                    return RedirectToAction(nameof(Details), new { id = klinik.Id });
                }

                // 1. yöntem
                // ViewData["Mesaj"] = result.Message;
                // 2. yöntem
                // ViewBag.Mesaj = result.Message;
                // 3. yöntem 
                ModelState.AddModelError("", result.Message); // Validation summary


			}
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(klinik);
        }

        // GET: Klinikler/Edit/5
        public IActionResult Edit(int id)
        {
            KlinikModel klinik = klinikService.Query().SingleOrDefault(k => k.Id == id); // TODO: Add get item service logic here
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
                Result result = klinikService.Update(klinik);
                if (result.IsSuccessful)
                {
                    TempData["Mesaj"] = result.Message;
                    return RedirectToAction(nameof(Details), new { id = klinik.Id });
                }
                ModelState.AddModelError("",result.Message); // view -> validation summary


            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(klinik);
        }

        // GET: Klinikler/Delete/5
        public IActionResult Delete(int id)
        {
            KlinikModel klinik = klinikService.GetItem(id); // TODO: Add get item service logic here
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
            Result result = klinikService.Delete(id);
            TempData["Mesaj"] = result.Message;
            return RedirectToAction(nameof(Index));
        }
	}
}
