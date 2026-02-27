
using Microsoft.AspNetCore.Mvc;
using Schulbibliothek.Data;

namespace Schulbibliothek.Controllers
{
    public class StatistikController : Controller
    {
        private readonly SchulbibliothekDbContext _dbContext;
        public StatistikController(SchulbibliothekDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
