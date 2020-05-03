using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcChargeCreateModelValidator
        : AbstractValidator<CcChargeCreateModel>
    {
        public CcChargeCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
