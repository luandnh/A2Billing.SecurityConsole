using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcDidExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcDid GetByDid(this IQueryable<A2BillingService.Data.Entities.CcDid> queryable, string did)
        {
            return queryable.FirstOrDefault(q => q.Did == did);
        }

        public static Task<A2BillingService.Data.Entities.CcDid> GetByDidAsync(this IQueryable<A2BillingService.Data.Entities.CcDid> queryable, string did)
        {
            return queryable.FirstOrDefaultAsync(q => q.Did == did);
        }

        public static A2BillingService.Data.Entities.CcDid GetByKey(this IQueryable<A2BillingService.Data.Entities.CcDid> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcDid> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcDid> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcDid> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcDid> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcDid>(task);
        }

        #endregion

    }
}
