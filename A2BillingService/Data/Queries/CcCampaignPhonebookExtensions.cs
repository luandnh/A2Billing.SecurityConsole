using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCampaignPhonebookExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCampaignPhonebook GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCampaignPhonebook> queryable, int idCampaign, int idPhonebook)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCampaignPhonebook> dbSet)
                return dbSet.Find(idCampaign, idPhonebook);

            return queryable.FirstOrDefault(q => q.IdCampaign == idCampaign
                && q.IdPhonebook == idPhonebook);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCampaignPhonebook> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCampaignPhonebook> queryable, int idCampaign, int idPhonebook)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCampaignPhonebook> dbSet)
                return dbSet.FindAsync(idCampaign, idPhonebook);

            var task = queryable.FirstOrDefaultAsync(q => q.IdCampaign == idCampaign
                && q.IdPhonebook == idPhonebook);
            return new ValueTask<A2BillingService.Data.Entities.CcCampaignPhonebook>(task);
        }

        #endregion

    }
}
