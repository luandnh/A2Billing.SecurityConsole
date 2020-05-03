using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcChargeExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcCharge> ByCreationdate(this IQueryable<A2BillingService.Data.Entities.CcCharge> queryable, DateTime creationdate)
        {
            return queryable.Where(q => q.Creationdate == creationdate);
        }

        public static A2BillingService.Data.Entities.CcCharge GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCharge> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCharge> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCharge> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCharge> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCharge> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCharge>(task);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcCharge> ByIdCcCard(this IQueryable<A2BillingService.Data.Entities.CcCharge> queryable, long idCcCard)
        {
            return queryable.Where(q => q.IdCcCard == idCcCard);
        }

        #endregion

    }
}
