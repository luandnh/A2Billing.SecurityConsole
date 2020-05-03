using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcTimezoneExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcTimezone GetByKey(this IQueryable<A2BillingService.Data.Entities.CcTimezone> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTimezone> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcTimezone> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcTimezone> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTimezone> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcTimezone>(task);
        }

        #endregion

    }
}
