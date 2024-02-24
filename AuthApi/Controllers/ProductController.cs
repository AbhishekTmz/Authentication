using AuthApi.Database;
using AuthLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers;
[Authorize]
[ApiController]
[Route("[controller]/[action]")]
public class ProductController : ControllerBase
{
    private readonly DBCtx _DbContext;

    public ProductController(ILogger<ProductController> logger, DBCtx DbContext)
    {
        _DbContext = DbContext;
    }
[HttpGet]
public IActionResult GetAllProducts()
{
    return Ok(_DbContext.Products);
}
[HttpGet]
public IActionResult GetProductsByCategory(int categoryId)
{
    var productsInCategory = _DbContext.Products.Where(p => p.ProdCategory.Id == categoryId).ToList();
    return Ok(productsInCategory);
}
[HttpPost]
public IActionResult AddProduct(Product product){
    if(product == null)
    {
        return BadRequest();
    }
    _DbContext.Products.Add(product);
    _DbContext.SaveChanges();
    return Ok(product);
}
}




