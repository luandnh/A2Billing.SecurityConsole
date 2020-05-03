using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcProviderUpdateModelValidator
        : AbstractValidator<CcProviderUpdateModel>
    {
        public CcProviderUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
