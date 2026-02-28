using Schulbibliothek.Viewmodels;

namespace Schulbibliothek.Models.Interfaces
{
    public interface IMapper
    {
        TransaktionViewModel Map(Transaktion transaktion);

        Buch Map(BuchViewModel buchViewModel);
    }
}
