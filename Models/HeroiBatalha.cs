namespace EFCore.WebAPI2.Models
{
    public class HeroiBatalha
    {
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }

        public int BatalhaId { get; set; }
        public Batalha Batalha { get; set; }
    }
}
