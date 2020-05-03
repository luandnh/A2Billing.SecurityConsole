using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcTimezoneUpdateModelValidator
        : AbstractValidator<CcTimezoneUpdateModel>
    {
        public CcTimezoneUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
