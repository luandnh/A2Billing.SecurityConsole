using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcPrefixExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcPrefix> ByDestination(this IQueryable<A2BillingService.Data.Entities.CcPrefix> queryable, string destination)
        {
            return queryable.Where(q => q.Destination == destination);
        }

        public static A2BillingService.Data.Entities.CcPrefix GetByKey(this IQueryable<A2BillingService.Data.Entities.CcPrefix> queryable, long prefix)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPrefix> dbSet)
                return dbSet.Find(prefix);

            return queryable.FirstOrDefault(q => q.Prefix == prefix);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcPrefix> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcPrefix> queryable, long prefix)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPrefix> dbSet)
                return dbSet.FindAsync(prefix);

            var task = queryable.FirstOrDefaultAsync(q => q.Prefix == prefix);
            return new ValueTask<A2BillingService.Data.Entities.CcPrefix>(task);
        }

        #endregion

    }
}
