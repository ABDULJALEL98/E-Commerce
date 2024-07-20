using E_Commerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Data.Services;

public interface ICategoryServices
{
    Task<IEnumerable<Category>> GetALLAsycn();
    Task<Category> GetByIdAsync(int  id);
    Task CreateAsync(Category entity);
    Task UpdateAsync(Category entity);
    Task DeleteAsync(int id);
}
