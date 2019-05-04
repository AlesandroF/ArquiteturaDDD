using ArquiteturaDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ArquiteturaDDD.Infra.Data.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext(DbContextOptions<SQLContext> options) : base(options) {   }

        public SQLContext() {  }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=ArquiteturaDDD;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }
    }
}