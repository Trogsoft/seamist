using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trogsoft.SeaMist.Core.Data
{
    public class SeaMistDbContext<TUser, TRole, TKey> : IdentityDbContext<TUser, TRole, TKey> 
        where TUser: IdentityUser<TKey>
        where TKey: IEquatable<TKey>
        where TRole: IdentityRole<TKey>
    {
        public DbSet<SeaMistContent> SeaMistContent => Set<SeaMistContent>();
        public DbSet<SeaMistContentVersion> SeaMistContentVersions => Set<SeaMistContentVersion>();
        public DbSet<SeaMistContentCollection> SeaMistContentCollections => Set<SeaMistContentCollection>();
        public DbSet<SeaMistTag> SeaMistTags => Set<SeaMistTag>();
        public DbSet<SeaMistContentTag> SeaMistContentTags => Set<SeaMistContentTag>();
    }

    public class SeaMistDbContext<TUser> : SeaMistDbContext<TUser, IdentityRole<Guid>, Guid>
        where TUser : IdentityUser<Guid>
    {
    }

    public class SeaMistDbContext : SeaMistDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
    }

}
