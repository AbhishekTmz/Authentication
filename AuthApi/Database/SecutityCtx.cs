using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Data;

public class SecurityDBCtx : IdentityDbContext<IdentityUser>
{
    public SecurityDBCtx(DbContextOptions<SecurityDBCtx> options) : base(options)
{}
}
