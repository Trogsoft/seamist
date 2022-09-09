using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trogsoft.SeaMist.Core.Data;

namespace Trogsoft.SeaMist.Demo.Mvc.Data
{
    public class DemoDb : SeaMistDbContext
    {

        public DbSet<DemoData> DemoDataTable => Set<DemoData>();

    }
}
