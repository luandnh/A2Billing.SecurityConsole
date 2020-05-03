using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcChargeUpdateModelValidator
        : AbstractValidator<CcChargeUpdateModel>
    {
        public CcChargeUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
