using ProductsAPI.Domain.Models;

namespace ProductsAPI.Domain.Interfaces.Repositories;

public interface IProductRepository : IBaseRepository<Product, Guid>
{
}