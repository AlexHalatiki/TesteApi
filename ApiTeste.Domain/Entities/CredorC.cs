using System.ComponentModel.DataAnnotations.Schema;

namespace TesteApi.Entities
{
    public class CredorC
    {
        public decimal Id { get; set; }
        public decimal? CodigoArquivo { get; set; }
        public string? TipoRegistro { get; set; }
        public string? CodigoSistema { get; set; }
        public DateTime? DataMovimento { get; set; }
        public string? TipoInterface { get; set; }
        public string? CodigoCredor { get; set; }
        public string? CodigoCliente { get; set; }
        public string? CodigoAcordo { get; set; }
        public DateTime? DataAcordo { get; set; }
        public decimal? ValorTotalAcordo { get; set; }
        public string? MensagemCredor { get; set; }
        public string? IndicadorProcessamento { get; set; }
        public string? CodigoAcordoAssessoria { get; set; }
        public decimal? Linha { get; set; }
    }
}
