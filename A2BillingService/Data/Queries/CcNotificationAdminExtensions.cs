using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcNotificationAdminExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcNotificationAdmin GetByKey(this IQueryable<A2BillingService.Data.Entities.CcNotificationAdmin> queryable, long idNotification, int idAdmin)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcNotificationAdmin> dbSet)
                return dbSet.Find(idNotification, idAdmin);

            return queryable.FirstOrDefault(q => q.IdNotification == idNotification
                && q.IdAdmin == idAdmin);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcNotificationAdmin> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcNotificationAdmin> queryable, long idNotification, int idAdmin)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcNotificationAdmin> dbSet)
                return dbSet.FindAsync(idNotification, idAdmin);

            var task = queryable.FirstOrDefaultAsync(q => q.IdNotification == idNotification
                && q.IdAdmin == idAdmin);
            return new ValueTask<A2BillingService.Data.Entities.CcNotificationAdmin>(task);
        }

        #endregion

    }
}
