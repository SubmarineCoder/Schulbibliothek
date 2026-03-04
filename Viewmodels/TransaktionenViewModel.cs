using Schulbibliothek.Models;

namespace Schulbibliothek.Viewmodels
{
    public class TransaktionenViewModel
    {
        public IEnumerable<TransaktionViewModel> Transaktionen { get; set; } = Enumerable.Empty<TransaktionViewModel>();

    }
}
