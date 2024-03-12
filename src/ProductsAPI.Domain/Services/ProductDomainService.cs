using ProductsAPI.Domain.Interfaces.Repositories;
using ProductsAPI.Domain.Interfaces.Services;
using ProductsAPI.Domain.Models;

namespace ProductsAPI.Domain.Services;

public class ProductDomainService : BaseDomainService<Product, Guid>, IProductDomainService
{
    private readonly IUnitOfWork? _unitOfWork;

    public ProductDomainService(IUnitOfWork? unitOfWork) : base(unitOfWork?.ProductRepository) 
        => _unitOfWork = unitOfWork;
}