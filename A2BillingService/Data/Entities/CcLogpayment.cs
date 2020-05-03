using System;
using System.Collections.Generic;

namespace A2BillingService.Data.Entities
{
    public partial class CcLogpayment
    {
        public CcLogpayment()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Payment { get; set; }

        public long CardId { get; set; }

        public long? IdLogrefill { get; set; }

        public string Description { get; set; }

        public short AddedRefill { get; set; }

        public sbyte PaymentType { get; set; }

        public sbyte AddedCommission { get; set; }

        public long? AgentId { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
