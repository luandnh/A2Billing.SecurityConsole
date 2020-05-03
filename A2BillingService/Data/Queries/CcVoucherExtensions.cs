using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcVoucherExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcVoucher GetByKey(this IQueryable<A2BillingService.Data.Entities.CcVoucher> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcVoucher> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcVoucher> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcVoucher> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcVoucher> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcVoucher>(task);
        }

        public static A2BillingService.Data.Entities.CcVoucher GetByVoucher(this IQueryable<A2BillingService.Data.Entities.CcVoucher> queryable, string voucher)
        {
            return queryable.FirstOrDefault(q => q.Voucher == voucher);
        }

        public static Task<A2BillingService.Data.Entities.CcVoucher> GetByVoucherAsync(this IQueryable<A2BillingService.Data.Entities.CcVoucher> queryable, string voucher)
        {
            return queryable.FirstOrDefaultAsync(q => q.Voucher == voucher);
        }

        #endregion

    }
}
