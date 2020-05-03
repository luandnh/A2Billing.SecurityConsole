using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCampaignconfCardgroupExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCampaignconfCardgroup GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCampaignconfCardgroup> queryable, int idCampaignConfig, int idCardGroup)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCampaignconfCardgroup> dbSet)
                return dbSet.Find(idCampaignConfig, idCardGroup);

            return queryable.FirstOrDefault(q => q.IdCampaignConfig == idCampaignConfig
                && q.IdCardGroup == idCardGroup);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCampaignconfCardgroup> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCampaignconfCardgroup> queryable, int idCampaignConfig, int idCardGroup)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCampaignconfCardgroup> dbSet)
                return dbSet.FindAsync(idCampaignConfig, idCardGroup);

            var task = queryable.FirstOrDefaultAsync(q => q.IdCampaignConfig == idCampaignConfig
                && q.IdCardGroup == idCardGroup);
            return new ValueTask<A2BillingService.Data.Entities.CcCampaignconfCardgroup>(task);
        }

        #endregion

    }
}
