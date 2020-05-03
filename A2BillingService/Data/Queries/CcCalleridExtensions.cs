using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCalleridExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCallerid GetByCid(this IQueryable<A2BillingService.Data.Entities.CcCallerid> queryable, string cid)
        {
            return queryable.FirstOrDefault(q => q.Cid == cid);
        }

        public static Task<A2BillingService.Data.Entities.CcCallerid> GetByCidAsync(this IQueryable<A2BillingService.Data.Entities.CcCallerid> queryable, string cid)
        {
            return queryable.FirstOrDefaultAsync(q => q.Cid == cid);
        }

        public static A2BillingService.Data.Entities.CcCallerid GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCallerid> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCallerid> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCallerid> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCallerid> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCallerid> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCallerid>(task);
        }

        #endregion

    }
}
