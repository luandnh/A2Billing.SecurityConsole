using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcConfigurationExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcConfiguration GetByKey(this IQueryable<A2BillingService.Data.Entities.CcConfiguration> queryable, int configurationId)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcConfiguration> dbSet)
                return dbSet.Find(configurationId);

            return queryable.FirstOrDefault(q => q.ConfigurationId == configurationId);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcConfiguration> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcConfiguration> queryable, int configurationId)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcConfiguration> dbSet)
                return dbSet.FindAsync(configurationId);

            var task = queryable.FirstOrDefaultAsync(q => q.ConfigurationId == configurationId);
            return new ValueTask<A2BillingService.Data.Entities.CcConfiguration>(task);
        }

        #endregion

    }
}
