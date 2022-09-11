using ecommerce.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ecommerce.infrastructure.EntityTypeConfiguration
{
    public class ProdutoEntityTypeConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTOS");

            builder.Property(x => x.Id)
                .HasColumnName("ID");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataCadastro)
                .HasColumnName("DATA_CADASTRO")
                .IsRequired();

            builder.Property(x => x.DataAtualizacao)
                .HasColumnName("DATA_ATUALIZACAO")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .HasColumnName("ATIVO")
                .IsRequired();

            builder.Property(x => x.Nome)
               .HasColumnName("NOME")
               .HasColumnType("nvarchar(100)")
               .IsRequired();

            builder.Property(x => x.Descricao)
               .HasColumnName("DESCRICAO")
               .HasColumnType("nvarchar(2500)")
               .IsRequired();

            builder.Property(x => x.SKU)
                .HasColumnName("SKU")
                .HasColumnType("nvarchar(12)")
                .IsRequired();

            builder.HasMany(x => x.Imagens)
                .WithOne(x => x.Produto);
        }
    }
}
