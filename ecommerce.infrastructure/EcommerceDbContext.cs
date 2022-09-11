using ecommerce.domain;
using ecommerce.infrastructure.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.infrastructure
{
    public class EcommerceDbContext : DbContext
    {
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<ImagemProduto>? ImagensProdutos { get; set; }

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ImagemProdutoEntityTypeConfiguration());
        }
    }
}
