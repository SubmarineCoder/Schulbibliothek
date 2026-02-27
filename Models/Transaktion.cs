using System.ComponentModel.DataAnnotations;

namespace Schulbibliothek.Models
{
    public class Transaktion
    {
        public int TransaktionId { get; set; }

        public Person Person { get; set; } = null!;

        public Buch Buch { get; set; } = null!;

        public bool istAusgeliehen { get; set; }

        public DateOnly Datum {  get; set; }

        [StringLength(50)]
        public string Beschreibung { get; set; } = null!;
    }
}
