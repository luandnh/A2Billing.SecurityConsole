using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace A2BillingService.Models
{
    public class AppSettingsModel
    {
        public string A2BillingConnectionString { get; set; } = null;
    }
    public class SIPAdditionSettingModel
    {
        public string Dir { get; set; } = null;
    }
    public class A2BillingSipAdditionConf
    {
        public string Dir { get; set; } = null;
    }
}
