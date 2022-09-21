using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TesteApi.Entities;
using TesteApi.Interfaces;
using TesteApi.Repository.Context;

namespace TesteApi.Servicos
{
    public class CredorToJson : ICredor
    {
        private readonly ApliccationDbContext _context;

        public CredorToJson( ApliccationDbContext context)
        {
            _context = context;
        }

        public async Task<CredorC> GetTabelaAsync(decimal id)
        {
            return await _context.CredorC.FindAsync(id);
            /*using (var dbConnection = new SqlConnection(_configuration.GetConnectionString("LogYamaha")))
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("select Id, cd_arquivo as CodigoArquivo, TipoRegistro, CodigoSistema, DataMovimento, TipoInterface, CodigoCredor, CodigoCliente, CodigoAcordo, DataAcordo, ValorTotalAcordo, MensagemCredor, IndicadorProcessamento, CodigoAcordoAssessoria, Linha from Credor_C where Id = @id;");

                var response = await dbConnection.QueryAsync<CredorC>(sb.ToString(), new { id });

                return response.ToList();
            }*/
        }

        public async Task<CredorC> AddTabelaAsync(CredorC entidade)
        {
            await _context.CredorC.AddAsync(entidade);
            _context.SaveChanges();
            return entidade;
        }

        public async Task<CredorC> UpdateTabelaAsync(CredorC entidade)
        {
            _context.Entry(entidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entidade;
        }

        public async Task DeleteTabelaAsync(decimal id)
        {
            var entidade = await GetTabelaAsync(id);
            _context.CredorC.Remove(entidade);
            await _context.SaveChangesAsync();
        }


        /*public static string ClientesJson(List<Cliente> clientes)
        {
            return JsonConvert.SerializeObject(clientes);
        }*/
    }
}
