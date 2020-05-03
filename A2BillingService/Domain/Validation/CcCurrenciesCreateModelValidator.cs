using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCurrenciesCreateModelValidator
        : AbstractValidator<CcCurrenciesCreateModel>
    {
        public CcCurrenciesCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
