using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Petshop.Infra.Data.Mapeamentos
{
    public class PetshopMap : MapBase<Petshop.Dominio.Entidades.Petshop>
{
        public override void Configure(EntityTypeBuilder<Petshop.Dominio.Entidades.Petshop> builder)
        {
            base.Configure(builder);
            builder.ToTable("Petshop");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
            builder.Property(c => c.Endereco).IsRequired().HasColumnName("Endereco");
            builder.Property(c => c.QuantidadeVagas).IsRequired().HasColumnName("QuantidadeVagas");
        }
    }
}
