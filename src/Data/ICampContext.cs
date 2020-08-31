using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public interface ICampContext : IDisposable
    {
        DbSet<Camp> Camps { get; set; }
        DbSet<Speaker> Speakers { get; set; }
        DbSet<Talk> Talks { get; set; }

        int SaveChanges();
        void MarkAsModified(Camp camp);

        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
