using Microsoft.EntityFrameworkCore;
using AuthLib;

namespace AuthApi.Database;

public class DBCtx : DbContext
{
    public DBCtx(DbContextOptions<DBCtx> options) : base(options)
    { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ShoppingCartModel> ShoppingCarts{get;set;}
}