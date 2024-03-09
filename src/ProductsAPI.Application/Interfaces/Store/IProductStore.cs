using ProductsAPI.Application.Models.Queries;

namespace ProductsAPI.Application.Interfaces.Store;

public interface IProductStore
{
    void Add(ProductsDTO item);
    void Update(ProductsDTO item);
    void Delete(Guid id);
    List<ProductsDTO> GetAll();
    ProductsDTO GetById(Guid id);
}