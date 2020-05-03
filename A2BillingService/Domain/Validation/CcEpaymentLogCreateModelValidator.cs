using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcEpaymentLogCreateModelValidator
        : AbstractValidator<CcEpaymentLogCreateModel>
    {
        public CcEpaymentLogCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
