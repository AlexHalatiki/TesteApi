using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteApi.Entities;

namespace TesteApi.Repository.Maps
{
    public class Ocorrencia05Map : IEntityTypeConfiguration<Ocorrencia05>
    {
        public void Configure(EntityTypeBuilder<Ocorrencia05> builder)
        {
            builder.ToTable("Ocorrencias_05");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.CodigoArquivo).HasColumnName("cd_arquivo");
            builder.Property(x => x.TipoRegistro).HasColumnName("TipoRegistro");
            builder.Property(x => x.CodigoSistema).HasColumnName("CodigoSistema");
            builder.Property(x => x.DataMovimento).HasColumnName("DataMovimento");
            builder.Property(x => x.TipoInterface).HasColumnName("TipoInterface");
            builder.Property(x => x.CodigoCredor).HasColumnName("CodigoCredor");
            builder.Property(x => x.CodigoCliente).HasColumnName("CodigoCliente");
            builder.Property(x => x.DataOcorrencia).HasColumnName("DataOcorrencia");
            builder.Property(x => x.HoraOcorencia).HasColumnName("HoraOcorrencia");
            builder.Property(x => x.CodigoOcorrencia).HasColumnName("CodigoOcorrencia");
            builder.Property(x => x.ComplementoOcorrencia).HasColumnName("ComplementoOcorrencia");
            builder.Property(x => x.Linha).HasColumnName("Linha");
        }
    }
}
