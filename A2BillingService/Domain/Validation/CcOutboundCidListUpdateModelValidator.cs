using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcOutboundCidListUpdateModelValidator
        : AbstractValidator<CcOutboundCidListUpdateModel>
    {
        public CcOutboundCidListUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
