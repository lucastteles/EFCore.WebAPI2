using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Dominio;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebAPI2.Controllers
{
    [Route("api/values")]
    //[ApiController]

    public class ValuesController : ControllerBase
    {
        public readonly HeroiContext _context;

        public ValuesController(HeroiContext context)
        {
            _context = context;
        }
        // GET api/values
        //[HttpGet("filto/{nome}")]
        [HttpGet("Teste")]
        public ActionResult GetFiltro(string nome)
        {
            var listHeroi = _context.Herois
                           .Where(h => h.Nome.Contains(nome))
                           .ToList();


            // var listHeroi = _context.Herois.ToList();


            //var listHeroi = (from heroi in _context.Herois 
            //                 where heroi.Nome.Contains(nome)
            //                 select heroi).ToList();

            return Ok(listHeroi);
        }

        // GET api/values/5
        [HttpGet("Atualizar/{nameHero}")]
        public ActionResult Get(string nameHero)
        {
            //var heroi = new Heroi { Nome = nameHero };//(Sem Id) entende como Insert 
           
            //var heroi = _context.Herois
            //    .Where(h=> h.Id == 3)//Inserir Id
            //    .FirstOrDefault();

            //heroi.Nome = "Homem Aranha";
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
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}