using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcConfigGroupExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcConfigGroup GetByGroupTitle(this IQueryable<A2BillingService.Data.Entities.CcConfigGroup> queryable, string groupTitle)
        {
            return queryable.FirstOrDefault(q => q.GroupTitle == groupTitle);
        }

        public static Task<A2BillingService.Data.Entities.CcConfigGroup> GetByGroupTitleAsync(this IQueryable<A2BillingService.Data.Entities.CcConfigGroup> queryable, string groupTitle)
        {
            return queryable.FirstOrDefaultAsync(q => q.GroupTitle == groupTitle);
        }

        public static A2BillingService.Data.Entities.CcConfigGroup GetByKey(this IQueryable<A2BillingService.Data.Entities.CcConfigGroup> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcConfigGroup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcConfigGroup> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcConfigGroup> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcConfigGroup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcConfigGroup>(task);
        }

        #endregion

    }
}
