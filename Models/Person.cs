namespace Schulbibliothek.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        public string Vorname { get; set; } = null!;

        public string Nachname { get; set; } = null!;

        public byte[]? Bild { get; set; }

        public bool Aktiv { get; set; } = true;

        public IEnumerable<Transaktion>? Transaktionen { get; set; }    //als virtual markieren ist relevant,
                                                                        //wenn man das automatische Nachladen nutzen will beim LazyLoading,
                                                                        //welches Standardmäßig/ByDefault deaktiviert ist.
    }
}
