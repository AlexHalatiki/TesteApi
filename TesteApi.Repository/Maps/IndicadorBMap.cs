using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteApi.Entities;

namespace TesteApi.Repository.Maps
{
    public class IndicadorBMap : IEntityTypeConfiguration<IndicadorB>
    {
        public void Configure(EntityTypeBuilder<IndicadorB> builder)
        {
            builder.ToTable("Indicador_B");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.CodigoArquivo).HasColumnName("cd_arquivo");
            builder.Property(x => x.TipoRegistro).HasColumnName("TipoRegistro");
            builder.Property(x => x.CodigoSistema).HasColumnName("CodigoSistema");
            builder.Property(x => x.DataMovimento).HasColumnName("DataMovimento");
            builder.Property(x => x.TipoInterface).HasColumnName("TipoInterface");
            builder.Property(x => x.CodigoCredor).HasColumnName("CodigoCredor");
            builder.Property(x => x.CodigoCliente).HasColumnName("CodigoCliente");
            builder.Property(x => x.CodigoProduto).HasColumnName("CodigoProduto");
            builder.Property(x => x.NumeroContrato).HasColumnName("NumeroContrato");
            builder.Property(x => x.CodigoIndicador).HasColumnName("CodigoIndicador");
            builder.Property(x => x.ValorIndicador).HasColumnName("ValorIndicador");
            builder.Property(x => x.TipoIndicador).HasColumnName("TipoIndicador");
            builder.Property(x => x.Linha).HasColumnName("Linha");
        }
    }
}
