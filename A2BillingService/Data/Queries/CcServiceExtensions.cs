using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcServiceExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcService GetByKey(this IQueryable<A2BillingService.Data.Entities.CcService> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcService> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcService> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcService> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcService> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcService>(task);
        }

        #endregion

    }
}
