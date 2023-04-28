using IsTakip.Core.Entites;
using IsTakip.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.WebAPI.Controllers
{

    [ApiController]
    [Route("Api/[controller]")]
    public class KullaniciController : ControllerBase
    {
        private readonly DataContext _context;

        public KullaniciController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Kullanici>>> Get()
        {
            var data = await _context.Kullanici.ToListAsync();
            return Ok(data);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Kullanici>> GetById(int id)
        {
            var data = await _context.Kullanici.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }



        // GET: KullaniciController/Create

        [HttpPost]
        public async Task<ActionResult> AddKullanici(Kullanici kullanici)
        {
            _context.Kullanici.Add(kullanici);
            await _context.SaveChangesAsync();

            return Ok("Başarılı");
        }

        [HttpPut]
        public async Task<ActionResult<Kullanici>> Edit(Kullanici kullanici)
        {
            var data = await _context.Kullanici.FindAsync(kullanici.Id);
            if (data == null)
            {
                return NotFound();
            }
            data.Ad = kullanici.Ad;
            data.Soyad = kullanici.Soyad;
            data.KullaniciKodu = kullanici.KullaniciKodu;
            data.KullaniciSifre = kullanici.KullaniciSifre;
            data.RoleTanim = kullanici.RoleTanim;
            data.MailBildirim = kullanici.MailBildirim;
            data.MusteriId = kullanici.MusteriId;

            _context.Update(data);
            await _context.SaveChangesAsync();

            return Ok(data);
        }


        [HttpDelete]
        public async Task<ActionResult<List<Kullanici>>> Delete(int id)
        {
            var deleted = await _context.Kullanici.FindAsync(id);
            if (deleted == null)
                return BadRequest();

            _context.Remove(deleted);
            await _context.SaveChangesAsync();


            return Ok(await _context.Kullanici.ToListAsync());
        }
    }
}
