using IsTakip.Core.Entites;
using IsTakip.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IsTakip.WebUI.Controllers
{
    public class KullaniciController : Controller
	{
		private readonly DataContext _context;
		private readonly ILogger<KullaniciController> _logger;
		public KullaniciController(DataContext context,ILogger <KullaniciController>logger)
		{
			_context = context;
			_logger = logger;
		}

		// GET: KullaniciController
		public ActionResult Index()
		{
			var model = _context.Kullanici.ToList();
			return View(model);
		}

		// GET: KullaniciController/Details/5
		public ActionResult Details(int id)
		{
			var model = _context.Kullanici.Find(id);
			return View(model);
		}

		// GET: KullaniciController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: KullaniciController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Kullanici kullanici)
		{

            if (kullanici is null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (ModelState.IsValid)
            {
                _context.Kullanici.Add(kullanici);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            ViewData["Mesaj"] = "Kaydetme İşlemi Başarılı";

            var options = new JsonSerializerOptions { WriteIndented = true };
            var serializedData = JsonSerializer.Serialize<Kullanici>(kullanici, options);
            _logger.LogInformation(serializedData);
            var data = _context.GetById(kullanici.Id);

			
            return View(kullanici);

		}

		// GET: KullaniciController/Edit/5
		public ActionResult Edit(int id)
		{
			var model = _context.Kullanici.Find(id);
			return View(model);

		}

		// POST: KullaniciController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]

		public ActionResult Edit(int id, Kullanici kullanici)
		{
			if (kullanici == null)
			{
				return RedirectToAction(nameof(Index));

			}			
		
			if (ModelState.IsValid)
			{
				try
				{
					kullanici.Ad = kullanici.Ad.ToUpper();
					kullanici.Soyad = kullanici.Soyad.ToUpper();
                    kullanici.RoleTanim = kullanici.RoleTanim;


                    _context.Kullanici.Update(kullanici);
					_context.SaveChanges();
					return RedirectToAction(nameof(Index));
				}
				catch
				{
					ModelState.AddModelError("", "Hata oluştu");
				}


			}

			var options = new JsonSerializerOptions { WriteIndented = true };
            var serializedData = JsonSerializer.Serialize<Kullanici>(kullanici, options);
            _logger.LogInformation(serializedData);

            return View(kullanici);
		}

		// GET: KullaniciController/Delete/5
		public ActionResult Delete(int id)
		{
			var model = _context.Kullanici.Find(id);
			return View(model);
		}

		// POST: KullaniciController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Kullanici kullanici)
		{
            try
            {
                _context.Kullanici.Remove(kullanici);
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
