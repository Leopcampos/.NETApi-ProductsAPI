using MongoDB.Driver;
using ProductsAPI.Application.Interfaces.Store;
using ProductsAPI.Application.Models.Queries;
using ProductsAPI.Infra.Data.MongoDB.Contexts;

namespace ProductsAPI.Infra.Data.MongoDB.Stores;

public class ProductStore : IProductStore
{
    private readonly MongoDBContext _mongoDBContext;

    public ProductStore(MongoDBContext mongoDBContext) 
        => _mongoDBContext = mongoDBContext;

    public void Add(ProductsDTO item) 
        => _mongoDBContext?.Products.InsertOne(item);

    public void Update(ProductsDTO item)
    {
        var filter = Builders<ProductsDTO>.Filter.Eq(p => p.Id, item.Id);
        _mongoDBContext?.Products.ReplaceOne(filter, item);
    }

    public void Delete(Guid id)
    {
        var filter = Builders<ProductsDTO>.Filter.Eq(p => p.Id, id);
        _mongoDBContext?.Products.DeleteOne(filter);
    }

    public List<ProductsDTO> GetAll()
    {
        var filter = Builders<ProductsDTO>.Filter.Where(p => true);
        return _mongoDBContext?.Products.Find(filter).ToList();
    }

    public ProductsDTO GetById(Guid id)
    {
        var filter = Builders<ProductsDTO>.Filter.Eq(p => p.Id, id);
        return _mongoDBContext?.Products.Find(filter).FirstOrDefault();
    }
}