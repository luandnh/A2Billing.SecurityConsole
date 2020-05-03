using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPrefixUpdateModelValidator
        : AbstractValidator<CcPrefixUpdateModel>
    {
        public CcPrefixUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
