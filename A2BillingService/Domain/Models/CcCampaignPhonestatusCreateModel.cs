using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcCampaignPhonestatusCreateModel
    {
        #region Generated Properties
        public long IdPhonenumber { get; set; }

        public int IdCampaign { get; set; }

        public string IdCallback { get; set; }

        public int Status { get; set; }

        public DateTime Lastuse { get; set; }

        #endregion

    }
}
