using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcChargeUpdateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdCcCard { get; set; }

        public int Iduser { get; set; }

        public DateTime Creationdate { get; set; }

        public float Amount { get; set; }

        public int? Chargetype { get; set; }

        public string Description { get; set; }

        public long? IdCcDid { get; set; }

        public long? IdCcCardSubscription { get; set; }

        public DateTime? CoverFrom { get; set; }

        public DateTime? CoverTo { get; set; }

        public sbyte ChargedStatus { get; set; }

        public sbyte InvoicedStatus { get; set; }

        #endregion

    }
}
