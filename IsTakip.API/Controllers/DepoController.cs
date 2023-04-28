using IsTakip.Core.Entites;
using IsTakip.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IsTakip.WebAPI.Controllers
{
   
    [ApiController]
    [Route("Api/[controller]")]
    public class DepoController : ControllerBase
    {
        private readonly DataContext _context;

        public DepoController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Depo>>> Get()
        {
            var data = await _context.Depo.ToListAsync();
            return Ok(data);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Depo>> GetById(int id)
        {
            var data = await _context.Depo.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }



        // GET: DepoController/Create

        [HttpPost]
        public async Task<ActionResult> AddDepo(Depo depo)
        {
            _context.Depo.Add(depo);
            await _context.SaveChangesAsync();

            return Ok("Başarılı");
        }

        [HttpPut]
        public async Task<ActionResult<Depo>> Edit(Depo depo)
        {
            var data = await _context.Depo.FindAsync(depo.Id);
            if (data == null)
            {
                return NotFound();
            }
            data.Tanim = depo.Tanim;
            data.Aciklama = depo.Aciklama;
            data.Yetkili = depo.Yetkili;
            data.YetkiliTelefon = depo.YetkiliTelefon;

            _context.Update(data);
            await _context.SaveChangesAsync();

            return Ok(data);
        }


        [HttpDelete]
        public async Task<ActionResult<List<Depo>>> Delete(int id)
        {
            var deleted = await _context.Depo.FindAsync(id);
            if (deleted == null)
                return BadRequest();

            _context.Remove(deleted);
            await _context.SaveChangesAsync();


            return Ok(await _context.Depo.ToListAsync());
        }
    }
}
