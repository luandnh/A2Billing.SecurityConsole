using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcAgentSignupExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcAgentSignup GetByCode(this IQueryable<A2BillingService.Data.Entities.CcAgentSignup> queryable, string code)
        {
            return queryable.FirstOrDefault(q => q.Code == code);
        }

        public static Task<A2BillingService.Data.Entities.CcAgentSignup> GetByCodeAsync(this IQueryable<A2BillingService.Data.Entities.CcAgentSignup> queryable, string code)
        {
            return queryable.FirstOrDefaultAsync(q => q.Code == code);
        }

        public static A2BillingService.Data.Entities.CcAgentSignup GetByKey(this IQueryable<A2BillingService.Data.Entities.CcAgentSignup> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcAgentSignup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcAgentSignup> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcAgentSignup> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcAgentSignup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcAgentSignup>(task);
        }

        #endregion

    }
}
