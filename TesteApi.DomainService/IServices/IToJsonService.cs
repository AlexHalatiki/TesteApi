using Microsoft.AspNetCore.Mvc;
using TesteApi.Entities;

namespace TesteApi.DomainService.IServices
{
    public interface IToJsonService<T>
    {
        Task<bool> VerificaEntidadeAsync(decimal id);
        Task<JsonResult> ValidaGetAsync(decimal id);
        Task<T> AdicionarAsync(T entidade);
        Task<bool> AlterarAsync(T entidade);
        Task<bool> DeletarAsync(decimal id);
    }
}
