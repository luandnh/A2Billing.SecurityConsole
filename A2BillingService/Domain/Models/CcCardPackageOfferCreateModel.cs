using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcCardPackageOfferCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdCcCard { get; set; }

        public long IdCcPackageOffer { get; set; }

        public DateTime DateConsumption { get; set; }

        public long UsedSecondes { get; set; }

        #endregion

    }
}
