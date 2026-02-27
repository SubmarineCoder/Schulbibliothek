namespace Schulbibliothek.Models
{
    public class Buch
    {
        public int BuchId { get; set; }
        public string BuchName { get; set; } = null!;
        public string Autor { get; set; } = null!;
        public bool istVerfuegbar { get; set; } = true;
        public IEnumerable<Transaktion>? Transaktionen { get; set; }

    }
}
