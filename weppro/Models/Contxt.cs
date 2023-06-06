using Microsoft.EntityFrameworkCore;

namespace weppro.Models
{
    public class Contxt : DbContext
    {
        public Contxt(DbContextOptions<Contxt> options)
            : base(options) { }

        public DbSet<infos> Infostep1 { get; set; }

    }

}