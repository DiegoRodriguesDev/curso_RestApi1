using Microsoft.EntityFrameworkCore;

namespace curso_RestApi1.src.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {

        }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
