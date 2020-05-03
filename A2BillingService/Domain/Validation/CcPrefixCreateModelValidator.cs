using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcPrefixCreateModelValidator
        : AbstractValidator<CcPrefixCreateModel>
    {
        public CcPrefixCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
