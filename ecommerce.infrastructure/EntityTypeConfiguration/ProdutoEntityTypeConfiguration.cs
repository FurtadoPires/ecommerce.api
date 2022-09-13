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
                .HasColumnName("ID")
                .HasDefaultValueSql("uuid()");

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
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(x => x.Descricao)
               .HasColumnName("DESCRICAO")
               .HasColumnType("varchar(5000)")
               .IsRequired();

            builder.Property(x => x.SKU)
                .HasColumnName("SKU")
                .HasColumnType("varchar(12)")
                .IsRequired();

            builder.HasMany(x => x.Imagens)
                .WithOne(x => x.Produto);

            builder.HasData(
                new Produto
                {
                    Nome = "ããããããõõõõõoõõõõõõ",
                    Descricao = "sidnsaidnasidnasidas",
                    SKU = "56768787564",
                    DataCadastro = DateTime.Now,
                    DataAtualizacao = DateTime.Now,
                    Ativo = true
                });
            builder.HasData(
                new Produto
                {
                    Nome = "ÂÂÂssíííççééÈÈÈÈÀÀÀàà",
                    Descricao = "8769tyhfsdssf",
                    SKU = "343445667",
                    DataCadastro = DateTime.Now,
                    DataAtualizacao = DateTime.Now,
                    Ativo = true
                });
        }
    }
}
