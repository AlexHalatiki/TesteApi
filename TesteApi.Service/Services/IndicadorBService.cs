using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteApi.DomainService.IServices;
using TesteApi.Entities;
using TesteApi.Interfaces;
using TesteApi.Repository.Context;
using TesteApi.Servicos;

namespace TesteApi.Service.Services
{
    public class IndicadorBService : IIndicadorService
    {
        private readonly IIndicador _indicadorToJson;

        public IndicadorBService(IIndicador indicadorToJson)
        {
            _indicadorToJson = indicadorToJson;
        }

        public async Task<bool> VerificaEntidadeAsync(decimal id)
        {
            var entidade = await _indicadorToJson.GetTabelaAsync(id);
            if (entidade == null)
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
                return new JsonResult(await _indicadorToJson.GetTabelaAsync(id));
            }
            return new JsonResult(teste);
        }

        public async Task<IndicadorB> AdicionarAsync(IndicadorB indicador)
        {
            return await _indicadorToJson.AddTabelaAsync(indicador);
        }

        public async Task<bool> AlterarAsync(IndicadorB indicador)
        {
            var teste = await VerificaEntidadeAsync(indicador.Id);
            if (teste)
            {
                await _indicadorToJson.UpdateTabelaAsync(indicador);
            }
            return teste;
        }

        public async Task<bool> DeletarAsync(decimal id)
        {
            if (!await VerificaEntidadeAsync(id))
            {
                return false;
            }
            await _indicadorToJson.DeleteTabelaAsync(id);
            return true;
        }
    }
}
