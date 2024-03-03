using MediatR;
using ProductsAPI.Application.Interfaces;
using ProductsAPI.Application.Models.Commands;
using ProductsAPI.Application.Models.Queries;

namespace ProductsAPI.Application.Services;

public class ProductsAppService : IProductsAppService
{
    private readonly IMediator? _mediator;

    public ProductsAppService(IMediator? mediator) 
        => _mediator = mediator;

    public async Task<ProductsQuery> Create(ProductsCreateCommand command)
    {
        return await _mediator.Send(command);
    }

    public async Task<ProductsQuery> Update(ProductsUpdateCommand command)
    {
        return await _mediator.Send(command);
    }

    public async Task<ProductsQuery> Delete(ProductsDeleteCommand command)
    {
        return await _mediator.Send(command);
    }
}