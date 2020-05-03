using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCardgroupServiceExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCardgroupService GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCardgroupService> queryable, int idCardGroup, int idService)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCardgroupService> dbSet)
                return dbSet.Find(idCardGroup, idService);

            return queryable.FirstOrDefault(q => q.IdCardGroup == idCardGroup
                && q.IdService == idService);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCardgroupService> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCardgroupService> queryable, int idCardGroup, int idService)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCardgroupService> dbSet)
                return dbSet.FindAsync(idCardGroup, idService);

            var task = queryable.FirstOrDefaultAsync(q => q.IdCardGroup == idCardGroup
                && q.IdService == idService);
            return new ValueTask<A2BillingService.Data.Entities.CcCardgroupService>(task);
        }

        #endregion

    }
}
