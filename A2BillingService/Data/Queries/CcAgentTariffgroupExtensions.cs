using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcAgentTariffgroupExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcAgentTariffgroup GetByKey(this IQueryable<A2BillingService.Data.Entities.CcAgentTariffgroup> queryable, long idAgent, int idTariffgroup)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcAgentTariffgroup> dbSet)
                return dbSet.Find(idAgent, idTariffgroup);

            return queryable.FirstOrDefault(q => q.IdAgent == idAgent
                && q.IdTariffgroup == idTariffgroup);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcAgentTariffgroup> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcAgentTariffgroup> queryable, long idAgent, int idTariffgroup)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcAgentTariffgroup> dbSet)
                return dbSet.FindAsync(idAgent, idTariffgroup);

            var task = queryable.FirstOrDefaultAsync(q => q.IdAgent == idAgent
                && q.IdTariffgroup == idTariffgroup);
            return new ValueTask<A2BillingService.Data.Entities.CcAgentTariffgroup>(task);
        }

        #endregion

    }
}
