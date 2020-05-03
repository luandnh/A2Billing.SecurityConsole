using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcLogrefillExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcLogrefill GetByKey(this IQueryable<A2BillingService.Data.Entities.CcLogrefill> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcLogrefill> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcLogrefill> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcLogrefill> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcLogrefill> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcLogrefill>(task);
        }

        #endregion

    }
}
