using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcTrunkExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcTrunk GetByKey(this IQueryable<A2BillingService.Data.Entities.CcTrunk> queryable, int idTrunk)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTrunk> dbSet)
                return dbSet.Find(idTrunk);

            return queryable.FirstOrDefault(q => q.IdTrunk == idTrunk);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcTrunk> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcTrunk> queryable, int idTrunk)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTrunk> dbSet)
                return dbSet.FindAsync(idTrunk);

            var task = queryable.FirstOrDefaultAsync(q => q.IdTrunk == idTrunk);
            return new ValueTask<A2BillingService.Data.Entities.CcTrunk>(task);
        }

        #endregion

    }
}
