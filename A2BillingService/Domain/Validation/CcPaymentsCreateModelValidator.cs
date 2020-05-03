using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaymentsCreateModelValidator
        : AbstractValidator<CcPaymentsCreateModel>
    {
        public CcPaymentsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
