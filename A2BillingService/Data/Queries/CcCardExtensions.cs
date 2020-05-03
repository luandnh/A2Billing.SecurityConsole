using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCardExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcCard> ByCreationdate(this IQueryable<A2BillingService.Data.Entities.CcCard> queryable, DateTime creationdate)
        {
            return queryable.Where(q => q.Creationdate == creationdate);
        }

        public static A2BillingService.Data.Entities.CcCard GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCard> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCard> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCard> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCard> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCard> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCard>(task);
        }

        public static A2BillingService.Data.Entities.CcCard GetByUseralias(this IQueryable<A2BillingService.Data.Entities.CcCard> queryable, string useralias)
        {
            return queryable.FirstOrDefault(q => q.Useralias == useralias);
        }

        public static Task<A2BillingService.Data.Entities.CcCard> GetByUseraliasAsync(this IQueryable<A2BillingService.Data.Entities.CcCard> queryable, string useralias)
        {
            return queryable.FirstOrDefaultAsync(q => q.Useralias == useralias);
        }

        public static A2BillingService.Data.Entities.CcCard GetByUsername(this IQueryable<A2BillingService.Data.Entities.CcCard> queryable, string username)
        {
            return queryable.FirstOrDefault(q => q.Username == username);
        }

        public static Task<A2BillingService.Data.Entities.CcCard> GetByUsernameAsync(this IQueryable<A2BillingService.Data.Entities.CcCard> queryable, string username)
        {
            return queryable.FirstOrDefaultAsync(q => q.Username == username);
        }

        #endregion

    }
}
