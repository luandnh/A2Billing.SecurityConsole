using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCardPackageOfferExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcCardPackageOffer> ByDateConsumption(this IQueryable<A2BillingService.Data.Entities.CcCardPackageOffer> queryable, DateTime dateConsumption)
        {
            return queryable.Where(q => q.DateConsumption == dateConsumption);
        }

        public static A2BillingService.Data.Entities.CcCardPackageOffer GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCardPackageOffer> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCardPackageOffer> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCardPackageOffer> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCardPackageOffer> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCardPackageOffer> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCardPackageOffer>(task);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcCardPackageOffer> ByIdCcCard(this IQueryable<A2BillingService.Data.Entities.CcCardPackageOffer> queryable, long idCcCard)
        {
            return queryable.Where(q => q.IdCcCard == idCcCard);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcCardPackageOffer> ByIdCcPackageOffer(this IQueryable<A2BillingService.Data.Entities.CcCardPackageOffer> queryable, long idCcPackageOffer)
        {
            return queryable.Where(q => q.IdCcPackageOffer == idCcPackageOffer);
        }

        #endregion

    }
}
