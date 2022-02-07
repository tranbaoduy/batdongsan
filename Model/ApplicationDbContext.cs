using Microsoft.EntityFrameworkCore;

namespace batdongsan.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions opt) : base(opt)
        {

        }
    }
}