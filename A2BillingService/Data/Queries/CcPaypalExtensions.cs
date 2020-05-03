using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcPaypalExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcPaypal GetByKey(this IQueryable<A2BillingService.Data.Entities.CcPaypal> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPaypal> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcPaypal> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcPaypal> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcPaypal> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcPaypal>(task);
        }

        public static A2BillingService.Data.Entities.CcPaypal GetByTxnId(this IQueryable<A2BillingService.Data.Entities.CcPaypal> queryable, string txnId)
        {
            return queryable.FirstOrDefault(q => (q.TxnId == txnId || (txnId == null && q.TxnId == null)));
        }

        public static Task<A2BillingService.Data.Entities.CcPaypal> GetByTxnIdAsync(this IQueryable<A2BillingService.Data.Entities.CcPaypal> queryable, string txnId)
        {
            return queryable.FirstOrDefaultAsync(q => (q.TxnId == txnId || (txnId == null && q.TxnId == null)));
        }

        #endregion

    }
}
