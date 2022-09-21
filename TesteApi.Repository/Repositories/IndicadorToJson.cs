using System.Data.SqlClient;
using System.Text;
using TesteApi.Entities;
using Dapper;
using TesteApi.Interfaces;
using Microsoft.Extensions.Configuration;
using TesteApi.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace TesteApi.Servicos
{
    public class IndicadorToJson : IIndicador
    {
        private readonly ApliccationDbContext _context;

        public IndicadorToJson( ApliccationDbContext context)
        {
            _context = context;
        }

        public async Task<IndicadorB> GetTabelaAsync(decimal id)
        { 
            return await _context.IndicadorB.FindAsync(id); 

            /*using (var dbConnection = new SqlConnection(_configuration.GetConnectionString("LogYamaha")))
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("select Id, cd_arquivo as CodigoArquivo, TipoRegistro, CodigoSistema, DataMovimento, TipoInterface, CodigoCredor, CodigoCliente, CodigoProduto, NumeroContrato, CodigoIndicador, ValorIndicador, TipoIndicador, Linha from Indicador_B where Id = @id;");

                var response = await dbConnection.QueryAsync<IndicadorB>(sb.ToString(), new { id });

                return response.ToList();
            }*/
        }

        public async Task<IndicadorB> AddTabelaAsync(IndicadorB entidade)
        {
            await _context.IndicadorB.AddAsync(entidade);
            _context.SaveChanges();
            return entidade;
        }

        public async Task<IndicadorB> UpdateTabelaAsync(IndicadorB entidade)
        {
            _context.Entry(entidade).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entidade;
        }

        public async Task DeleteTabelaAsync(decimal id)
        {
            var entidade = await GetTabelaAsync(id);
            _context.Remove(entidade);
            await _context.SaveChangesAsync();
        }


        /*public static string ClientesJson(List<Cliente> clientes)
        {
            return JsonConvert.SerializeObject(clientes);
        }*/
    }
}
