namespace TesteApi.Interfaces
{
    public interface IToJson<T>
    {
        Task<T>GetTabelaAsync(decimal id);
        Task<T> AddTabelaAsync(T entidade);
        Task<T> UpdateTabelaAsync(T entidade);
        Task DeleteTabelaAsync(decimal id);
    }
}
