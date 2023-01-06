using LeaveManagement_2.Repositories;
namespace LeaveManagement_2.Contracts
{
    public interface IGenericRepository<T> where T : class
    {


        public Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();

        Task<bool> Exists(int id);

        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);


        Task<T> AddAsync(T entity);

    }
}
