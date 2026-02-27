using Microsoft.EntityFrameworkCore;
using Schulbibliothek.Models;

namespace Schulbibliothek.Data
{
    public class SchulbibliothekDbContext  : DbContext
    {
        public SchulbibliothekDbContext(DbContextOptions <SchulbibliothekDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Transaktion> Transaktionen { get; set; } // virtual auch hier wegen lazy loading kann man auch hier weglassen

        public virtual DbSet<Person> Personen { get; set; }

        public virtual DbSet<Buch> Buecher { get; set; }


    }
}
