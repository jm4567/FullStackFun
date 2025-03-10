using Microsoft.EntityFrameworkCore;

namespace FullStackFun.Data;

public class FoodDbContext: DbContext //inherit from general db context file 
{
    public FoodDbContext(DbContextOptions<FoodDbContext> options) : base(options)
    {
        
    }
    public DbSet<MarriottFood> Foods { get; set; }
    
}