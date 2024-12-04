using Microsoft.EntityFrameworkCore;

namespace KimHien
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
