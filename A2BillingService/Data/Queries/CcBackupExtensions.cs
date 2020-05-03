using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcBackupExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcBackup GetByKey(this IQueryable<A2BillingService.Data.Entities.CcBackup> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcBackup> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcBackup> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcBackup> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcBackup> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcBackup>(task);
        }

        public static A2BillingService.Data.Entities.CcBackup GetByName(this IQueryable<A2BillingService.Data.Entities.CcBackup> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<A2BillingService.Data.Entities.CcBackup> GetByNameAsync(this IQueryable<A2BillingService.Data.Entities.CcBackup> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        #endregion

    }
}
