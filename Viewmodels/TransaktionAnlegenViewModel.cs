namespace Schulbibliothek.Viewmodels
{
    public class TransaktionAnlegenViewModel
    {
        public List<PersonViewModel> Personen { get; set; } = new List<PersonViewModel>();
        public List<BuchViewModel> Buecher { get; set; } = new List<BuchViewModel>();
        public bool AusleihenZurueckgeben {  get; set; }
        public void Add(PersonViewModel person)
        {
            if (person == null) 
                throw new ArgumentNullException(nameof(person));

            Personen.Add(person);

        }

        public void Add(BuchViewModel buch)
        {
            if (buch == null)
                throw new ArgumentNullException(nameof(buch));

            Buecher.Add(buch);
              
            
        }

    }
}
