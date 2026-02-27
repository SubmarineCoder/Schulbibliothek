using Schulbibliothek.Models;

namespace Schulbibliothek.Viewmodels
{
    public class TransaktionenViewModel
    {
        public IEnumerable<Transaktion> Transaktionen { get; set; } = Enumerable.Empty<Transaktion>();

    }
}
