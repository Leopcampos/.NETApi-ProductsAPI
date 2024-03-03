using MediatR;
using ProductsAPI.Application.Handlers.Notifications;
using ProductsAPI.Application.Models.Commands;
using ProductsAPI.Application.Models.Queries;
using System.Diagnostics;

namespace ProductsAPI.Application.Handlers.Requests;

/// <summary>
/// Componente para 'escutar' as requisições do tipo COMMAND de produtos
/// </summary>
public class ProductsRequestHandler :
    IRequestHandler<ProductsCreateCommand, ProductsQuery>,
    IRequestHandler<ProductsUpdateCommand, ProductsQuery>,
    IRequestHandler<ProductsDeleteCommand, ProductsQuery>
{
    private readonly IMediator? _mediator;

    public ProductsRequestHandler(IMediator? mediator)
        => _mediator = mediator;

    public async Task<ProductsQuery> Handle(ProductsCreateCommand request, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Cadastrando Produto no domínio!");

        var query = new ProductsQuery
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Price = request.Price,
            Quantity = request.Quantity,
            CreationDate = DateTime.Now,
            LastModifiedDate = DateTime.Now
        };

        await _mediator.Publish(new ProductsNotification
        {
            Action = ActionNotification.Created,
            ProductsQuery = query
        });

        return query;
    }

    public async Task<ProductsQuery> Handle(ProductsUpdateCommand request, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Atualizando Produto no domínio!");

        var query = new ProductsQuery
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Price = request.Price,
            Quantity = request.Quantity,
            CreationDate = DateTime.Now,
            LastModifiedDate = DateTime.Now
        };

        await _mediator.Publish(new ProductsNotification
        {
            Action = ActionNotification.Updated,
            ProductsQuery = query
        });

        return query;
    }

    public async Task<ProductsQuery> Handle(ProductsDeleteCommand request, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Excluindo Produto no domínio!");

        var query = new ProductsQuery
        {
            Id = Guid.NewGuid(),
        };

        await _mediator.Publish(new ProductsNotification
        {
            Action = ActionNotification.Deleted,
            ProductsQuery = query
        });

        return query;
    }
}