using ControleEstoqueComEF6.Dominios;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ControleEstoqueComEF6
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString: "controle_estoque_ef6") { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            base.OnModelCreating(modelBuilder); 
        }
    }
}
