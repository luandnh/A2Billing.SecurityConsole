using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcTariffplanExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcTariffplan GetByKey(this IQueryable<A2BillingService.Data.Entities.CcTariffplan> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTariffplan> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcTariffplan> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcTariffplan> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTariffplan> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcTariffplan>(task);
        }

        public static A2BillingService.Data.Entities.CcTariffplan GetByIduserTariffname(this IQueryable<A2BillingService.Data.Entities.CcTariffplan> queryable, int iduser, string tariffname)
        {
            return queryable.FirstOrDefault(q => q.Iduser == iduser
                && q.Tariffname == tariffname);
        }

        public static Task<A2BillingService.Data.Entities.CcTariffplan> GetByIduserTariffnameAsync(this IQueryable<A2BillingService.Data.Entities.CcTariffplan> queryable, int iduser, string tariffname)
        {
            return queryable.FirstOrDefaultAsync(q => q.Iduser == iduser
                && q.Tariffname == tariffname);
        }

        #endregion

    }
}
