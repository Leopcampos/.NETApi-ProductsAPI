using ProductsAPI.Application.Models.Commands;
using ProductsAPI.Application.Models.Queries;

namespace ProductsAPI.Application.Interfaces;

/// <summary>
/// Interface para os serviços da aplicação
/// </summary>
public interface IProductsAppService
{
    Task<ProductsQuery> Create(ProductsCreateCommand command);  
    Task<ProductsQuery> Update(ProductsUpdateCommand command);  
    Task<ProductsQuery> Delete(ProductsDeleteCommand command);  
}