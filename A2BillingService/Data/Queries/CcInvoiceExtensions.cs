using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcInvoiceExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcInvoice GetByKey(this IQueryable<A2BillingService.Data.Entities.CcInvoice> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcInvoice> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcInvoice> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcInvoice> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcInvoice> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcInvoice>(task);
        }

        public static A2BillingService.Data.Entities.CcInvoice GetByReference(this IQueryable<A2BillingService.Data.Entities.CcInvoice> queryable, string reference)
        {
            return queryable.FirstOrDefault(q => (q.Reference == reference || (reference == null && q.Reference == null)));
        }

        public static Task<A2BillingService.Data.Entities.CcInvoice> GetByReferenceAsync(this IQueryable<A2BillingService.Data.Entities.CcInvoice> queryable, string reference)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Reference == reference || (reference == null && q.Reference == null)));
        }

        #endregion

    }
}
