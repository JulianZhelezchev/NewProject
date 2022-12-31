using StoreWebSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreWebSystem.Services
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryDto category);
        Task DeleteAsync(int id);
        Task<List<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetByIdAsync(int id);
        Task UpdateAsync(int id, CategoryDto category);
        Task<bool> ExistAsync(int id);
    }
}
