using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcTimezoneCreateModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Gmtzone { get; set; }

        public string Gmttime { get; set; }

        public long Gmtoffset { get; set; }

        #endregion

    }
}
