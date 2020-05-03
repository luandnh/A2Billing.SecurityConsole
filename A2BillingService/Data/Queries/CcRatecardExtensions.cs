using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcRatecardExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcRatecard> ByDialprefix(this IQueryable<A2BillingService.Data.Entities.CcRatecard> queryable, string dialprefix)
        {
            return queryable.Where(q => q.Dialprefix == dialprefix);
        }

        public static A2BillingService.Data.Entities.CcRatecard GetByKey(this IQueryable<A2BillingService.Data.Entities.CcRatecard> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcRatecard> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcRatecard> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcRatecard> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcRatecard> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcRatecard>(task);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcRatecard> ByIdtariffplan(this IQueryable<A2BillingService.Data.Entities.CcRatecard> queryable, int idtariffplan)
        {
            return queryable.Where(q => q.Idtariffplan == idtariffplan);
        }

        #endregion

    }
}
