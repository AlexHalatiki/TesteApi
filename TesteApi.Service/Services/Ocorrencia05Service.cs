using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteApi.DomainService.IServices;
using TesteApi.Entities;
using TesteApi.Interfaces;
using TesteApi.Repository.Context;
using TesteApi.Servicos;

namespace TesteApi.Service.Services
{
    public class Ocorrencia05Service : IOcorrenciaService
    {
        private readonly IOcorrencia _ocorrenciaToJson;

        public Ocorrencia05Service(IOcorrencia ocorrenciaToJson)
        {
            _ocorrenciaToJson = ocorrenciaToJson;
        }

        public async Task<bool> VerificaEntidadeAsync(decimal id)
        {
            var entidade = await _ocorrenciaToJson.GetTabelaAsync(id);
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
                return new JsonResult(await _ocorrenciaToJson.GetTabelaAsync(id));
            }
            return new JsonResult(teste);
        }

        public async Task<Ocorrencia05> AdicionarAsync(Ocorrencia05 ocorrencia)
        {
            return await _ocorrenciaToJson.AddTabelaAsync(ocorrencia);
        }

        public async Task<bool> AlterarAsync(Ocorrencia05 ocorrencia)
        {
            var teste = await VerificaEntidadeAsync(ocorrencia.Id);
            if (teste)
            {
                await _ocorrenciaToJson.UpdateTabelaAsync(ocorrencia);
            }
            return teste;
        }

        public async Task<bool> DeletarAsync(decimal id)
        {
            if (!await VerificaEntidadeAsync(id))
            {
                return false;
            }
            await _ocorrenciaToJson.DeleteTabelaAsync(id);
            return true;
        }
    }
}
