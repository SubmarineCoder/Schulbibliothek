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

            if (transaktion.IstAusgeliehen == true)
                transaktionViewModel.IstAusgeliehen = "Ausgeliehen";
            else
                transaktionViewModel.IstAusgeliehen = "Zurückgegeben";

            transaktionViewModel.Buchtitel = transaktion.Buch.BuchName;
            transaktionViewModel.Datum = transaktion.Datum;
            transaktionViewModel.PersonName = $"{transaktion.Person.Vorname} {transaktion.Person.Nachname}";
            transaktionViewModel.Beschreibung = transaktion.Beschreibung;
            return transaktionViewModel;
        }

        public Buch Map(BuchViewModel buchViewModel)
        {
            if (buchViewModel == null)
                return new Buch();

            var buch = new Buch();

            buch.BuchName = buchViewModel.BuchName;
            buch.Autor = buchViewModel.Autor;

            return buch;
        }
    }
}
