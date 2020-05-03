using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCurrenciesExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCurrencies GetByCurrency(this IQueryable<A2BillingService.Data.Entities.CcCurrencies> queryable, string currency)
        {
            return queryable.FirstOrDefault(q => q.Currency == currency);
        }

        public static Task<A2BillingService.Data.Entities.CcCurrencies> GetByCurrencyAsync(this IQueryable<A2BillingService.Data.Entities.CcCurrencies> queryable, string currency)
        {
            return queryable.FirstOrDefaultAsync(q => q.Currency == currency);
        }

        public static A2BillingService.Data.Entities.CcCurrencies GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCurrencies> queryable, ushort id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCurrencies> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCurrencies> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCurrencies> queryable, ushort id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCurrencies> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCurrencies>(task);
        }

        #endregion

    }
}
