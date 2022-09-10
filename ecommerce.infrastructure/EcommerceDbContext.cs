using ecommerce.domain;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.infrastructure
{
    public class EcommerceDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ImagemProduto> ImagensProdutos { get; set; }

        public EcommerceDbContext(ModelBuilder modelBuilder)
        {

        }
    }
}
