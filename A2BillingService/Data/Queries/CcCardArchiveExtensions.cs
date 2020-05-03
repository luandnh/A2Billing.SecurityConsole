using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCardArchiveExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcCardArchive> ByCreationdate(this IQueryable<A2BillingService.Data.Entities.CcCardArchive> queryable, DateTime creationdate)
        {
            return queryable.Where(q => q.Creationdate == creationdate);
        }

        public static A2BillingService.Data.Entities.CcCardArchive GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCardArchive> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCardArchive> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCardArchive> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCardArchive> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCardArchive> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCardArchive>(task);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcCardArchive> ByUsername(this IQueryable<A2BillingService.Data.Entities.CcCardArchive> queryable, string username)
        {
            return queryable.Where(q => q.Username == username);
        }

        #endregion

    }
}
