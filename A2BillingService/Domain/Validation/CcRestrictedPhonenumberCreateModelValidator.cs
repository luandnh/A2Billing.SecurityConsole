using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcRestrictedPhonenumberCreateModelValidator
        : AbstractValidator<CcRestrictedPhonenumberCreateModel>
    {
        public CcRestrictedPhonenumberCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
