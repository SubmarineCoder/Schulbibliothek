using Schulbibliothek.Viewmodels;

namespace Schulbibliothek.Models.Interfaces
{
    public interface IMapper
    {
        TransaktionViewModel Map(Transaktion transaktion);
        Buch Map(BuchViewModel buchViewModel);
        Person Map(PersonViewModel personViewModel);
        BuchViewModel Map(Buch buch);
        PersonViewModel Map(Person person);
        TransaktionAnlegenViewModel Map(Person person, Buch buch);
    }
}
