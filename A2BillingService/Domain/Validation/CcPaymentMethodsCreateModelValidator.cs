using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaymentMethodsCreateModelValidator
        : AbstractValidator<CcPaymentMethodsCreateModel>
    {
        public CcPaymentMethodsCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
