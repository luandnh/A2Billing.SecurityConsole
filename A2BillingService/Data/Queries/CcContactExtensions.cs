using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcContactExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcContact> ByCardId(this IQueryable<A2BillingService.Data.Entities.CcContact> queryable, long cardId)
        {
            return queryable.Where(q => q.CardId == cardId);
        }

        public static A2BillingService.Data.Entities.CcContact GetByKey(this IQueryable<A2BillingService.Data.Entities.CcContact> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcContact> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcContact> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcContact> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcContact> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcContact>(task);
        }

        #endregion

    }
}
