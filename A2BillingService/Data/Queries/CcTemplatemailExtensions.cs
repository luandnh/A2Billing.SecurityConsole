using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcTemplatemailExtensions
    {
        #region Generated Extensions
        public static A2BillingService.Data.Entities.CcTemplatemail GetByKey(this IQueryable<A2BillingService.Data.Entities.CcTemplatemail> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTemplatemail> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcTemplatemail> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcTemplatemail> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcTemplatemail> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcTemplatemail>(task);
        }

        public static A2BillingService.Data.Entities.CcTemplatemail GetByMailtypeIdLanguage(this IQueryable<A2BillingService.Data.Entities.CcTemplatemail> queryable, string mailtype, string idLanguage)
        {
            return queryable.FirstOrDefault(q => (q.Mailtype == mailtype || (mailtype == null && q.Mailtype == null))
                && q.IdLanguage == idLanguage);
        }

        public static Task<A2BillingService.Data.Entities.CcTemplatemail> GetByMailtypeIdLanguageAsync(this IQueryable<A2BillingService.Data.Entities.CcTemplatemail> queryable, string mailtype, string idLanguage)
        {
            return queryable.FirstOrDefaultAsync(q => (q.Mailtype == mailtype || (mailtype == null && q.Mailtype == null))
                && q.IdLanguage == idLanguage);
        }

        #endregion

    }
}
