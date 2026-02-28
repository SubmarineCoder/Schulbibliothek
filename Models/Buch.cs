using System.ComponentModel.DataAnnotations;

namespace Schulbibliothek.Models
{
    public class Buch
    {
        public int BuchId { get; set; }

        [StringLength(100)]
        public string BuchName { get; set; } = string.Empty;

        [StringLength(30)]
        public string Autor { get; set; } = string.Empty;
        public bool IstVerfuegbar { get; set; } = true;
        public IEnumerable<Transaktion>? Transaktionen { get; set; }

    }
}
