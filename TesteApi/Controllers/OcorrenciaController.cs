using Microsoft.AspNetCore.Mvc;
using TesteApi.DomainService.IServices;
using TesteApi.Entities;

namespace Atividade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OcorrenciaController : ControllerBase
    {
        private readonly IOcorrenciaService _svcOcorrencia;

        public OcorrenciaController(IOcorrenciaService svcOcorrencia)
        {
            _svcOcorrencia = svcOcorrencia;
        }

        [HttpGet("Tabela")]
        public async Task<JsonResult> GetOcorrenciaAsync(decimal id)
        {
            try
            {
                return await _svcOcorrencia.ValidaGetAsync(id);
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpPost("Tabela")]
        public async Task<JsonResult> AddOcorrenciaAsync([FromBody] Ocorrencia05 ocorrencia)
        {
            try
            {
                return new JsonResult(await _svcOcorrencia.AdicionarAsync(ocorrencia));
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpPut("Tabela")]
        public async Task<JsonResult> UpdateOcorrenciaAsync([FromBody] Ocorrencia05 ocorrencia)
        {
            try
            {
                return new JsonResult(await _svcOcorrencia.AlterarAsync(ocorrencia));
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpDelete("Tabela")]
        public async Task<JsonResult> DeleteOcorrenciaAsync(decimal id)
        {
            try
            {
                return new JsonResult(await _svcOcorrencia.DeletarAsync(id));
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }
    }
}