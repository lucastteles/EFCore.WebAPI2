using EFCore.Dominio;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EFCore.WebAPI3.Controllers
{
    [Route("api/values")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        public readonly HeroiContext _context;

        public ValuesController(HeroiContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet("filto/{nome}")]
        public ActionResult GetFiltro(string nome)
        {
            var listHeroi = _context.Herois
                           .Where(h => h.Name.Contains(nome))
                           .ToList();


            return Ok(listHeroi);
        }

        // GET api/values/5
        [HttpGet("Atualizar/{nameHero}")]
        public ActionResult Get(string nameHero)
        {
          

               var heroi = _context.Herois
               .Where(h=> h.Id == 1) 
               .FirstOrDefault();

            heroi.Name = "Hulk";
            
            _context.SaveChanges();

            return Ok();
        }
        

        [HttpGet("AddRange")]
        public ActionResult GetAddRange()
        {
            _context.AddRange(
                new Heroi { Name = "Capitão América" },
                new Heroi { Name = "Pantera Negra" },
                new Heroi { Name = "Capitã marvel" },
                new Heroi { Name = "Doutor Estranho" },
                new Heroi { Name = "Gavião Arqueiro" },
                new Heroi { Name = "Viúva negra" },
                new Heroi { Name = "Thanos" }
                );

            var heroi = _context.Herois
            .Where(h => h.Id == 1) 
            .FirstOrDefault();

            heroi.Name = "Hulk";
            // _context.Herois.Add(heroi);
            _context.SaveChanges();

            return Ok();
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
            var heroi = _context.Herois
                                .Where(x => x.Id == id)
                                .Single();
            _context.Herois.Remove(heroi);
            _context.SaveChanges();
        }
    }
}
