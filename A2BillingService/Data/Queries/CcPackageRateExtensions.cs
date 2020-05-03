using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcPackageRateExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcPackageRate GetByKey(this IQueryable<A2BillingService.Data.Entities.CcPackageRate> queryable, int packageId, int rateId)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPackageRate> dbSet)
                return dbSet.Find(packageId, rateId);

            return queryable.FirstOrDefault(q => q.PackageId == packageId
                && q.RateId == rateId);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcPackageRate> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcPackageRate> queryable, int packageId, int rateId)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPackageRate> dbSet)
                return dbSet.FindAsync(packageId, rateId);

            var task = queryable.FirstOrDefaultAsync(q => q.PackageId == packageId
                && q.RateId == rateId);
            return new ValueTask<A2BillingService.Data.Entities.CcPackageRate>(task);
        }

        #endregion

    }
}
