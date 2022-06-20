using System;
using System.Collections.Generic;

namespace EFCore.WebAPI2.Models
{
    public class Batalha
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrição { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }

        public List<HeroiBatalha> HeroisBatalhas { get; set; }
    }

    
    
}
