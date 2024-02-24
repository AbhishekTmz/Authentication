using AuthApi.Database;
using AuthLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Controllers;
[Authorize]
[ApiController]
[Route("[controller]/[action]")]
public class ShoppingController : ControllerBase
{
  private readonly DBCtx _DbContext;

    public ShoppingController(ILogger<ShoppingController> logger, DBCtx DbContext)
    {
        _DbContext = DbContext;
    }

[HttpGet]
    public async Task<List<Product>?> GetUserProduct()
    {
        var user = User.Identity?.Name ?? string.Empty;

        var Shoppingcart = await _DbContext.ShoppingCarts.Where(Shoppingcart => Shoppingcart.User == user).FirstOrDefaultAsync();

        return Shoppingcart?.ProductList;
    }
  [HttpPost]
    public async Task<IActionResult> DeleteUserProduct(int id)
    {
        var user = User.Identity?.Name ?? string.Empty;

        var Shoppingcart = await _DbContext.ShoppingCarts.Where(Shoppingcart => Shoppingcart.User == user).FirstOrDefaultAsync();

        Shoppingcart?.ProductList.RemoveAll(product => product.Id == id);

        await _DbContext.SaveChangesAsync();

        return Ok();
    }
    [HttpPost]
    public async Task<IActionResult> CreateUserProduct(int id)
    {
        var prod = await _DbContext.Products.FindAsync(id);
        if (prod == null){
return BadRequest();
        }
        var user = User.Identity?.Name ?? string.Empty;

        var Shoppingcart = await _DbContext.ShoppingCarts.Where(shopcart => shopcart.User == user).FirstOrDefaultAsync();

        if (Shoppingcart is null)
        {
            _DbContext.Add(new ShoppingCartModel()
            {
                User = user,
                ProductList = [new Product()
                {Id = id}]
            });
        }
        else
        {
            Shoppingcart.ProductList.Add(new Product() { Id = id });
        }

        await _DbContext.SaveChangesAsync();

        return Ok();
}

}

