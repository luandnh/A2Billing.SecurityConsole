using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcSystemLogExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcSystemLog GetByKey(this IQueryable<A2BillingService.Data.Entities.CcSystemLog> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcSystemLog> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcSystemLog> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcSystemLog> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcSystemLog> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcSystemLog>(task);
        }

        #endregion

    }
}
