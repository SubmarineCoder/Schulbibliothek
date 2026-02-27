namespace Schulbibliothek.Viewmodels
{
    public class TransaktionViewModel
    {
        public string IstAusgeliehen {  get; set; } = string.Empty;
        public string Buchtitel {  get; set; } = string.Empty;
        public DateOnly Datum {  get; set; }
        public string PersonName { get; set; } = null!;
        public string? BildLink { get; }


        //Eigenschaft
        //public stringBase64 falls ich das Bild direkt im Viewmodel haben will, diese variante eignet sich aber nur bei sehr kleinen Daten wie icons,
        //deswegen soll man es nicht so lösen, da Standard Bilder vom User zu groß dafür sind.

    }
}
