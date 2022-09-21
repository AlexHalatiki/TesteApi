using Microsoft.AspNetCore.Mvc;
using TesteApi.DomainService.IServices;
using TesteApi.Entities;
using TesteApi.Interfaces;
using TesteApi.Servicos;

namespace TesteApi.Service.Services
{
    public class CredorCService : ICredorService
    {
        private readonly ICredor _credorToJson;

        public CredorCService(ICredor credorToJson)
        {
            _credorToJson = credorToJson;
        }

        public async Task<bool> VerificaEntidadeAsync(decimal id)
        {
            var entidade = await _credorToJson.GetTabelaAsync(id);
            if(entidade == null)
            {
                return false;
            }
            return true;
        }

        public async Task<JsonResult> ValidaGetAsync(decimal id)
        {
            var teste = await VerificaEntidadeAsync(id);
            if (teste)
            {
                return new JsonResult(await _credorToJson.GetTabelaAsync(id));
            }
            return new JsonResult(teste);
        }

        public async Task<CredorC> AdicionarAsync(CredorC credor)
        {
            return await _credorToJson.AddTabelaAsync(credor);
        }

        public async Task<bool> AlterarAsync(CredorC credor)
        {
            var teste = await VerificaEntidadeAsync(credor.Id);
            if (teste)
            {
                await _credorToJson.UpdateTabelaAsync(credor);
            }
            return teste;
        }

        public async Task<bool> DeletarAsync(decimal id)
        {
            if (!await VerificaEntidadeAsync(id))
            {
                return false;
            }
            await _credorToJson.DeleteTabelaAsync(id);
            return true;
        }
    }
}
