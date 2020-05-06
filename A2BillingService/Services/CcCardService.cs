using A2BillingService.Data;
using A2BillingService.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A2BillingService.Services
{
    public class CcCardService
    {
        private DbContextOptionsBuilder<Mya2billingContext> options = null;

        public CcCardService()
        {
            var serviceRoot = new ServiceRootConfig();
            var connectionStr = serviceRoot.A2BillingConfig().A2BillingConnectionString;
            options = new DbContextOptionsBuilder<Mya2billingContext>()
           .UseMySql(connectionStr);
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
        public CcCard GenerateMD5PasswordForAccount(string accountNumber)
        {
            using (var context = new Mya2billingContext(options.Options))
            {
                var user = context.Set<CcCard>().FirstOrDefault(p => p.Username == accountNumber);
                if (user == null) return null;
                var checkPass = Regex.IsMatch(user.Uipass, "^[0-9a-fA-F]{32}$", RegexOptions.Compiled);
                if (checkPass)
                    return user;
                string passwordGenerated = GenerateMD5FromString(user.Username + ":a2billing:" + user.Uipass);
                user.Uipass = passwordGenerated;
                context.Set<CcCard>().Update(user);
                context.SaveChanges();
                user = context.Set<CcCard>().FirstOrDefault(p => p.Username == accountNumber);
                return user;
            }
        }
        public List<CcCard> GenerateMD5PasswordForAllAccounts()
        {
            using (var context = new Mya2billingContext(options.Options))
            {
                var users = context.Set<CcCard>().ToList();
                foreach (var user in users)
                {
                    var checkPass = Regex.IsMatch(user.Uipass, "^[0-9a-fA-F]{32}$", RegexOptions.Compiled);
                    if (checkPass)
                        continue;
                    string passwordGenerated = GenerateMD5FromString(user.Username + ":a2billing:" + user.Uipass);
                    user.Uipass = passwordGenerated;
                    context.Set<CcCard>().Update(user);
                    context.SaveChanges();
                }
                users = context.Set<CcCard>().ToList();
                return users;
            }
        }
        public string ToString(CcCard card)
        {
            return "Account Number : " + card.Username + "; User Alias: " + card.Useralias + "; Password: " + card.Uipass;
        }
    }
}
