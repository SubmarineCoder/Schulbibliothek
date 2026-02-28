using Microsoft.AspNetCore.Mvc;
using Schulbibliothek.Data;
using Schulbibliothek.Models.Interfaces;
using Schulbibliothek.Viewmodels;

namespace Schulbibliothek.Controllers
{
    public class MitarbeiterController : Controller
    {
        private readonly SchulbibliothekDbContext _context;
        private readonly IMapper _mapper;

        public MitarbeiterController(SchulbibliothekDbContext context, IMapper mapper)
        {
            _context = context;
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
                _context.Buecher.Add(buch);
            _context.SaveChanges();

            return RedirectToAction(nameof(BuchHinzufuegen));

        }

        [HttpGet]
        public IActionResult PersonHinzufuegen()
        {
            return View();
        }

    }
}
