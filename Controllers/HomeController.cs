using Microsoft.AspNetCore.Mvc;
using Schulbibliothek.Data;
using Schulbibliothek.Models;
using Schulbibliothek.Models.Interfaces;
using Schulbibliothek.Viewmodels;
using System.Diagnostics;

namespace Schulbibliothek.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchulbibliothekDbContext _dbContext;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, SchulbibliothekDbContext dbContext, IMapper mapper)
        {
            _logger = logger;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IActionResult Index(TransaktionenViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var trantsaktionen = _dbContext.Transaktionen.ToList();

            //viewModel.Transaktionen = trantsaktionen;
            //Test Dummy Daten Transaktion bevor change to transaktionenviewmodel
            //viewModel.Transaktionen = new List<Transaktion>() { new Transaktion() {
            //    Beschreibung = "test",
            //    Buch = new Buch() { Autor = "test", BuchName = "test", IstVerfuegbar = true },
            //    Datum = DateOnly.FromDateTime(new DateTime(2021, 12, 12)),
            //    IstAusgeliehen = false,
            //    Person = new Person() { Vorname = "Peter", Nachname = "schilling", Aktiv = true } } };


            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
