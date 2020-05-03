using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaymentsStatusUpdateModelValidator
        : AbstractValidator<CcPaymentsStatusUpdateModel>
    {
        public CcPaymentsStatusUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
