using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCampaignExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCampaign GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCampaign> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCampaign> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCampaign> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCampaign> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCampaign> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCampaign>(task);
        }

        public static A2BillingService.Data.Entities.CcCampaign GetByName(this IQueryable<A2BillingService.Data.Entities.CcCampaign> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<A2BillingService.Data.Entities.CcCampaign> GetByNameAsync(this IQueryable<A2BillingService.Data.Entities.CcCampaign> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        #endregion

    }
}
