using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaymentsStatusCreateModelValidator
        : AbstractValidator<CcPaymentsStatusCreateModel>
    {
        public CcPaymentsStatusCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
