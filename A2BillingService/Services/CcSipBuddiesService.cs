using A2BillingService.Data;
using A2BillingService.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace A2BillingService.Services
{
    public class CcSipBuddiesService
    {
        private DbContextOptionsBuilder<Mya2billingContext> options = null;
        
        public CcSipBuddiesService()
        {
            var serviceRoot = new ServiceRootConfig();
            var connectionStr = serviceRoot.A2BillingConfig().A2BillingConnectionString;
            options = new DbContextOptionsBuilder<Mya2billingContext>()
           .UseMySql(connectionStr);
        }
        public List<CcSipBuddies> ListCcSipBuddies()
        {
            using (var context = new Mya2billingContext(options.Options))
            {
                List<CcSipBuddies> result = new List<CcSipBuddies>();
                result = context.Set<CcSipBuddies>().ToList();
                return result;
            }
        }
        public string CheckMD5Secret(string accountCode)
        {
            using (var context = new Mya2billingContext(options.Options))
            {
                var user = context.Set<CcSipBuddies>().FirstOrDefault(p => p.Username == accountCode);
                if (user == null) return "Account is not exist!";
                if (user.Secret != "" && user.Md5secret == "")
                {
                    return "Secret is still clear text. Please choose option 3 to generate md5secret";
                }
                else if (user.Secret != "" && user.Md5secret != "")
                {
                    return "Secret still be clear text and md5secret has something. Please choose option 3 to generate md5secret and remove Secret!";
                }
                else
                {
                    return "MD5Secret is generated!";
                }
            }
        }
        public string GenerateMD5FromString(string str)
        {
            string result = "";
            using (MD5 hash = MD5.Create())
            {
                result = String.Join
                (
                    "",
                    from ba in hash.ComputeHash
                    (
                        Encoding.UTF8.GetBytes(str)
                    )
                    select ba.ToString("x2")
                );
            }
            return result;
        }
        public CcSipBuddies GenerateMD5SecretForAccount(string username)
        {
            using (var context = new Mya2billingContext(options.Options))
            {
                var user = context.Set<CcSipBuddies>().FirstOrDefault(p => p.Username == username);
                if (user == null) return null;
                if (user.Secret == "" && user.Md5secret != "")
                    return user;
                string secret = user.Secret;
                string accountCode = user.Accountcode;
                string md5secret = GenerateMD5FromString(accountCode + ":asterisk:" + secret);
                user.Md5secret = md5secret;
                user.Secret = "";
                context.Set<CcSipBuddies>().Update(user);
                context.SaveChanges();
                user = context.Set<CcSipBuddies>().FirstOrDefault(p => p.Username == username);
                return user;
            }
        }
        public List<CcSipBuddies> GenerateMD5SecretForAllAccounts()
        {
            using (var context = new Mya2billingContext(options.Options))
            {
                var users = context.Set<CcSipBuddies>().ToList();
                foreach (var user in users)
                {
                    if (user.Secret == "" && user.Md5secret != "")
                        continue;
                    string secret = user.Secret;
                    string accountCode = user.Accountcode;
                    string md5secret = GenerateMD5FromString(accountCode + ":asterisk:" + secret);
                    user.Md5secret = md5secret;
                    user.Secret = "";
                    context.Set<CcSipBuddies>().Update(user);
                    context.SaveChanges();
                }
                users = context.Set<CcSipBuddies>().ToList();
                return users;
            }
        }
        public string ToString(CcSipBuddies ccSip)
        {
            return "Account Code : " + ccSip.Accountcode + "; Secret: " + ccSip.Secret + "; MD5Secret: " + ccSip.Md5secret;
        }

    }
}
