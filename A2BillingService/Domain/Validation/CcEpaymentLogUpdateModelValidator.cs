using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcEpaymentLogUpdateModelValidator
        : AbstractValidator<CcEpaymentLogUpdateModel>
    {
        public CcEpaymentLogUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
