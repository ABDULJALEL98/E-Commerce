using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data;

public class EcommerceDbContext:DbContext
{
    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
    {
        
    }
}
