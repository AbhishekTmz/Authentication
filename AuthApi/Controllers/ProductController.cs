using AuthApi.Database;
using AuthLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers;
[Authorize]
[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly DBCtx _DbContext;

    public ProductController(ILogger<ProductController> logger, DBCtx DbContext)
    {
        _DbContext = DbContext;
    }
[HttpGet]
public IActionResult GetAllProducts(){
    
}



}

