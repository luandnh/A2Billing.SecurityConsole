using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCountryCreateModelValidator
        : AbstractValidator<CcCountryCreateModel>
    {
        public CcCountryCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
