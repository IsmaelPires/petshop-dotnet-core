using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petshop.Dominio.Entidades;

namespace Petshop.Infra.Data.Mapeamentos
{
    public class PetMap : MapBase<Pet>
{
        public override void Configure(EntityTypeBuilder<Pet> builder)
        {
            base.Configure(builder);
            builder.ToTable("Pet");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
            builder.Property(c => c.EstadoSaude).IsRequired().HasColumnName("EstadoSaude");
            builder.Property(c => c.MotivoInternacao).IsRequired().HasColumnName("MotivoInternacao");
            builder.Property(c => c.NomeDono).IsRequired().HasColumnName("NomeDono");
            builder.Property(c => c.TelefoneDono).IsRequired().HasColumnName("TelefoneDono");
            builder.Property(c => c.EnderecoDono).IsRequired().HasColumnName("EnderecoDono");
            builder.Property(c => c.Foto).IsRequired().HasColumnName("Foto");
        }
    }
}
