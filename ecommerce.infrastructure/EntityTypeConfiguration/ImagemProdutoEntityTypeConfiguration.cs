using ecommerce.domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.infrastructure.EntityTypeConfiguration
{
    public class ImagemProdutoEntityTypeConfiguration : IEntityTypeConfiguration<ImagemProduto>
    {
        public void Configure(EntityTypeBuilder<ImagemProduto> builder)
        {
            builder.ToTable("IMAGENS_PRODUTOS");

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasDefaultValueSql("uuid()");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.IdProduto)
                .HasColumnName("ID_PRODUTOOOOOO");

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
               .HasColumnType("nvarchar(50)")
               .IsRequired();

            builder.Property(x => x.CaminhoArquivo)
                .HasColumnName("CAMINHO_ARQUIVO")
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.Imagens);
        }
    }
}
