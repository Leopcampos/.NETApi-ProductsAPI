using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Application.Models.Commands;
using ProductsAPI.Application.Models.Queries;

namespace ProductsAPI.Services.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ProductsQuery), 201)]
    public IActionResult Post([FromBody] ProductsCreateCommand command)
    {
        return Ok();
    }

    [HttpPut]
    [ProducesResponseType(typeof(ProductsQuery), 200)]
    public IActionResult Put([FromBody] ProductsUpdateCommand command)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(ProductsQuery), 200)]
    public IActionResult Delete(Guid id)
    {
        return Ok();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ProductsQuery>), 200)]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ProductsQuery), 200)]
    public IActionResult Get(Guid? id)
    {
        return Ok();
    }
}