namespace TesteApi.Entities
{
    public class Ocorrencia05
    {
        public decimal Id { get; set; }
        public decimal? CodigoArquivo { get; set; }
        public string? TipoRegistro { get; set; }
        public string? CodigoSistema { get; set; }
        public DateTime? DataMovimento { get; set; }
        public string? TipoInterface { get; set; }
        public string? CodigoCredor { get; set; }
        public string? CodigoCliente { get; set; }
        public DateTime? DataOcorrencia { get; set; }
        public TimeSpan? HoraOcorencia { get; set; }
        public string? CodigoOcorrencia { get; set; }
        public string? ComplementoOcorrencia { get; set; }
        public decimal? Linha { get; set; }
    }
}
