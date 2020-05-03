using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcInvoicePaymentExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcInvoicePayment GetByKey(this IQueryable<A2BillingService.Data.Entities.CcInvoicePayment> queryable, long idInvoice, long idPayment)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcInvoicePayment> dbSet)
                return dbSet.Find(idInvoice, idPayment);

            return queryable.FirstOrDefault(q => q.IdInvoice == idInvoice
                && q.IdPayment == idPayment);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcInvoicePayment> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcInvoicePayment> queryable, long idInvoice, long idPayment)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcInvoicePayment> dbSet)
                return dbSet.FindAsync(idInvoice, idPayment);

            var task = queryable.FirstOrDefaultAsync(q => q.IdInvoice == idInvoice
                && q.IdPayment == idPayment);
            return new ValueTask<A2BillingService.Data.Entities.CcInvoicePayment>(task);
        }

        #endregion

    }
}
