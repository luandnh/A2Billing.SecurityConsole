using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcCallArchiveExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcCallArchive> ByCalledstation(this IQueryable<A2BillingService.Data.Entities.CcCallArchive> queryable, string calledstation)
        {
            return queryable.Where(q => q.Calledstation == calledstation);
        }

        public static A2BillingService.Data.Entities.CcCallArchive GetByKey(this IQueryable<A2BillingService.Data.Entities.CcCallArchive> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCallArchive> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcCallArchive> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcCallArchive> queryable, long id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcCallArchive> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcCallArchive>(task);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcCallArchive> ByStarttime(this IQueryable<A2BillingService.Data.Entities.CcCallArchive> queryable, DateTime starttime)
        {
            return queryable.Where(q => q.Starttime == starttime);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcCallArchive> ByTerminatecauseid(this IQueryable<A2BillingService.Data.Entities.CcCallArchive> queryable, int? terminatecauseid)
        {
            return queryable.Where(q => (q.Terminatecauseid == terminatecauseid || (terminatecauseid == null && q.Terminatecauseid == null)));
        }

        #endregion

    }
}
