using Microsoft.AspNetCore.Mvc;
using TesteApi.DomainService.IServices;
using TesteApi.Entities;
using TesteApi.Interfaces;

namespace TesteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CredorController : ControllerBase
    {
        private readonly ICredorService _svcCredor;

        public CredorController( ICredorService svcCredor)
        {
            _svcCredor = svcCredor;
        }

        [HttpGet("Tabela")]
        public async Task<JsonResult> GetCredorAsync(decimal id)
        {
            try
            {
                return await _svcCredor.ValidaGetAsync(id);
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpPost("Tabela")]
        public async Task<JsonResult> AddCredorAsync([FromBody] CredorC credor)
        {
            try
            {
                return new JsonResult(await _svcCredor.AdicionarAsync(credor));
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpPut("Tabela")]
        public async Task<JsonResult> UpdateCredorAsync([FromBody] CredorC credor)
        {
            try
            {
                return new JsonResult(await _svcCredor.AlterarAsync(credor));
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }

        [HttpDelete("Tabela")]
        public async Task<JsonResult> DeleteCredorAsync(decimal id)
        {
            try
            {
                return new JsonResult(await _svcCredor.DeletarAsync(id));
            }
            catch(Exception e)
            {
                return new JsonResult(e);
            }
        }

    }
}
