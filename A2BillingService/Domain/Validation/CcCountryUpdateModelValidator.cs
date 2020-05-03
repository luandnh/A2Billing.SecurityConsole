using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCountryUpdateModelValidator
        : AbstractValidator<CcCountryUpdateModel>
    {
        public CcCountryUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
