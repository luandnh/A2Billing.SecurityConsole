using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcReceiptCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdCard { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public sbyte Status { get; set; }

        #endregion

    }
}
