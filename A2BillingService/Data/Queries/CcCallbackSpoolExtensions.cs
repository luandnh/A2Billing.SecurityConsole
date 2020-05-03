using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCallbackSpoolExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCallbackSpool GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCallbackSpool> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCallbackSpool> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCallbackSpool> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCallbackSpool> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCallbackSpool> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCallbackSpool>(task);
        }

        public static A2BillingService.Data.Entities.CcCallbackSpool GetByUniqueid(this IQueryable<A2BillingService.Data.Entities.CcCallbackSpool> queryable, string uniqueid)
        {
            return queryable.FirstOrDefault(q => (q.Uniqueid == uniqueid || (uniqueid == null && q.Uniqueid == null)));
        }

        public static Task<A2BillingService.Data.Entities.CcCallbackSpool> GetByUniqueidAsync(this IQueryable<A2BillingService.Data.Entities.CcCallbackSpool> queryable, string uniqueid)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Uniqueid == uniqueid || (uniqueid == null && q.Uniqueid == null)));
        }

        #endregion

    }
}
