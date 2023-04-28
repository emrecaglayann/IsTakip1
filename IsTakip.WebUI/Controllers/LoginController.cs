using IsTakip.Core.Dtos;
using IsTakip.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace IsTakip.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _context;
        public LoginController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
       public IActionResult Index(LoginDto loginDto)
		{
			if (!ModelState.IsValid)
				return View(loginDto);

			var kullanici = _context.Kullanici.Where(t => t.KullaniciKodu == loginDto.KullaniciKodu && t.KullaniciSifre == loginDto.KullaniciSifre && t.Aktif && !t.Silindi).FirstOrDefault();

			if (kullanici is null)
			{
				ModelState.AddModelError(nameof(loginDto.KullaniciSifre), "Kullanıcı Kodu veya şifre hatalı veya kullanıcı aktif değil.");
				return View(loginDto);
			}

			//TempData["degiskenAdi"] = kullanici.Id;

			//	return RedirectToAction(nameof(Index), "Home", new { Id = kullanici.Id });
			return RedirectToAction("Index",
			new RouteValueDictionary(
				new { controller = "Home", action = "Index", Id = kullanici.Id }
			));
		}
    }
}
