using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcIso639Extensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcIso639 GetByKey(this IQueryable<A2BillingService.Data.Entities.CcIso639> queryable, string code)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcIso639> dbSet)
                return dbSet.Find(code);

            return queryable.FirstOrDefault(q => q.Code == code);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcIso639> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcIso639> queryable, string code)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcIso639> dbSet)
                return dbSet.FindAsync(code);

            var task = queryable.FirstOrDefaultAsync(q => q.Code == code);
            return new ValueTask<A2BillingService.Data.Entities.CcIso639>(task);
        }

        public static A2BillingService.Data.Entities.CcIso639 GetByName(this IQueryable<A2BillingService.Data.Entities.CcIso639> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<A2BillingService.Data.Entities.CcIso639> GetByNameAsync(this IQueryable<A2BillingService.Data.Entities.CcIso639> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        #endregion

    }
}
