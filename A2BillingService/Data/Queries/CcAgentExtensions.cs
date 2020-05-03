using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcAgentExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcAgent GetByKey(this IQueryable<A2BillingService.Data.Entities.CcAgent> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcAgent> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcAgent> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcAgent> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcAgent> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcAgent>(task);
        }

        public static A2BillingService.Data.Entities.CcAgent GetByLogin(this IQueryable<A2BillingService.Data.Entities.CcAgent> queryable, string login)
        {
            return queryable.FirstOrDefault(q => q.Login == login);
        }

        public static Task<A2BillingService.Data.Entities.CcAgent> GetByLoginAsync(this IQueryable<A2BillingService.Data.Entities.CcAgent> queryable, string login)
        {
            return queryable.FirstOrDefaultAsync(q => q.Login == login);
        }

        #endregion

    }
}
