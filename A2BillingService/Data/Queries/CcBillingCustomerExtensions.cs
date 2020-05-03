using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcBillingCustomerExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcBillingCustomer GetByKey(this IQueryable<A2BillingService.Data.Entities.CcBillingCustomer> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcBillingCustomer> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcBillingCustomer> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcBillingCustomer> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcBillingCustomer> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcBillingCustomer>(task);
        }

        #endregion

    }
}
