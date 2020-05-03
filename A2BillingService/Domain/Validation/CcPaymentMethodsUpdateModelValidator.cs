using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPaymentMethodsUpdateModelValidator
        : AbstractValidator<CcPaymentMethodsUpdateModel>
    {
        public CcPaymentMethodsUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
