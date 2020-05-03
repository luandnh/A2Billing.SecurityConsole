using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace A2BillingService.Services
{
    public class SipAdditionService
    {
        private string fileDir;
        public SipAdditionService()
        {
            var serviceRoot = new ServiceRootConfig();
            fileDir = serviceRoot.SipAdditionConfig().Dir;
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
                    string extensionPattern = @"^(\[\d{4}\])";
                    Match m = Regex.Match(line, extensionPattern, RegexOptions.IgnoreCase);
                    if (m.Success)
                    {
                        var extension = m.Value.Substring(1, m.Value.Length - 2);
                        fileUpdate.Add(line);
                        for (int j = i+1; j < files.Length; j++)
                        {
                            var lineExten = files[j];
                            Match mExten = Regex.Match(lineExten, extensionPattern, RegexOptions.IgnoreCase);
                            if (mExten.Success || lineExten.Contains("tel4vntrunkout")) break;
                            string secretPattern = @"^(secret=[0-9a-zA-Z])";
                            Match secretMatch = Regex.Match(lineExten, secretPattern, RegexOptions.IgnoreCase);
                            if (secretMatch.Success)
                            {
                                var strSecret = lineExten.Split("=");
                                var md5secret = GenerateMD5FromString(extension + ":asterisk:" + strSecret[1]);
                                fileUpdate.Add("md5secret=" + md5secret);
                                countUpdate += 1;
                            }
                            else {
                                fileUpdate.Add(lineExten);
                            }
                        }
                    }else if (line.Contains("tel4vntrunkout"))
                    {
                        fileUpdate.Add(line);
                        for (int j = i + 1; j < files.Length; j++)
                        {
                            fileUpdate.Add(files[j]);
                        }
                        }

                }
                File.WriteAllLines(fileDir, fileUpdate.ToArray());
                return "Update Successful! "+countUpdate + " extensions have md5secret updated";
            }
            catch (IOException e)
            {
                return "The file could not be read:";
            }
        }
    }
}
