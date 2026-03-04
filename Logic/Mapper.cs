using Schulbibliothek.Data;
using Schulbibliothek.Models;
using Schulbibliothek.Models.Interfaces;
using Schulbibliothek.Viewmodels;

namespace Schulbibliothek.Logic
{
    public class Mapper : IMapper
    {
        private readonly SchulbibliothekDbContext _dbContext;
        public Mapper(SchulbibliothekDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }

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

        public Person Map(PersonViewModel personViewModel)
        {
            if (personViewModel == null) return new Person();

            var person = new Person();

            person.Vorname = personViewModel.Vorname;
            person.Nachname = personViewModel.Nachname;

            return person;
        }

        public BuchViewModel Map(Buch buch)
        {
            if (buch == null)
                return new BuchViewModel();

            var viewModel = new BuchViewModel();

            viewModel.Autor = buch.Autor;
            viewModel.BuchName = buch.BuchName;
            return viewModel;
        }

        public PersonViewModel Map(Person person)
        {
            if (person == null) return new PersonViewModel();

            var viewModel = new PersonViewModel();

            viewModel.Vorname = person.Vorname;
            viewModel.Nachname= person.Nachname;

            return viewModel;
        }
        public TransaktionAnlegenViewModel Map(Person person, Buch buch)
        {
            if (person == null || buch == null)
                return new TransaktionAnlegenViewModel();


            var personen = _dbContext.Personen.ToList();
            var buecher = _dbContext.Buecher.ToList();


            var viewModel = new TransaktionAnlegenViewModel();

            buecher.ForEach(buch => viewModel.Buecher.Add(Map(buch)));
            personen.ForEach(person => viewModel.Personen.Add(Map(person)));


            return viewModel;
        }

        public Transaktion Map(TransaktionAnlegenViewModel viewModel)
        {
            if (viewModel == null)
                return new Transaktion();

            var transaktion = new Transaktion();

            transaktion.Buch.BuchName = viewModel.Buecher[0].BuchName;
            transaktion.IstAusgeliehen = viewModel.AusleihenZurueckgeben;

            return transaktion;
        }
    }
}
