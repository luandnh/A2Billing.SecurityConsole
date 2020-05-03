using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcCardGroupReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int UsersPerms { get; set; }

        public int? IdAgent { get; set; }

        public string Provisioning { get; set; }

        #endregion

    }
}
