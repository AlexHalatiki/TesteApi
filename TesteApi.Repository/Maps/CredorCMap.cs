using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteApi.Entities;

namespace TesteApi.Repository.Maps
{
    public class CredorCMap : IEntityTypeConfiguration<CredorC>
    {
        public void Configure(EntityTypeBuilder<CredorC> builder)
        {
            builder.ToTable("Credor_C");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.CodigoArquivo).HasColumnName("cd_arquivo");
            builder.Property(x => x.TipoRegistro).HasColumnName("TipoRegistro");
            builder.Property(x => x.CodigoSistema).HasColumnName("CodigoSistema");
            builder.Property(x => x.DataMovimento).HasColumnName("DataMovimento");
            builder.Property(x => x.TipoInterface).HasColumnName("TipoInterface");
            builder.Property(x => x.CodigoCredor).HasColumnName("CodigoCredor");
            builder.Property(x => x.CodigoCliente).HasColumnName("CodigoCliente");
            builder.Property(x => x.CodigoAcordo).HasColumnName("CodigoAcordo");
            builder.Property(x => x.DataAcordo).HasColumnName("DataAcordo");
            builder.Property(x => x.ValorTotalAcordo).HasColumnName("ValorTotalAcordo");
            builder.Property(x => x.MensagemCredor).HasColumnName("MensagemCredor");
            builder.Property(x => x.IndicadorProcessamento).HasColumnName("IndicadorProcessamento");
            builder.Property(x => x.CodigoAcordoAssessoria).HasColumnName("CodigoAcordoAssessoria");
            builder.Property(x => x.Linha).HasColumnName("Linha");
        }
    }
}
