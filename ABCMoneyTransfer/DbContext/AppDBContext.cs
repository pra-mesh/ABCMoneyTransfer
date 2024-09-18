using ABCMoneyTransfer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ABCMoneyTransfer.DbContext;

public class AppDBContext : IdentityDbContext<Users>
{
    public AppDBContext(DbContextOptions options) : base(options)
    {
    }
}
