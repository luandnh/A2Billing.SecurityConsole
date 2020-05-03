using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcSpeeddialExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcSpeeddial GetByKey(this IQueryable<A2BillingService.Data.Entities.CcSpeeddial> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcSpeeddial> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcSpeeddial> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcSpeeddial> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcSpeeddial> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcSpeeddial>(task);
        }

        public static A2BillingService.Data.Entities.CcSpeeddial GetByIdCcCardSpeeddial(this IQueryable<A2BillingService.Data.Entities.CcSpeeddial> queryable, long idCcCard, int? speeddial)
        {
            return queryable.FirstOrDefault(q => q.IdCcCard == idCcCard
                && (q.Speeddial == speeddial || (speeddial == null && q.Speeddial == null)));
        }

        public static Task<A2BillingService.Data.Entities.CcSpeeddial> GetByIdCcCardSpeeddialAsync(this IQueryable<A2BillingService.Data.Entities.CcSpeeddial> queryable, long idCcCard, int? speeddial)
        {
            return queryable.FirstOrDefaultAsync(q => q.IdCcCard == idCcCard
                && (q.Speeddial == speeddial || (speeddial == null && q.Speeddial == null)));
        }

        #endregion

    }
}
