using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Schulbibliothek.Data;
using Schulbibliothek.Models.Interfaces;
using Schulbibliothek.Viewmodels;

namespace Schulbibliothek.Controllers
{
    public class MitarbeiterController : Controller
    {
        private readonly SchulbibliothekDbContext _dbContext;
        private readonly IMapper _mapper;

        public MitarbeiterController(SchulbibliothekDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BuchHinzufuegen()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BuchHinzufuegen(BuchViewModel viewModel)
        {
            if(!ModelState.IsValid)
                return View(viewModel);

            var buch = _mapper.Map(viewModel);
            
            if(buch != null)
                _dbContext.Buecher.Add(buch);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(BuchHinzufuegen));

        }

        [HttpGet]
        public IActionResult PersonHinzufuegen()
        {
            return View();
        }

        [HttpPost]

        public IActionResult PersonHinzufuegen(PersonViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var person = _mapper.Map(viewModel);

            if (person != null)
                _dbContext.Personen.Add(person);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(PersonHinzufuegen));
        }

        [HttpGet]
        public IActionResult TransaktionAnlegen(TransaktionAnlegenViewModel viewModel)
        {
            var personen = _dbContext.Personen.Where(p => p.Aktiv == true).ToList();
            personen.ForEach(person => viewModel.Personen.Add(_mapper.Map(person)));

            var buecher = _dbContext.Buecher.Where(b => b.IstVerfuegbar == true).ToList();
            buecher.ForEach(buch => viewModel.Buecher.Add(_mapper.Map(buch)));

            return View(viewModel);
        }

        //[HttpPost]
        //public IActionResult TransaktionAnlegen(TransaktionAnlegenViewModel viewModel)
        //{
        //    return View();
        //}
    }
}
