using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcUiAuthenExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcUiAuthen GetByLogin(this IQueryable<A2BillingService.Data.Entities.CcUiAuthen> queryable, string login)
        {
            return queryable.FirstOrDefault(q => q.Login == login);
        }

        public static Task<A2BillingService.Data.Entities.CcUiAuthen> GetByLoginAsync(this IQueryable<A2BillingService.Data.Entities.CcUiAuthen> queryable, string login)
        {
            return queryable.FirstOrDefaultAsync(q => q.Login == login);
        }

        public static A2BillingService.Data.Entities.CcUiAuthen GetByKey(this IQueryable<A2BillingService.Data.Entities.CcUiAuthen> queryable, long userid)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcUiAuthen> dbSet)
                return dbSet.Find(userid);

            return queryable.FirstOrDefault(q => q.Userid == userid);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcUiAuthen> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcUiAuthen> queryable, long userid)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcUiAuthen> dbSet)
                return dbSet.FindAsync(userid);

            var task = queryable.FirstOrDefaultAsync(q => q.Userid == userid);
            return new ValueTask<A2BillingService.Data.Entities.CcUiAuthen>(task);
        }

        #endregion

    }
}
