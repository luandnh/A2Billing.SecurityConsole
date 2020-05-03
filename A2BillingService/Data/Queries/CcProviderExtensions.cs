using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcProviderExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcProvider GetByKey(this IQueryable<A2BillingService.Data.Entities.CcProvider> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcProvider> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcProvider> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcProvider> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcProvider> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcProvider>(task);
        }

        public static A2BillingService.Data.Entities.CcProvider GetByProviderName(this IQueryable<A2BillingService.Data.Entities.CcProvider> queryable, string providerName)
        {
            return queryable.FirstOrDefault(q => q.ProviderName == providerName);
        }

        public static Task<A2BillingService.Data.Entities.CcProvider> GetByProviderNameAsync(this IQueryable<A2BillingService.Data.Entities.CcProvider> queryable, string providerName)
        {
            return queryable.FirstOrDefaultAsync(q => q.ProviderName == providerName);
        }

        #endregion

    }
}
