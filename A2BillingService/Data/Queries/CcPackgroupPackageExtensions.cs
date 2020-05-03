using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcPackgroupPackageExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcPackgroupPackage GetByKey(this IQueryable<A2BillingService.Data.Entities.CcPackgroupPackage> queryable, int packagegroupId, int packageId)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPackgroupPackage> dbSet)
                return dbSet.Find(packagegroupId, packageId);

            return queryable.FirstOrDefault(q => q.PackagegroupId == packagegroupId
                && q.PackageId == packageId);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcPackgroupPackage> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcPackgroupPackage> queryable, int packagegroupId, int packageId)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPackgroupPackage> dbSet)
                return dbSet.FindAsync(packagegroupId, packageId);

            var task = queryable.FirstOrDefaultAsync(q => q.PackagegroupId == packagegroupId
                && q.PackageId == packageId);
            return new ValueTask<A2BillingService.Data.Entities.CcPackgroupPackage>(task);
        }

        #endregion

    }
}
