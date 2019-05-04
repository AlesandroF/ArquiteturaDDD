using ArquiteturaDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArquiteturaDDD.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .IsRequired();

            builder.Property(c => c.Marca)
                .IsRequired();

            builder.Property(c => c.PrecoCusto)
                .IsRequired();

            builder.Property(c => c.PrecoVenda)
                .IsRequired();

            builder.Property(c => c.CodigoUsuario)
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
               .IsRequired();
        }
    }
}