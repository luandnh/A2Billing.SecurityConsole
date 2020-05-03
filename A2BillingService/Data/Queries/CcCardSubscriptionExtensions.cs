using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCardSubscriptionExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCardSubscription GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCardSubscription> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCardSubscription> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCardSubscription> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCardSubscription> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCardSubscription> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCardSubscription>(task);
        }

        #endregion

    }
}
