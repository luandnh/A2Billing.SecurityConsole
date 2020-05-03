using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcServerManagerExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcServerManager GetByKey(this IQueryable<A2BillingService.Data.Entities.CcServerManager> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcServerManager> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcServerManager> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcServerManager> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcServerManager> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcServerManager>(task);
        }

        #endregion

    }
}
