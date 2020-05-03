using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Queries
{
    public static partial class CcSipBuddiesExtensions
    {
        #region Generated Extensions
        public static IQueryable<A2BillingService.Data.Entities.CcSipBuddies> ByHost(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, string host)
        {
            return queryable.Where(q => q.Host == host);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcSipBuddies> ByHostPort(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, string host, string port)
        {
            return queryable.Where(q => q.Host == host
                && q.Port == port);
        }

        public static A2BillingService.Data.Entities.CcSipBuddies GetByKey(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcSipBuddies> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<A2BillingService.Data.Entities.CcSipBuddies> GetByKeyAsync(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, int id)
        {
            if (queryable is DbSet<A2BillingService.Data.Entities.CcSipBuddies> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<A2BillingService.Data.Entities.CcSipBuddies>(task);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcSipBuddies> ByIpaddr(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, string ipaddr)
        {
            return queryable.Where(q => q.Ipaddr == ipaddr);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcSipBuddies> ByIpaddrPort(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, string ipaddr, string port)
        {
            return queryable.Where(q => q.Ipaddr == ipaddr
                && q.Port == port);
        }

        public static A2BillingService.Data.Entities.CcSipBuddies GetByName(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, string name)
        {
            return queryable.FirstOrDefault(q => q.Name == name);
        }

        public static Task<A2BillingService.Data.Entities.CcSipBuddies> GetByNameAsync(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, string name)
        {
            return queryable.FirstOrDefaultAsync(q => q.Name == name);
        }

        public static IQueryable<A2BillingService.Data.Entities.CcSipBuddies> ByPort(this IQueryable<A2BillingService.Data.Entities.CcSipBuddies> queryable, string port)
        {
            return queryable.Where(q => q.Port == port);
        }

        #endregion

    }
}
