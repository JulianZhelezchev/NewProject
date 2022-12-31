using Microsoft.AspNetCore.Http;
using StoreWebSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreWebSystem.Services
{

    
        public interface IProductService
        {
            Task CreateAsync(ProductDto product);
            Task DeleteAsync(int id);
            Task<bool> ExistAsync(int id);
            Task<List<ProductDto>> GetAllAsync();
            Task<ProductDto> GetByIdAsync(int id);
            Task UpdateAsync(int id, ProductDto product);
            Task<FileModel> UploadFileToFileSystem(IFormFile formfile);
        }
    
}
