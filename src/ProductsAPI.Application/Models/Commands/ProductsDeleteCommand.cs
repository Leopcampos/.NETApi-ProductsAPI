namespace ProductsAPI.Application.Models.Commands;

/// <summary>
/// Modelo de dados para o serviço de exclusão de produto
/// </summary>
public class ProductsDeleteCommand
{
    public Guid? Id { get; set; }
}