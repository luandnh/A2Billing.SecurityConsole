using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace A2BillingService.Services
{
    public class A2BillingSIPService
    {
        private string fileDir;
        public A2BillingSIPService()
        {
            var serviceRoot = new ServiceRootConfig();
            fileDir = serviceRoot.A2BillingSipAdditionConfig().Dir;
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
        public string ReadAndExec()
        {
            try
            {
                int countUpdate = 0;
                var fileUpdate = new List<string>();
                var files = File.ReadAllLines(fileDir);
                for (int i = 0; i < files.Length; i++)
                {
                    var line = files[i];
                    string extensionPattern = @"^(\[\d{10}\])";
                    Match m = Regex.Match(line, extensionPattern, RegexOptions.IgnoreCase);
                    if (m.Success)
                    {
                        fileUpdate.Add(line);
                        fileUpdate.Add("transport=udp,tcp");
                        countUpdate += 1;
                        for (int j = i + 1; j < files.Length; j++)
                        {
                            var lineExten = files[j];
                            Match mExten = Regex.Match(lineExten, extensionPattern, RegexOptions.IgnoreCase);
                            if (mExten.Success) break;
                            fileUpdate.Add(lineExten);
                        }
                    }
                }
                File.WriteAllLines(fileDir, fileUpdate.ToArray());
                return "Update Successful! " + countUpdate + " extensions have md5secret updated";
            }
            catch (IOException e)
            {
                return "The file could not be read:";
            }
        }
    }
}
