using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCampaignPhonestatusExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcCampaignPhonestatus GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCampaignPhonestatus> queryable, long idPhonenumber, int idCampaign)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCampaignPhonestatus> dbSet)
                return dbSet.Find(idPhonenumber, idCampaign);

            return queryable.FirstOrDefault(q => q.IdPhonenumber == idPhonenumber
                && q.IdCampaign == idCampaign);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCampaignPhonestatus> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCampaignPhonestatus> queryable, long idPhonenumber, int idCampaign)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCampaignPhonestatus> dbSet)
                return dbSet.FindAsync(idPhonenumber, idCampaign);

            var task = queryable.FirstOrDefaultAsync(q => q.IdPhonenumber == idPhonenumber
                && q.IdCampaign == idCampaign);
            return new ValueTask<A2BillingService.Data.Entities.CcCampaignPhonestatus>(task);
        }

        #endregion

    }
}
