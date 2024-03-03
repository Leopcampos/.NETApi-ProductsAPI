using MediatR;
using ProductsAPI.Application.Models.Queries;

namespace ProductsAPI.Application.Models.Commands;

/// <summary>
/// Modelo de dados para o serviço de exclusão de produto
/// </summary>
public class ProductsDeleteCommand : IRequest<ProductsQuery>
{
    public Guid? Id { get; set; }
}