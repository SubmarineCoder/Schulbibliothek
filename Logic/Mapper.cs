using Schulbibliothek.Models;
using Schulbibliothek.Models.Interfaces;
using Schulbibliothek.Viewmodels;

namespace Schulbibliothek.Logic
{
    public class Mapper : IMapper
    {
        public TransaktionViewModel Map(Transaktion transaktion)
        {
            if (transaktion == null)
                return new TransaktionViewModel();

            var transaktionViewModel = new TransaktionViewModel();

            return transaktionViewModel;
        }
    }
}
