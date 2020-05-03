using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcInvoiceConfExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcInvoiceConf GetByKey(this IQueryable<A2BillingService.Data.Entities.CcInvoiceConf> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcInvoiceConf> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcInvoiceConf> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcInvoiceConf> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcInvoiceConf> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcInvoiceConf>(task);
        }

        public static A2BillingService.Data.Entities.CcInvoiceConf GetByKeyVal(this IQueryable<A2BillingService.Data.Entities.CcInvoiceConf> queryable, string keyVal)
        {
            return queryable.FirstOrDefault(q => q.KeyVal == keyVal);
        }

        public static Task<A2BillingService.Data.Entities.CcInvoiceConf> GetByKeyValAsync(this IQueryable<A2BillingService.Data.Entities.CcInvoiceConf> queryable, string keyVal)
        {
            return queryable.FirstOrDefaultAsync(q => q.KeyVal == keyVal);
        }

        #endregion

    }
}
