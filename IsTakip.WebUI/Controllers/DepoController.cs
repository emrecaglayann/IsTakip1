using IsTakip.Core.Entites;
using IsTakip.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IsTakip.WebUI.Controllers
{
    public class DepoController : Controller
    {
        // GET: DepoController
        private readonly DataContext _context;

        public DepoController(DataContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var model = _context.Depo.ToList();
            return View(model);
        }

        // GET: DepoController/Details/5
        public ActionResult Details(int id)
        {
            var model = _context.Depo.Find(id);
            return View(model);
        }

        // GET: DepoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Depo depo)
        {

            if (depo is null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (ModelState.IsValid)
            {
                _context.Depo.Add(depo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            ViewData["Mesaj"] = "Kaydetme İşlemi Başarılı";
            return View(depo);
        }

        // GET: DepoController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _context.Depo.Find(id);
            return View(model);

        }

        // POST: DepoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Depo depo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    depo.Tanim = depo.Tanim.ToUpper();
                    depo.Aciklama = depo.Aciklama.ToUpper();

                    _context.Depo.Update(depo);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata oluştu");
                }

            }
            return View(depo);
        }

        // GET: DepoController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _context.Depo.Find(id);
            return View(model);
        }
        // POST: DepoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Depo depo)
        {
            try
            {
                _context.Depo.Remove(depo);
                _context.SaveChanges();
                
            }
            catch
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
