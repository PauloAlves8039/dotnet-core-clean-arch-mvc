using CleanArchMvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product> GetByIdAsync(int? id);

        Task<Product> GetProductCategoryAsync(int? id);

        Task<Product> CreateAsync(Product product);

        Task<Product> UpdateAsync(Category product);

        Task<Product> RemoveAsync(Category product);
    }
}
