using CarbonNowAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarbonNowAPI.Data.TableConfig {
    public class EletricidadeConfig : IEntityTypeConfiguration<Eletricidade> {
        public void Configure(EntityTypeBuilder<Eletricidade> entity) {

            entity.ToTable("Eletricidade");

            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .HasDefaultValueSql("SEQ_ID_ELETRICIDADE.NEXTVAL");

            entity.HasOne(e => e.Usuario)
                .WithMany(u => u.Eletricidade)
                .HasForeignKey(e => e.UsuarioId);

            entity.Property(e => e.UnidadeEletricidade)
                .HasConversion<string>()
                .HasDefaultValueSql("'KWH'")
                .HasMaxLength(3);

            entity.Property(e => e.DataEstimacao)
                .HasDefaultValueSql("SYSDATE");

            entity.Property(e => e.ValorEletricidade).HasColumnType("NUMBER(18,2)");
            entity.Property(e => e.CarbonoKg).HasColumnType("NUMBER(18,2)");

        }
    }
}