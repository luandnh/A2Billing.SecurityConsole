using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcPaymentsStatusExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcPaymentsStatus GetByKey(this IQueryable<A2BillingService.Data.Entities.CcPaymentsStatus> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPaymentsStatus> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcPaymentsStatus> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcPaymentsStatus> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPaymentsStatus> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcPaymentsStatus>(task);
        }

        #endregion

    }
}
