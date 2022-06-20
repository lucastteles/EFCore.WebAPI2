using System.Collections.Generic;

namespace EFCore.WebAPI2.Models
{
    public class Heroi
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IdentidadeSecreta Identidade { get; set; }

        public List<Arma> Armas { get; set; } //relacionamento muitos para muitos

        public List<HeroiBatalha> HeroisBatalhas { get; set; } //relacionamento muitos para muitos

    }
}
