using AuthApi.Database;
using AuthLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Controllers;
[Authorize]
[ApiController]
[Route("[controller]")]
public class ShoppingController : ControllerBase
{
  private readonly DBCtx _DbContext;

    public ShoppingController(ILogger<ShoppingController> logger, DBCtx DbContext)
    {
        _DbContext = DbContext;
    }

[HttpGet]
    public async Task<List<Product>?> GetUsersProducts()
    {
        var user = User.Identity?.Name ?? string.Empty;

        var cart = await _DbContext.ShoppingCarts.Where(cart => cart.User == user).FirstOrDefaultAsync();

        return cart?.ProductList;
    }
  [HttpPost]
    public async Task<IActionResult> DeleteUsersProduct(int id)
    {
        var user = User.Identity?.Name ?? string.Empty;

        var cart = await _DbContext.ShoppingCarts.Where(cart => cart.User == user).FirstOrDefaultAsync();

        cart?.ProductList.RemoveAll(product => product.Id == id);

        await _DbContext.SaveChangesAsync();

        return Ok();
    }
    [HttpPost]
    public async Task<IActionResult> CreateUsersProduct(int id)
    {
        var user = User.Identity?.Name ?? string.Empty;

        var cart = await _DbContext.ShoppingCarts.Where(cart => cart.User == user).FirstOrDefaultAsync();

        if (cart is null)
        {
            _DbContext.Add(new ShoppingCartModel()
            {
                User = user,
                ProductList = [new Product()
                {
                    Id = id
                }]
            });
        }
        else
        {
            cart.ProductList.Add(new Product() { Id = id });
        }

        await _DbContext.SaveChangesAsync();

        return Ok();
}

}

