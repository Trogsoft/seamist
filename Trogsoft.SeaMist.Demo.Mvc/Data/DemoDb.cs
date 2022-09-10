using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trogsoft.SeaMist.Core.Data;

namespace Trogsoft.SeaMist.Demo.Mvc.Data
{
    public class DemoDb : SeaMistDbContext<DemoUser, DemoRole, Guid>
    {
        public DemoDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DemoData> DemoDataTable => Set<DemoData>();

    }
}
