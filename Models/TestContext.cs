using Microsoft.EntityFrameworkCore;
namespace projetineo.Models
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
            
        }
        
        public DbSet<Test> Tests { get; set; }
        public DbSet<Todo>  Todos { get; set; }
    }
}