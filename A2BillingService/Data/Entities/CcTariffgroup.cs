using System;
using System.Collections.Generic;

namespace A2BillingService.Data.Entities
{
    public partial class CcTariffgroup
    {
        public CcTariffgroup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int Iduser { get; set; }

        public int Idtariffplan { get; set; }

        public string Tariffgroupname { get; set; }

        public int Lcrtype { get; set; }

        public DateTime Creationdate { get; set; }

        public int Removeinterprefix { get; set; }

        public long IdCcPackageOffer { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
