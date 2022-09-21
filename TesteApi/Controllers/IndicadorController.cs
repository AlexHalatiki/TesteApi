using Microsoft.AspNetCore.Mvc;
using TesteApi.Interfaces;
using TesteApi.Entities;
using TesteApi.Servicos;
using TesteApi.DomainService.IServices;
using System;

namespace TesteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndicadorController : ControllerBase
    {
        private readonly IIndicadorService _svcIndicador;

        public IndicadorController( IIndicadorService svcIndicador)
        {
           _svcIndicador = svcIndicador;
        }

        [HttpGet("Tabela")]
        public async Task<JsonResult> GetIndicadorAsync(decimal id)
        {
            try
            {
                return await _svcIndicador.ValidaGetAsync(id);
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpPost("Tabela")]
        public async Task<JsonResult> AddIndicadorAsync([FromBody] IndicadorB indicador)
        {
            try
            {
                return new JsonResult(await _svcIndicador.AdicionarAsync(indicador));
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpPut("Tabela")]
        public async Task<JsonResult> UpdateIndicadorAsync([FromBody] IndicadorB credor)
        {
            try
            {
                return new JsonResult(await _svcIndicador.AlterarAsync(credor));
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpDelete("Tabela")]
        public async Task<JsonResult> DeleteIndicadorAsync(decimal id)
        {
            try
            {
                return new JsonResult(await _svcIndicador.DeletarAsync(id));
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }
    }
}
