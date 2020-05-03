using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcRestrictedPhonenumberUpdateModelValidator
        : AbstractValidator<CcRestrictedPhonenumberUpdateModel>
    {
        public CcRestrictedPhonenumberUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
