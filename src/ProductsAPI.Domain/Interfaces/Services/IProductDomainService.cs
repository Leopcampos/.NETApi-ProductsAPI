using ProductsAPI.Domain.Models;

namespace ProductsAPI.Domain.Interfaces.Services;

public interface IProductDomainService : IBaseDomainService<Product, Guid>
{
}