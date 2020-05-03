using A2BillingService.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace A2BillingService
{
    public class ServiceRootConfig
    {
        public AppSettingsModel A2BillingConfig()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var config = builder.Build();
            return config.GetSection("ConnectionString").Get<AppSettingsModel>();
        }
        public SIPAdditionSettingModel SipAdditionConfig()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var config = builder.Build();
            return config.GetSection("SipAdditionConf").Get<SIPAdditionSettingModel>();
        }
    }
}
