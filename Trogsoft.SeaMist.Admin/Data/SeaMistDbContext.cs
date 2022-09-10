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
        public SeaMistDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SeaMistContent<TUser, TKey>> SeaMistContent => Set<SeaMistContent<TUser, TKey>>();
        public DbSet<SeaMistContentVersion<TUser, TKey>> SeaMistContentVersions => Set<SeaMistContentVersion<TUser, TKey>>();
        public DbSet<SeaMistContentCollection<TUser, TKey>> SeaMistContentCollections => Set<SeaMistContentCollection<TUser, TKey>>();
        //public DbSet<SeaMistTag> SeaMistTags => Set<SeaMistTag>();
        //public DbSet<SeaMistContentTag> SeaMistContentTags => Set<SeaMistContentTag>();
        public DbSet<SeaMistCollectionContent<TUser, TKey>> SeaMistCollectionContent => Set<SeaMistCollectionContent<TUser, TKey>>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<SeaMistCollectionContent<TUser, TKey>>(smc =>
            {
                smc.HasKey(x => new { x.CollectionId, x.ContentId });
                smc.HasOne(x => x.Content).WithMany(x => x.Collections).HasForeignKey(x => x.ContentId).OnDelete(DeleteBehavior.Restrict);
                smc.HasOne(x => x.Collection).WithMany(x => x.Content).HasForeignKey(x => x.CollectionId).OnDelete(DeleteBehavior.Restrict);
            });

        }

    }

    public class SeaMistDbContext<TUser> : SeaMistDbContext<TUser, IdentityRole<Guid>, Guid>
        where TUser : IdentityUser<Guid>
    {
        public SeaMistDbContext(DbContextOptions options) : base(options)
        {
        }
    }

    public class SeaMistDbContext : SeaMistDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public SeaMistDbContext(DbContextOptions options) : base(options)
        {
        }
    }

}
