using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcTariffgroupPlanExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcTariffgroupPlan GetByKey(this IQueryable<A2BillingService.Data.Entities.CcTariffgroupPlan> queryable, int idtariffgroup, int idtariffplan)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTariffgroupPlan> dbSet)
                return dbSet.Find(idtariffgroup, idtariffplan);

            return queryable.FirstOrDefault(q => q.Idtariffgroup == idtariffgroup
                && q.Idtariffplan == idtariffplan);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcTariffgroupPlan> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcTariffgroupPlan> queryable, int idtariffgroup, int idtariffplan)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTariffgroupPlan> dbSet)
                return dbSet.FindAsync(idtariffgroup, idtariffplan);

            var task = queryable.FirstOrDefaultAsync(q => q.Idtariffgroup == idtariffgroup
                && q.Idtariffplan == idtariffplan);
            return new ValueTask<A2BillingService.Data.Entities.CcTariffgroupPlan>(task);
        }

        #endregion

    }
}
